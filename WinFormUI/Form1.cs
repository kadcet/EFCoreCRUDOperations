using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using WinFormUI.Data;
using WinFormUI.ViewModels;

namespace WinFormUI
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		NorthwndDbContext context = new NorthwndDbContext();

		private void Form1_Load(object sender, EventArgs e)
		{
			FillCategoryGrid();
			//AsNoTrackingCalculation();
			FillCategoryCbb();
			FillProductGrid();
		}


		private void btnCategory_Click(object sender, EventArgs e)
		{
			Category addedCategory = new Category();
			addedCategory.CategoryName = txtCategoryName.Text;
			context.Categories.Add(addedCategory);

			#region AddRange ile toplu ekleme
			//List<Category> categories = new List<Category>
			//{
			//	new Category{CategoryName="Donaným"},
			//	new Category{CategoryName="Yazýlým"},
			//	new Category{CategoryName="Çevre Birimleri"}
			//};

			//context.Categories.AddRange(categories); 
			#endregion


			context.SaveChanges();

			FillCategoryGrid();

		}



		#region Helpers

		private void FillCategoryCbb()
		{
			var categories = context.Categories.AsNoTracking().ToList();

			//foreach (var category in categories)
			//{
			//	category.CategoryName = "Test";
			//}
			context.SaveChanges();  // AsNoTracking kullandýðým için Savechanges desemde veritabanýnda biþey olmayacak.


			cbbCategories.DataSource = categories;
			cbbCategories.DisplayMember = nameof(Category.CategoryName); // ekranda gözükecek olan
			cbbCategories.ValueMember = nameof(Category.CategoryID);    // combobox ýn ben seçim yaptýðýmda hangi datayý verecek. CategoryID
		}

		private void FillCategoryGrid()
		{

			//var kategoriler = context.Categories.Include(nameof(Category.Products)).ToList();
			//var categories = context.Categories.Include(c => c.Products).ToList();
			var categories = (from c in context.Categories.AsNoTracking().AsSplitQuery().Include(c => c.Products)
							  select new CategoryGridVM
							  {
								  Id = c.CategoryID,
								  Name = c.CategoryName,
								  ProductCount = c.Products.Count
							  }).ToList();

			grdCategories.DataSource = categories;
		}

		private void AsNoTrackingCalculation()
		{
			Stopwatch sw = new Stopwatch();
			sw.Start();

			context.Products.ToList();

			sw.Stop();

			TimeSpan calculatedTime = sw.Elapsed;

			string time = "with Traking" + calculatedTime.TotalMilliseconds.ToString();




			sw = new Stopwatch();
			sw.Start();


			// AsNoTracking() ile alýnan nesnelerin bellek üzerinde takip edilmesini istemediðimizi belirtiyoruz
			context.Products.AsNoTracking().ToList();
			sw.Stop();

			TimeSpan calculatedTime2 = sw.Elapsed;
			time += "With As No Tracking :" + calculatedTime2.TotalMilliseconds;

			MessageBox.Show(time);

		}

		private void FillProductGrid()
		{
			//var product = context.Products.AsNoTracking().Include(p=>p.Category).ToList();
			var product = from p in context.Products.AsNoTracking().Include(p => p.Category)
						  select new
						  {
							  Id = p.ProductID,
							  ProductName = p.ProductName,
							  CategoryName = p.Category.CategoryName

						  };
			grdProducts.DataSource = product.ToList();

		}
		#endregion


		private void btnProduct_Click(object sender, EventArgs e)
		{
			var categoryId = Convert.ToInt32(cbbCategories.SelectedValue); // combobox ta seçtiðim deðerin id si. geriye object döner. Convert et.

			Product product = new Product()
			{
				ProductName = txtProductName.Text,
				CategoryID = categoryId
			};

			context.Products.Add(product); // sadece bellek üzerinde context e eklenir
			context.SaveChanges();         // bu iþlem veri tabanýnda da olsun diye

			FillProductGrid();
		}

		private void silToolStripMenuItem_Click(object sender, EventArgs e)
		{
			int categoryId = Convert.ToInt32(grdCategories.CurrentRow.Cells[nameof(CategoryGridVM.Id)].Value);
			//var category =context.Categories.Find(categoryId);  // Find primary key alanýný ister
			var category = context.Categories.FirstOrDefault(c => c.CategoryID == categoryId);
			context.Categories.Remove(category);
			context.SaveChanges();

			FillCategoryGrid();

		}

		int updatedCategoryId;
		private void DuzenleToolStripMenuItem_Click(object sender, EventArgs e)
		{
			updatedCategoryId = Convert.ToInt32(grdCategories.CurrentRow.Cells[nameof(CategoryGridVM.Id)].Value);

			txtUpdateCategory.Text = grdCategories.CurrentRow.Cells[nameof(CategoryGridVM.Name)].Value.ToString();

			
		}

		private void btnUpdateCategory_Click(object sender, EventArgs e)
		{
			var category=context.Categories.FirstOrDefault(c=>c.CategoryID == updatedCategoryId);
			category.CategoryName = txtUpdateCategory.Text;
			context.SaveChanges();

			
			FillCategoryGrid();
		}
	}
}
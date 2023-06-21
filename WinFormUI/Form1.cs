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
			//	new Category{CategoryName="Donan�m"},
			//	new Category{CategoryName="Yaz�l�m"},
			//	new Category{CategoryName="�evre Birimleri"}
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
			context.SaveChanges();  // AsNoTracking kulland���m i�in Savechanges desemde veritaban�nda bi�ey olmayacak.


			cbbCategories.DataSource = categories;
			cbbCategories.DisplayMember = nameof(Category.CategoryName); // ekranda g�z�kecek olan
			cbbCategories.ValueMember = nameof(Category.CategoryID);    // combobox �n ben se�im yapt���mda hangi datay� verecek. CategoryID
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


			// AsNoTracking() ile al�nan nesnelerin bellek �zerinde takip edilmesini istemedi�imizi belirtiyoruz
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
			var categoryId = Convert.ToInt32(cbbCategories.SelectedValue); // combobox ta se�ti�im de�erin id si. geriye object d�ner. Convert et.

			Product product = new Product()
			{
				ProductName = txtProductName.Text,
				CategoryID = categoryId
			};

			context.Products.Add(product); // sadece bellek �zerinde context e eklenir
			context.SaveChanges();         // bu i�lem veri taban�nda da olsun diye

			FillProductGrid();
		}

		private void silToolStripMenuItem_Click(object sender, EventArgs e)
		{
			int categoryId = Convert.ToInt32(grdCategories.CurrentRow.Cells[nameof(CategoryGridVM.Id)].Value);
			//var category =context.Categories.Find(categoryId);  // Find primary key alan�n� ister
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
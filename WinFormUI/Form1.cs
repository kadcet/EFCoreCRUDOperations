using Microsoft.EntityFrameworkCore;
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
			GetCategoryData();
		}

		#region Helpers
		private void GetCategoryData()
		{

			//var kategoriler=context.Categories.Include(nameof(Category.Products)).ToList();
			//var categories = context.Categories.Include(c => c.Products).ToList();
			var categories = (from c in context.Categories.Include(c=>c.Products)
							 select new CategoryGridVM
							 {
								Id = c.CategoryID,
								 Name = c.CategoryName,
								 ProductCount = c.Products.Count
							 }).ToList();

			grdCategories.DataSource = categories;
		}

		#endregion
	}
}
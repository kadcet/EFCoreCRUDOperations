namespace WinFormUI
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			grdCategories = new DataGridView();
			label1 = new Label();
			txtCategoryName = new TextBox();
			btnCategory = new Button();
			cbbCategories = new ComboBox();
			btnProduct = new Button();
			txtProductName = new TextBox();
			grdProducts = new DataGridView();
			((System.ComponentModel.ISupportInitialize)grdCategories).BeginInit();
			((System.ComponentModel.ISupportInitialize)grdProducts).BeginInit();
			SuspendLayout();
			// 
			// grdCategories
			// 
			grdCategories.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			grdCategories.Location = new Point(3, 86);
			grdCategories.Name = "grdCategories";
			grdCategories.RowTemplate.Height = 25;
			grdCategories.Size = new Size(427, 333);
			grdCategories.TabIndex = 0;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(12, 9);
			label1.Name = "label1";
			label1.Size = new Size(72, 15);
			label1.TabIndex = 1;
			label1.Text = "Kategori Adı";
			// 
			// txtCategoryName
			// 
			txtCategoryName.Location = new Point(12, 27);
			txtCategoryName.Name = "txtCategoryName";
			txtCategoryName.Size = new Size(193, 23);
			txtCategoryName.TabIndex = 2;
			// 
			// btnCategory
			// 
			btnCategory.Location = new Point(12, 57);
			btnCategory.Name = "btnCategory";
			btnCategory.Size = new Size(193, 23);
			btnCategory.TabIndex = 3;
			btnCategory.Text = "Ekle";
			btnCategory.UseVisualStyleBackColor = true;
			btnCategory.Click += btnCategory_Click;
			// 
			// cbbCategories
			// 
			cbbCategories.FormattingEnabled = true;
			cbbCategories.Location = new Point(505, 9);
			cbbCategories.Name = "cbbCategories";
			cbbCategories.Size = new Size(243, 23);
			cbbCategories.TabIndex = 4;
			// 
			// btnProduct
			// 
			btnProduct.Location = new Point(505, 67);
			btnProduct.Name = "btnProduct";
			btnProduct.Size = new Size(243, 23);
			btnProduct.TabIndex = 5;
			btnProduct.Text = "Ekle";
			btnProduct.UseVisualStyleBackColor = true;
			btnProduct.Click += btnProduct_Click;
			// 
			// txtProductName
			// 
			txtProductName.Location = new Point(505, 38);
			txtProductName.Name = "txtProductName";
			txtProductName.Size = new Size(243, 23);
			txtProductName.TabIndex = 6;
			// 
			// grdProducts
			// 
			grdProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			grdProducts.Location = new Point(505, 96);
			grdProducts.Name = "grdProducts";
			grdProducts.RowTemplate.Height = 25;
			grdProducts.Size = new Size(620, 309);
			grdProducts.TabIndex = 7;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1146, 450);
			Controls.Add(grdProducts);
			Controls.Add(txtProductName);
			Controls.Add(btnProduct);
			Controls.Add(cbbCategories);
			Controls.Add(btnCategory);
			Controls.Add(txtCategoryName);
			Controls.Add(label1);
			Controls.Add(grdCategories);
			Name = "Form1";
			Text = "Form1";
			Load += Form1_Load;
			((System.ComponentModel.ISupportInitialize)grdCategories).EndInit();
			((System.ComponentModel.ISupportInitialize)grdProducts).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private DataGridView grdCategories;
		private Label label1;
		private TextBox txtCategoryName;
		private Button btnCategory;
		private ComboBox cbbCategories;
		private Button btnProduct;
		private TextBox txtProductName;
		private DataGridView grdProducts;
	}
}
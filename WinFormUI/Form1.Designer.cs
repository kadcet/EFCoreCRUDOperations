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
			components = new System.ComponentModel.Container();
			grdCategories = new DataGridView();
			ctxgrdCategoryMenu = new ContextMenuStrip(components);
			silToolStripMenuItem = new ToolStripMenuItem();
			toolStripSeparator1 = new ToolStripSeparator();
			düzenleToolStripMenuItem = new ToolStripMenuItem();
			label1 = new Label();
			txtCategoryName = new TextBox();
			btnCategory = new Button();
			cbbCategories = new ComboBox();
			btnProduct = new Button();
			txtProductName = new TextBox();
			grdProducts = new DataGridView();
			groupBox1 = new GroupBox();
			groupBox2 = new GroupBox();
			label2 = new Label();
			btnUpdateCategory = new Button();
			txtUpdateCategory = new TextBox();
			((System.ComponentModel.ISupportInitialize)grdCategories).BeginInit();
			ctxgrdCategoryMenu.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)grdProducts).BeginInit();
			groupBox1.SuspendLayout();
			groupBox2.SuspendLayout();
			SuspendLayout();
			// 
			// grdCategories
			// 
			grdCategories.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			grdCategories.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			grdCategories.ContextMenuStrip = ctxgrdCategoryMenu;
			grdCategories.Location = new Point(3, 253);
			grdCategories.MultiSelect = false;
			grdCategories.Name = "grdCategories";
			grdCategories.ReadOnly = true;
			grdCategories.RowHeadersVisible = false;
			grdCategories.RowTemplate.Height = 25;
			grdCategories.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			grdCategories.Size = new Size(268, 298);
			grdCategories.TabIndex = 0;
			// 
			// ctxgrdCategoryMenu
			// 
			ctxgrdCategoryMenu.Items.AddRange(new ToolStripItem[] { silToolStripMenuItem, toolStripSeparator1, düzenleToolStripMenuItem });
			ctxgrdCategoryMenu.Name = "ctxgrdCategoryMenu";
			ctxgrdCategoryMenu.Size = new Size(181, 76);
			// 
			// silToolStripMenuItem
			// 
			silToolStripMenuItem.Name = "silToolStripMenuItem";
			silToolStripMenuItem.Size = new Size(180, 22);
			silToolStripMenuItem.Text = "Sil";
			silToolStripMenuItem.Click += silToolStripMenuItem_Click;
			// 
			// toolStripSeparator1
			// 
			toolStripSeparator1.Name = "toolStripSeparator1";
			toolStripSeparator1.Size = new Size(177, 6);
			// 
			// düzenleToolStripMenuItem
			// 
			düzenleToolStripMenuItem.Name = "düzenleToolStripMenuItem";
			düzenleToolStripMenuItem.Size = new Size(180, 22);
			düzenleToolStripMenuItem.Text = "Düzenle";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(6, 24);
			label1.Name = "label1";
			label1.Size = new Size(72, 15);
			label1.TabIndex = 1;
			label1.Text = "Kategori Adı";
			// 
			// txtCategoryName
			// 
			txtCategoryName.Location = new Point(6, 45);
			txtCategoryName.Name = "txtCategoryName";
			txtCategoryName.Size = new Size(238, 23);
			txtCategoryName.TabIndex = 2;
			// 
			// btnCategory
			// 
			btnCategory.Location = new Point(6, 75);
			btnCategory.Name = "btnCategory";
			btnCategory.Size = new Size(238, 23);
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
			// groupBox1
			// 
			groupBox1.Controls.Add(txtCategoryName);
			groupBox1.Controls.Add(label1);
			groupBox1.Controls.Add(btnCategory);
			groupBox1.Location = new Point(21, 9);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(250, 106);
			groupBox1.TabIndex = 8;
			groupBox1.TabStop = false;
			groupBox1.Text = "Kategori Ekle";
			// 
			// groupBox2
			// 
			groupBox2.Controls.Add(label2);
			groupBox2.Controls.Add(btnUpdateCategory);
			groupBox2.Controls.Add(txtUpdateCategory);
			groupBox2.Location = new Point(21, 133);
			groupBox2.Name = "groupBox2";
			groupBox2.Size = new Size(250, 114);
			groupBox2.TabIndex = 9;
			groupBox2.TabStop = false;
			groupBox2.Text = "Kategori Güncelle";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(6, 29);
			label2.Name = "label2";
			label2.Size = new Size(72, 15);
			label2.TabIndex = 2;
			label2.Text = "Kategori Adı";
			// 
			// btnUpdateCategory
			// 
			btnUpdateCategory.Location = new Point(6, 85);
			btnUpdateCategory.Name = "btnUpdateCategory";
			btnUpdateCategory.Size = new Size(238, 23);
			btnUpdateCategory.TabIndex = 1;
			btnUpdateCategory.Text = "Güncelle";
			btnUpdateCategory.UseVisualStyleBackColor = true;
			// 
			// txtUpdateCategory
			// 
			txtUpdateCategory.Location = new Point(6, 56);
			txtUpdateCategory.Name = "txtUpdateCategory";
			txtUpdateCategory.Size = new Size(238, 23);
			txtUpdateCategory.TabIndex = 0;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1461, 579);
			Controls.Add(groupBox2);
			Controls.Add(groupBox1);
			Controls.Add(grdProducts);
			Controls.Add(txtProductName);
			Controls.Add(btnProduct);
			Controls.Add(cbbCategories);
			Controls.Add(grdCategories);
			Name = "Form1";
			Text = "Form1";
			Load += Form1_Load;
			((System.ComponentModel.ISupportInitialize)grdCategories).EndInit();
			ctxgrdCategoryMenu.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)grdProducts).EndInit();
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			groupBox2.ResumeLayout(false);
			groupBox2.PerformLayout();
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
		private GroupBox groupBox1;
		private GroupBox groupBox2;
		private Label label2;
		private Button btnUpdateCategory;
		private TextBox txtUpdateCategory;
		private ContextMenuStrip ctxgrdCategoryMenu;
		private ToolStripMenuItem silToolStripMenuItem;
		private ToolStripSeparator toolStripSeparator1;
		private ToolStripMenuItem düzenleToolStripMenuItem;
	}
}
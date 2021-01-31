
namespace Bakery
{
    partial class AdminPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.buttonDeletePage = new System.Windows.Forms.Button();
            this.buttonUpdatePage = new System.Windows.Forms.Button();
            this.buttonAddPage = new System.Windows.Forms.Button();
            this.dataGridViewProducts = new System.Windows.Forms.DataGridView();
            this.buttonCategory = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.buttonCategory);
            this.splitContainer1.Panel1.Controls.Add(this.buttonDeletePage);
            this.splitContainer1.Panel1.Controls.Add(this.buttonUpdatePage);
            this.splitContainer1.Panel1.Controls.Add(this.buttonAddPage);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridViewProducts);
            this.splitContainer1.Size = new System.Drawing.Size(1263, 341);
            this.splitContainer1.SplitterDistance = 257;
            this.splitContainer1.TabIndex = 0;
            // 
            // buttonDeletePage
            // 
            this.buttonDeletePage.Location = new System.Drawing.Point(51, 179);
            this.buttonDeletePage.Name = "buttonDeletePage";
            this.buttonDeletePage.Size = new System.Drawing.Size(140, 31);
            this.buttonDeletePage.TabIndex = 2;
            this.buttonDeletePage.Text = "Ürün Sil";
            this.buttonDeletePage.UseVisualStyleBackColor = true;
            this.buttonDeletePage.Click += new System.EventHandler(this.buttonDeletePage_Click);
            // 
            // buttonUpdatePage
            // 
            this.buttonUpdatePage.Location = new System.Drawing.Point(51, 107);
            this.buttonUpdatePage.Name = "buttonUpdatePage";
            this.buttonUpdatePage.Size = new System.Drawing.Size(140, 35);
            this.buttonUpdatePage.TabIndex = 1;
            this.buttonUpdatePage.Text = "Ürün Güncelle";
            this.buttonUpdatePage.UseVisualStyleBackColor = true;
            this.buttonUpdatePage.Click += new System.EventHandler(this.buttonUpdatePage_Click);
            // 
            // buttonAddPage
            // 
            this.buttonAddPage.Location = new System.Drawing.Point(51, 38);
            this.buttonAddPage.Name = "buttonAddPage";
            this.buttonAddPage.Size = new System.Drawing.Size(140, 31);
            this.buttonAddPage.TabIndex = 0;
            this.buttonAddPage.Text = "Ürün Ekle";
            this.buttonAddPage.UseVisualStyleBackColor = true;
            this.buttonAddPage.Click += new System.EventHandler(this.buttonAddPage_Click);
            // 
            // dataGridViewProducts
            // 
            this.dataGridViewProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewProducts.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewProducts.Name = "dataGridViewProducts";
            this.dataGridViewProducts.RowHeadersWidth = 51;
            this.dataGridViewProducts.RowTemplate.Height = 24;
            this.dataGridViewProducts.Size = new System.Drawing.Size(998, 337);
            this.dataGridViewProducts.TabIndex = 0;
            // 
            // buttonCategory
            // 
            this.buttonCategory.Location = new System.Drawing.Point(51, 252);
            this.buttonCategory.Name = "buttonCategory";
            this.buttonCategory.Size = new System.Drawing.Size(140, 31);
            this.buttonCategory.TabIndex = 3;
            this.buttonCategory.Text = "Kategorileri Gör";
            this.buttonCategory.UseVisualStyleBackColor = true;
            this.buttonCategory.Click += new System.EventHandler(this.buttonCategory_Click);
            // 
            // AdminPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1263, 341);
            this.Controls.Add(this.splitContainer1);
            this.Name = "AdminPage";
            this.Text = "AdminPage";
            this.Load += new System.EventHandler(this.AdminPage_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button buttonDeletePage;
        private System.Windows.Forms.Button buttonUpdatePage;
        private System.Windows.Forms.Button buttonAddPage;
        private System.Windows.Forms.DataGridView dataGridViewProducts;
        private System.Windows.Forms.Button buttonCategory;
    }
}
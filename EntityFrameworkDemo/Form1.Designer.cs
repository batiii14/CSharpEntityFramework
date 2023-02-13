
namespace EntityFrameworkDemo
{
    partial class Form1
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
            this.btnRemove = new System.Windows.Forms.Button();
            this.gbxUpdate = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.tbxUnitPriceUpdate = new System.Windows.Forms.TextBox();
            this.tbxStockAmountUpdate = new System.Windows.Forms.TextBox();
            this.lblNameUpdate = new System.Windows.Forms.Label();
            this.tbxNameUpdate = new System.Windows.Forms.TextBox();
            this.lblStockAmountUpdate = new System.Windows.Forms.Label();
            this.lblUnitPriceUpdate = new System.Windows.Forms.Label();
            this.gbxAdd = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbxUnitPrice = new System.Windows.Forms.TextBox();
            this.tbxStockAmount = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.lblStockAmount = new System.Windows.Forms.Label();
            this.lblUnitPrice = new System.Windows.Forms.Label();
            this.dgwProducts = new System.Windows.Forms.DataGridView();
            this.tbxGetById = new System.Windows.Forms.TextBox();
            this.tbxGetByUnitPrice = new System.Windows.Forms.TextBox();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.tbxMin = new System.Windows.Forms.TextBox();
            this.tbxMax = new System.Windows.Forms.TextBox();
            this.btnGetByUnitPrice = new System.Windows.Forms.Button();
            this.lblGetById = new System.Windows.Forms.Label();
            this.lblGetByUnitPrice = new System.Windows.Forms.Label();
            this.lblMin = new System.Windows.Forms.Label();
            this.lblMax = new System.Windows.Forms.Label();
            this.lblSearch = new System.Windows.Forms.Label();
            this.gbxUpdate.SuspendLayout();
            this.gbxAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(362, 404);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 13;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // gbxUpdate
            // 
            this.gbxUpdate.Controls.Add(this.btnUpdate);
            this.gbxUpdate.Controls.Add(this.tbxUnitPriceUpdate);
            this.gbxUpdate.Controls.Add(this.tbxStockAmountUpdate);
            this.gbxUpdate.Controls.Add(this.lblNameUpdate);
            this.gbxUpdate.Controls.Add(this.tbxNameUpdate);
            this.gbxUpdate.Controls.Add(this.lblStockAmountUpdate);
            this.gbxUpdate.Controls.Add(this.lblUnitPriceUpdate);
            this.gbxUpdate.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbxUpdate.Location = new System.Drawing.Point(467, 239);
            this.gbxUpdate.Name = "gbxUpdate";
            this.gbxUpdate.Size = new System.Drawing.Size(289, 159);
            this.gbxUpdate.TabIndex = 12;
            this.gbxUpdate.TabStop = false;
            this.gbxUpdate.Text = "Update a Product";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(119, 130);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(130, 23);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // tbxUnitPriceUpdate
            // 
            this.tbxUnitPriceUpdate.Location = new System.Drawing.Point(119, 58);
            this.tbxUnitPriceUpdate.Name = "tbxUnitPriceUpdate";
            this.tbxUnitPriceUpdate.Size = new System.Drawing.Size(149, 21);
            this.tbxUnitPriceUpdate.TabIndex = 5;
            // 
            // tbxStockAmountUpdate
            // 
            this.tbxStockAmountUpdate.Location = new System.Drawing.Point(119, 92);
            this.tbxStockAmountUpdate.Name = "tbxStockAmountUpdate";
            this.tbxStockAmountUpdate.Size = new System.Drawing.Size(149, 21);
            this.tbxStockAmountUpdate.TabIndex = 6;
            // 
            // lblNameUpdate
            // 
            this.lblNameUpdate.AutoSize = true;
            this.lblNameUpdate.Location = new System.Drawing.Point(26, 32);
            this.lblNameUpdate.Name = "lblNameUpdate";
            this.lblNameUpdate.Size = new System.Drawing.Size(34, 13);
            this.lblNameUpdate.TabIndex = 1;
            this.lblNameUpdate.Text = "Name";
            // 
            // tbxNameUpdate
            // 
            this.tbxNameUpdate.Location = new System.Drawing.Point(119, 24);
            this.tbxNameUpdate.Name = "tbxNameUpdate";
            this.tbxNameUpdate.Size = new System.Drawing.Size(149, 21);
            this.tbxNameUpdate.TabIndex = 2;
            // 
            // lblStockAmountUpdate
            // 
            this.lblStockAmountUpdate.AutoSize = true;
            this.lblStockAmountUpdate.Location = new System.Drawing.Point(26, 95);
            this.lblStockAmountUpdate.Name = "lblStockAmountUpdate";
            this.lblStockAmountUpdate.Size = new System.Drawing.Size(73, 13);
            this.lblStockAmountUpdate.TabIndex = 4;
            this.lblStockAmountUpdate.Text = "Stock Amount";
            // 
            // lblUnitPriceUpdate
            // 
            this.lblUnitPriceUpdate.AutoSize = true;
            this.lblUnitPriceUpdate.Location = new System.Drawing.Point(26, 63);
            this.lblUnitPriceUpdate.Name = "lblUnitPriceUpdate";
            this.lblUnitPriceUpdate.Size = new System.Drawing.Size(52, 13);
            this.lblUnitPriceUpdate.TabIndex = 3;
            this.lblUnitPriceUpdate.Text = "Unit Price";
            // 
            // gbxAdd
            // 
            this.gbxAdd.Controls.Add(this.btnAdd);
            this.gbxAdd.Controls.Add(this.tbxUnitPrice);
            this.gbxAdd.Controls.Add(this.tbxStockAmount);
            this.gbxAdd.Controls.Add(this.lblName);
            this.gbxAdd.Controls.Add(this.tbxName);
            this.gbxAdd.Controls.Add(this.lblStockAmount);
            this.gbxAdd.Controls.Add(this.lblUnitPrice);
            this.gbxAdd.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbxAdd.Location = new System.Drawing.Point(30, 239);
            this.gbxAdd.Name = "gbxAdd";
            this.gbxAdd.Size = new System.Drawing.Size(289, 159);
            this.gbxAdd.TabIndex = 11;
            this.gbxAdd.TabStop = false;
            this.gbxAdd.Text = "Add a Product";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(119, 130);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(130, 23);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbxUnitPrice
            // 
            this.tbxUnitPrice.Location = new System.Drawing.Point(119, 58);
            this.tbxUnitPrice.Name = "tbxUnitPrice";
            this.tbxUnitPrice.Size = new System.Drawing.Size(149, 21);
            this.tbxUnitPrice.TabIndex = 5;
            // 
            // tbxStockAmount
            // 
            this.tbxStockAmount.Location = new System.Drawing.Point(119, 92);
            this.tbxStockAmount.Name = "tbxStockAmount";
            this.tbxStockAmount.Size = new System.Drawing.Size(149, 21);
            this.tbxStockAmount.TabIndex = 6;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(26, 32);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(34, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name";
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(119, 24);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(149, 21);
            this.tbxName.TabIndex = 2;
            // 
            // lblStockAmount
            // 
            this.lblStockAmount.AutoSize = true;
            this.lblStockAmount.Location = new System.Drawing.Point(26, 95);
            this.lblStockAmount.Name = "lblStockAmount";
            this.lblStockAmount.Size = new System.Drawing.Size(73, 13);
            this.lblStockAmount.TabIndex = 4;
            this.lblStockAmount.Text = "Stock Amount";
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.AutoSize = true;
            this.lblUnitPrice.Location = new System.Drawing.Point(26, 63);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(52, 13);
            this.lblUnitPrice.TabIndex = 3;
            this.lblUnitPrice.Text = "Unit Price";
            // 
            // dgwProducts
            // 
            this.dgwProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwProducts.Location = new System.Drawing.Point(30, 93);
            this.dgwProducts.Name = "dgwProducts";
            this.dgwProducts.Size = new System.Drawing.Size(740, 140);
            this.dgwProducts.TabIndex = 10;
            this.dgwProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwProducts_CellClick);
            // 
            // tbxGetById
            // 
            this.tbxGetById.Location = new System.Drawing.Point(69, 67);
            this.tbxGetById.Name = "tbxGetById";
            this.tbxGetById.Size = new System.Drawing.Size(100, 20);
            this.tbxGetById.TabIndex = 14;
            this.tbxGetById.TextChanged += new System.EventHandler(this.tbxGetById_TextChanged);
            // 
            // tbxGetByUnitPrice
            // 
            this.tbxGetByUnitPrice.Location = new System.Drawing.Point(271, 67);
            this.tbxGetByUnitPrice.Name = "tbxGetByUnitPrice";
            this.tbxGetByUnitPrice.Size = new System.Drawing.Size(100, 20);
            this.tbxGetByUnitPrice.TabIndex = 15;
            this.tbxGetByUnitPrice.TextChanged += new System.EventHandler(this.tbxGetByUnitPrice_TextChanged);
            // 
            // tbxSearch
            // 
            this.tbxSearch.Location = new System.Drawing.Point(670, 67);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(100, 20);
            this.tbxSearch.TabIndex = 16;
            this.tbxSearch.TextChanged += new System.EventHandler(this.tbxSearch_TextChanged);
            // 
            // tbxMin
            // 
            this.tbxMin.Location = new System.Drawing.Point(457, 12);
            this.tbxMin.Name = "tbxMin";
            this.tbxMin.Size = new System.Drawing.Size(100, 20);
            this.tbxMin.TabIndex = 17;
            // 
            // tbxMax
            // 
            this.tbxMax.Location = new System.Drawing.Point(457, 38);
            this.tbxMax.Name = "tbxMax";
            this.tbxMax.Size = new System.Drawing.Size(100, 20);
            this.tbxMax.TabIndex = 18;
            // 
            // btnGetByUnitPrice
            // 
            this.btnGetByUnitPrice.Location = new System.Drawing.Point(408, 64);
            this.btnGetByUnitPrice.Name = "btnGetByUnitPrice";
            this.btnGetByUnitPrice.Size = new System.Drawing.Size(158, 23);
            this.btnGetByUnitPrice.TabIndex = 19;
            this.btnGetByUnitPrice.Text = "Get By Unit Price";
            this.btnGetByUnitPrice.UseVisualStyleBackColor = true;
            this.btnGetByUnitPrice.Click += new System.EventHandler(this.btnGetByUnitPrice_Click);
            // 
            // lblGetById
            // 
            this.lblGetById.AutoSize = true;
            this.lblGetById.Location = new System.Drawing.Point(12, 70);
            this.lblGetById.Name = "lblGetById";
            this.lblGetById.Size = new System.Drawing.Size(51, 13);
            this.lblGetById.TabIndex = 20;
            this.lblGetById.Text = "Get By Id";
            // 
            // lblGetByUnitPrice
            // 
            this.lblGetByUnitPrice.AutoSize = true;
            this.lblGetByUnitPrice.Location = new System.Drawing.Point(177, 70);
            this.lblGetByUnitPrice.Name = "lblGetByUnitPrice";
            this.lblGetByUnitPrice.Size = new System.Drawing.Size(88, 13);
            this.lblGetByUnitPrice.TabIndex = 21;
            this.lblGetByUnitPrice.Text = "Get By Unit Price";
            // 
            // lblMin
            // 
            this.lblMin.AutoSize = true;
            this.lblMin.Location = new System.Drawing.Point(400, 19);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(51, 13);
            this.lblMin.TabIndex = 22;
            this.lblMin.Text = "Price Min";
            // 
            // lblMax
            // 
            this.lblMax.AutoSize = true;
            this.lblMax.Location = new System.Drawing.Point(397, 45);
            this.lblMax.Name = "lblMax";
            this.lblMax.Size = new System.Drawing.Size(54, 13);
            this.lblMax.TabIndex = 23;
            this.lblMax.Text = "Price Max";
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(623, 70);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(41, 13);
            this.lblSearch.TabIndex = 24;
            this.lblSearch.Text = "Search";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.lblMax);
            this.Controls.Add(this.lblMin);
            this.Controls.Add(this.lblGetByUnitPrice);
            this.Controls.Add(this.lblGetById);
            this.Controls.Add(this.btnGetByUnitPrice);
            this.Controls.Add(this.tbxMax);
            this.Controls.Add(this.tbxMin);
            this.Controls.Add(this.tbxSearch);
            this.Controls.Add(this.tbxGetByUnitPrice);
            this.Controls.Add(this.tbxGetById);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.gbxUpdate);
            this.Controls.Add(this.gbxAdd);
            this.Controls.Add(this.dgwProducts);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbxUpdate.ResumeLayout(false);
            this.gbxUpdate.PerformLayout();
            this.gbxAdd.ResumeLayout(false);
            this.gbxAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.GroupBox gbxUpdate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox tbxUnitPriceUpdate;
        private System.Windows.Forms.TextBox tbxStockAmountUpdate;
        private System.Windows.Forms.Label lblNameUpdate;
        private System.Windows.Forms.TextBox tbxNameUpdate;
        private System.Windows.Forms.Label lblStockAmountUpdate;
        private System.Windows.Forms.Label lblUnitPriceUpdate;
        private System.Windows.Forms.GroupBox gbxAdd;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox tbxUnitPrice;
        private System.Windows.Forms.TextBox tbxStockAmount;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.Label lblStockAmount;
        private System.Windows.Forms.Label lblUnitPrice;
        private System.Windows.Forms.DataGridView dgwProducts;
        private System.Windows.Forms.TextBox tbxGetById;
        private System.Windows.Forms.TextBox tbxGetByUnitPrice;
        private System.Windows.Forms.TextBox tbxSearch;
        private System.Windows.Forms.TextBox tbxMin;
        private System.Windows.Forms.TextBox tbxMax;
        private System.Windows.Forms.Button btnGetByUnitPrice;
        private System.Windows.Forms.Label lblGetById;
        private System.Windows.Forms.Label lblGetByUnitPrice;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.Label lblMax;
        private System.Windows.Forms.Label lblSearch;
    }
}


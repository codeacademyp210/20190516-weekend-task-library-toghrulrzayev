namespace Library
{
    partial class Categories
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
            this.CategoriesDataGrid = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoriesName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnResetCategori = new System.Windows.Forms.Button();
            this.btnDeleteCategori = new System.Windows.Forms.Button();
            this.btnSaveCategori = new System.Windows.Forms.Button();
            this.txtNameCategori = new System.Windows.Forms.TextBox();
            this.Name1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CategoriesDataGrid)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CategoriesDataGrid
            // 
            this.CategoriesDataGrid.AllowUserToAddRows = false;
            this.CategoriesDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CategoriesDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CategoriesDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.CategoriesName});
            this.CategoriesDataGrid.Location = new System.Drawing.Point(216, 31);
            this.CategoriesDataGrid.Name = "CategoriesDataGrid";
            this.CategoriesDataGrid.Size = new System.Drawing.Size(353, 293);
            this.CategoriesDataGrid.TabIndex = 0;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // CategoriesName
            // 
            this.CategoriesName.HeaderText = "Name";
            this.CategoriesName.Name = "CategoriesName";
            this.CategoriesName.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnResetCategori);
            this.panel1.Controls.Add(this.btnDeleteCategori);
            this.panel1.Controls.Add(this.btnSaveCategori);
            this.panel1.Controls.Add(this.txtNameCategori);
            this.panel1.Controls.Add(this.Name1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 336);
            this.panel1.TabIndex = 1;
            // 
            // btnResetCategori
            // 
            this.btnResetCategori.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetCategori.Location = new System.Drawing.Point(113, 177);
            this.btnResetCategori.Name = "btnResetCategori";
            this.btnResetCategori.Size = new System.Drawing.Size(75, 35);
            this.btnResetCategori.TabIndex = 4;
            this.btnResetCategori.Text = "Reset";
            this.btnResetCategori.UseVisualStyleBackColor = true;
            this.btnResetCategori.Click += new System.EventHandler(this.BtnResetCategori_Click);
            // 
            // btnDeleteCategori
            // 
            this.btnDeleteCategori.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteCategori.Location = new System.Drawing.Point(16, 177);
            this.btnDeleteCategori.Name = "btnDeleteCategori";
            this.btnDeleteCategori.Size = new System.Drawing.Size(75, 35);
            this.btnDeleteCategori.TabIndex = 3;
            this.btnDeleteCategori.Text = "Delete";
            this.btnDeleteCategori.UseVisualStyleBackColor = true;
            this.btnDeleteCategori.Click += new System.EventHandler(this.BtnDeleteCategori_Click);
            // 
            // btnSaveCategori
            // 
            this.btnSaveCategori.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveCategori.Location = new System.Drawing.Point(16, 117);
            this.btnSaveCategori.Name = "btnSaveCategori";
            this.btnSaveCategori.Size = new System.Drawing.Size(172, 40);
            this.btnSaveCategori.TabIndex = 2;
            this.btnSaveCategori.Text = "Save";
            this.btnSaveCategori.UseVisualStyleBackColor = true;
            this.btnSaveCategori.Click += new System.EventHandler(this.BtnSaveCategori_Click);
            // 
            // txtNameCategori
            // 
            this.txtNameCategori.Location = new System.Drawing.Point(16, 71);
            this.txtNameCategori.Name = "txtNameCategori";
            this.txtNameCategori.Size = new System.Drawing.Size(172, 20);
            this.txtNameCategori.TabIndex = 1;
            this.txtNameCategori.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNameCategori_KeyPress);
            // 
            // Name1
            // 
            this.Name1.AutoSize = true;
            this.Name1.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name1.Location = new System.Drawing.Point(13, 40);
            this.Name1.Name = "Name1";
            this.Name1.Size = new System.Drawing.Size(49, 18);
            this.Name1.TabIndex = 0;
            this.Name1.Text = "Name";
            // 
            // Categories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 336);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.CategoriesDataGrid);
            this.MaximizeBox = false;
            this.Name = "Categories";
            this.Text = "Categories";
            ((System.ComponentModel.ISupportInitialize)(this.CategoriesDataGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView CategoriesDataGrid;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnResetCategori;
        private System.Windows.Forms.Button btnDeleteCategori;
        private System.Windows.Forms.Button btnSaveCategori;
        private System.Windows.Forms.TextBox txtNameCategori;
        private System.Windows.Forms.Label Name1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoriesName;
    }
}
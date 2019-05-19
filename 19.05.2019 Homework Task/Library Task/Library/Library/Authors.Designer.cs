namespace Library
{
    partial class Authors
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnReset_Author = new System.Windows.Forms.Button();
            this.btnDelete_Author = new System.Windows.Forms.Button();
            this.btnSave_Author = new System.Windows.Forms.Button();
            this.txtSurname_Author = new System.Windows.Forms.TextBox();
            this.txtName_Author = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AuthorsDataGrid = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AuthorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AuthorSuname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AuthorsDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnReset_Author);
            this.panel1.Controls.Add(this.btnDelete_Author);
            this.panel1.Controls.Add(this.btnSave_Author);
            this.panel1.Controls.Add(this.txtSurname_Author);
            this.panel1.Controls.Add(this.txtName_Author);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(243, 450);
            this.panel1.TabIndex = 0;
            // 
            // btnReset_Author
            // 
            this.btnReset_Author.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset_Author.Location = new System.Drawing.Point(117, 285);
            this.btnReset_Author.Name = "btnReset_Author";
            this.btnReset_Author.Size = new System.Drawing.Size(104, 39);
            this.btnReset_Author.TabIndex = 6;
            this.btnReset_Author.Text = "Reset";
            this.btnReset_Author.UseVisualStyleBackColor = true;
            this.btnReset_Author.Click += new System.EventHandler(this.BtnReset_Author_Click);
            // 
            // btnDelete_Author
            // 
            this.btnDelete_Author.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete_Author.Location = new System.Drawing.Point(12, 285);
            this.btnDelete_Author.Name = "btnDelete_Author";
            this.btnDelete_Author.Size = new System.Drawing.Size(99, 39);
            this.btnDelete_Author.TabIndex = 5;
            this.btnDelete_Author.Text = "Delete";
            this.btnDelete_Author.UseVisualStyleBackColor = true;
            this.btnDelete_Author.Click += new System.EventHandler(this.BtnDelete_Author_Click);
            // 
            // btnSave_Author
            // 
            this.btnSave_Author.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave_Author.Location = new System.Drawing.Point(12, 219);
            this.btnSave_Author.Name = "btnSave_Author";
            this.btnSave_Author.Size = new System.Drawing.Size(209, 44);
            this.btnSave_Author.TabIndex = 4;
            this.btnSave_Author.Text = "Save";
            this.btnSave_Author.UseVisualStyleBackColor = true;
            this.btnSave_Author.Click += new System.EventHandler(this.BtnSave_Author_Click);
            // 
            // txtSurname_Author
            // 
            this.txtSurname_Author.Location = new System.Drawing.Point(12, 148);
            this.txtSurname_Author.Name = "txtSurname_Author";
            this.txtSurname_Author.Size = new System.Drawing.Size(209, 20);
            this.txtSurname_Author.TabIndex = 3;
            this.txtSurname_Author.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtSurname_Author_KeyPress);
            // 
            // txtName_Author
            // 
            this.txtName_Author.Location = new System.Drawing.Point(12, 61);
            this.txtName_Author.Name = "txtName_Author";
            this.txtName_Author.Size = new System.Drawing.Size(209, 20);
            this.txtName_Author.TabIndex = 2;
            this.txtName_Author.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtName_Author_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Surname";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // AuthorsDataGrid
            // 
            this.AuthorsDataGrid.AllowUserToAddRows = false;
            this.AuthorsDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AuthorsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AuthorsDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.AuthorName,
            this.AuthorSuname});
            this.AuthorsDataGrid.Location = new System.Drawing.Point(304, 44);
            this.AuthorsDataGrid.Name = "AuthorsDataGrid";
            this.AuthorsDataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.AuthorsDataGrid.Size = new System.Drawing.Size(468, 376);
            this.AuthorsDataGrid.TabIndex = 1;
            this.AuthorsDataGrid.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.AuthorsDataGrid_RowHeaderMouseDoubleClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // AuthorName
            // 
            this.AuthorName.HeaderText = "Name";
            this.AuthorName.Name = "AuthorName";
            this.AuthorName.ReadOnly = true;
            // 
            // AuthorSuname
            // 
            this.AuthorSuname.HeaderText = "Surname";
            this.AuthorSuname.Name = "AuthorSuname";
            this.AuthorSuname.ReadOnly = true;
            // 
            // Authors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AuthorsDataGrid);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "Authors";
            this.Text = "Authors";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AuthorsDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnReset_Author;
        private System.Windows.Forms.Button btnDelete_Author;
        private System.Windows.Forms.Button btnSave_Author;
        private System.Windows.Forms.TextBox txtSurname_Author;
        private System.Windows.Forms.TextBox txtName_Author;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView AuthorsDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn AuthorName;
        private System.Windows.Forms.DataGridViewTextBoxColumn AuthorSuname;
    }
}
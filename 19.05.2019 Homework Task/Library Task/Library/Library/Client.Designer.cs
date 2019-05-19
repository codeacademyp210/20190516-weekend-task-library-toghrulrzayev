namespace Library
{
    partial class Clients
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
            this.txtPhone_Client = new System.Windows.Forms.TextBox();
            this.txtSurname_Client = new System.Windows.Forms.TextBox();
            this.btnReset_Client = new System.Windows.Forms.Button();
            this.btnDelete_Client = new System.Windows.Forms.Button();
            this.btnSave_Client = new System.Windows.Forms.Button();
            this.txtEmail_Client = new System.Windows.Forms.TextBox();
            this.txtName_Client = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ClientsDataGrid = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClientsDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtPhone_Client);
            this.panel1.Controls.Add(this.txtSurname_Client);
            this.panel1.Controls.Add(this.btnReset_Client);
            this.panel1.Controls.Add(this.btnDelete_Client);
            this.panel1.Controls.Add(this.btnSave_Client);
            this.panel1.Controls.Add(this.txtEmail_Client);
            this.panel1.Controls.Add(this.txtName_Client);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(226, 450);
            this.panel1.TabIndex = 1;
            // 
            // txtPhone_Client
            // 
            this.txtPhone_Client.Location = new System.Drawing.Point(12, 225);
            this.txtPhone_Client.Name = "txtPhone_Client";
            this.txtPhone_Client.Size = new System.Drawing.Size(206, 20);
            this.txtPhone_Client.TabIndex = 27;
            this.txtPhone_Client.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPhone_Client_KeyPress);
            // 
            // txtSurname_Client
            // 
            this.txtSurname_Client.Location = new System.Drawing.Point(12, 104);
            this.txtSurname_Client.Name = "txtSurname_Client";
            this.txtSurname_Client.Size = new System.Drawing.Size(206, 20);
            this.txtSurname_Client.TabIndex = 26;
            this.txtSurname_Client.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtSurname_Client_KeyPress);
            // 
            // btnReset_Client
            // 
            this.btnReset_Client.Location = new System.Drawing.Point(116, 337);
            this.btnReset_Client.Name = "btnReset_Client";
            this.btnReset_Client.Size = new System.Drawing.Size(102, 36);
            this.btnReset_Client.TabIndex = 25;
            this.btnReset_Client.Text = "Reset";
            this.btnReset_Client.UseVisualStyleBackColor = true;
            this.btnReset_Client.Click += new System.EventHandler(this.BtnReset_Client_Click);
            // 
            // btnDelete_Client
            // 
            this.btnDelete_Client.Location = new System.Drawing.Point(12, 337);
            this.btnDelete_Client.Name = "btnDelete_Client";
            this.btnDelete_Client.Size = new System.Drawing.Size(98, 36);
            this.btnDelete_Client.TabIndex = 24;
            this.btnDelete_Client.Text = "Delete";
            this.btnDelete_Client.UseVisualStyleBackColor = true;
            this.btnDelete_Client.Click += new System.EventHandler(this.BtnDelete_Client_Click);
            // 
            // btnSave_Client
            // 
            this.btnSave_Client.Location = new System.Drawing.Point(11, 269);
            this.btnSave_Client.Name = "btnSave_Client";
            this.btnSave_Client.Size = new System.Drawing.Size(206, 41);
            this.btnSave_Client.TabIndex = 23;
            this.btnSave_Client.Text = "Save";
            this.btnSave_Client.UseVisualStyleBackColor = true;
            this.btnSave_Client.Click += new System.EventHandler(this.BtnSave_Client_Click);
            // 
            // txtEmail_Client
            // 
            this.txtEmail_Client.Location = new System.Drawing.Point(12, 162);
            this.txtEmail_Client.Name = "txtEmail_Client";
            this.txtEmail_Client.Size = new System.Drawing.Size(206, 20);
            this.txtEmail_Client.TabIndex = 21;
            // 
            // txtName_Client
            // 
            this.txtName_Client.Location = new System.Drawing.Point(12, 48);
            this.txtName_Client.Name = "txtName_Client";
            this.txtName_Client.Size = new System.Drawing.Size(206, 20);
            this.txtName_Client.TabIndex = 18;
            this.txtName_Client.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtName_Client_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 18);
            this.label4.TabIndex = 16;
            this.label4.Text = "Phone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 18);
            this.label3.TabIndex = 15;
            this.label3.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 18);
            this.label2.TabIndex = 14;
            this.label2.Text = "Surname";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 18);
            this.label1.TabIndex = 13;
            this.label1.Text = "Name";
            // 
            // ClientsDataGrid
            // 
            this.ClientsDataGrid.AllowUserToAddRows = false;
            this.ClientsDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ClientsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClientsDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.ClientName,
            this.ClientSurname,
            this.ClientEmail,
            this.ClientPhone});
            this.ClientsDataGrid.Location = new System.Drawing.Point(248, 18);
            this.ClientsDataGrid.Name = "ClientsDataGrid";
            this.ClientsDataGrid.Size = new System.Drawing.Size(446, 420);
            this.ClientsDataGrid.TabIndex = 2;
            this.ClientsDataGrid.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.ClientsDataGrid_RowHeaderMouseDoubleClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // ClientName
            // 
            this.ClientName.HeaderText = "Name";
            this.ClientName.Name = "ClientName";
            this.ClientName.ReadOnly = true;
            // 
            // ClientSurname
            // 
            this.ClientSurname.HeaderText = "Surname";
            this.ClientSurname.Name = "ClientSurname";
            this.ClientSurname.ReadOnly = true;
            // 
            // ClientEmail
            // 
            this.ClientEmail.HeaderText = "Email";
            this.ClientEmail.Name = "ClientEmail";
            this.ClientEmail.ReadOnly = true;
            // 
            // ClientPhone
            // 
            this.ClientPhone.HeaderText = "Phone";
            this.ClientPhone.Name = "ClientPhone";
            this.ClientPhone.ReadOnly = true;
            // 
            // Clients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 450);
            this.Controls.Add(this.ClientsDataGrid);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "Clients";
            this.Text = "Clients";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClientsDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnReset_Client;
        private System.Windows.Forms.Button btnDelete_Client;
        private System.Windows.Forms.Button btnSave_Client;
        private System.Windows.Forms.TextBox txtEmail_Client;
        private System.Windows.Forms.TextBox txtName_Client;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPhone_Client;
        private System.Windows.Forms.TextBox txtSurname_Client;
        private System.Windows.Forms.DataGridView ClientsDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientSurname;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientPhone;
    }
}
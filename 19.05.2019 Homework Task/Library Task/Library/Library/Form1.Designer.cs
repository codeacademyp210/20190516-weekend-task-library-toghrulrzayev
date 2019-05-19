namespace Library
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.booksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.authorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtClientsSearch = new System.Windows.Forms.TextBox();
            this.btnSeach_Client = new System.Windows.Forms.Button();
            this.ClientDataGrid = new System.Windows.Forms.DataGridView();
            this.Clients__Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Clients_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Clients_Surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Clients_Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Clients_Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookDataGrid = new System.Windows.Forms.DataGridView();
            this.Id_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BooksName_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BooksAuthor_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BooksPrice_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.txtBookSearch = new System.Windows.Forms.TextBox();
            this.btnSearch_Books = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClientDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BookDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.booksToolStripMenuItem,
            this.authorsToolStripMenuItem,
            this.clientToolStripMenuItem,
            this.ordersToolStripMenuItem,
            this.categoriesToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // booksToolStripMenuItem
            // 
            this.booksToolStripMenuItem.Name = "booksToolStripMenuItem";
            this.booksToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.booksToolStripMenuItem.Text = "Books";
            this.booksToolStripMenuItem.Click += new System.EventHandler(this.BooksToolStripMenuItem_Click);
            // 
            // authorsToolStripMenuItem
            // 
            this.authorsToolStripMenuItem.Name = "authorsToolStripMenuItem";
            this.authorsToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.authorsToolStripMenuItem.Text = "Authors";
            this.authorsToolStripMenuItem.Click += new System.EventHandler(this.AuthorsToolStripMenuItem_Click);
            // 
            // clientToolStripMenuItem
            // 
            this.clientToolStripMenuItem.Name = "clientToolStripMenuItem";
            this.clientToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.clientToolStripMenuItem.Text = "Client";
            this.clientToolStripMenuItem.Click += new System.EventHandler(this.ClientToolStripMenuItem_Click);
            // 
            // ordersToolStripMenuItem
            // 
            this.ordersToolStripMenuItem.Name = "ordersToolStripMenuItem";
            this.ordersToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.ordersToolStripMenuItem.Text = "Orders";
            this.ordersToolStripMenuItem.Click += new System.EventHandler(this.OrdersToolStripMenuItem_Click);
            // 
            // categoriesToolStripMenuItem
            // 
            this.categoriesToolStripMenuItem.Name = "categoriesToolStripMenuItem";
            this.categoriesToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.categoriesToolStripMenuItem.Text = "Categories";
            this.categoriesToolStripMenuItem.Click += new System.EventHandler(this.CategoriesToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // txtClientsSearch
            // 
            this.txtClientsSearch.Location = new System.Drawing.Point(17, 52);
            this.txtClientsSearch.Name = "txtClientsSearch";
            this.txtClientsSearch.Size = new System.Drawing.Size(226, 20);
            this.txtClientsSearch.TabIndex = 1;
            // 
            // btnSeach_Client
            // 
            this.btnSeach_Client.Location = new System.Drawing.Point(244, 50);
            this.btnSeach_Client.Name = "btnSeach_Client";
            this.btnSeach_Client.Size = new System.Drawing.Size(75, 23);
            this.btnSeach_Client.TabIndex = 2;
            this.btnSeach_Client.Text = "Search";
            this.btnSeach_Client.UseVisualStyleBackColor = true;
            this.btnSeach_Client.Click += new System.EventHandler(this.BtnSeach_Client_Click);
            // 
            // ClientDataGrid
            // 
            this.ClientDataGrid.AllowUserToAddRows = false;
            this.ClientDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ClientDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClientDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Clients__Id,
            this.Clients_Name,
            this.Clients_Surname,
            this.Clients_Email,
            this.Clients_Phone});
            this.ClientDataGrid.Location = new System.Drawing.Point(12, 82);
            this.ClientDataGrid.Name = "ClientDataGrid";
            this.ClientDataGrid.Size = new System.Drawing.Size(327, 331);
            this.ClientDataGrid.TabIndex = 3;
            // 
            // Clients__Id
            // 
            this.Clients__Id.HeaderText = "Id";
            this.Clients__Id.Name = "Clients__Id";
            this.Clients__Id.ReadOnly = true;
            this.Clients__Id.Visible = false;
            // 
            // Clients_Name
            // 
            this.Clients_Name.HeaderText = "Name";
            this.Clients_Name.Name = "Clients_Name";
            this.Clients_Name.ReadOnly = true;
            // 
            // Clients_Surname
            // 
            this.Clients_Surname.HeaderText = "Surname";
            this.Clients_Surname.Name = "Clients_Surname";
            this.Clients_Surname.ReadOnly = true;
            // 
            // Clients_Email
            // 
            this.Clients_Email.HeaderText = "Email";
            this.Clients_Email.Name = "Clients_Email";
            this.Clients_Email.ReadOnly = true;
            // 
            // Clients_Phone
            // 
            this.Clients_Phone.HeaderText = "Phone";
            this.Clients_Phone.Name = "Clients_Phone";
            this.Clients_Phone.ReadOnly = true;
            // 
            // BookDataGrid
            // 
            this.BookDataGrid.AllowUserToAddRows = false;
            this.BookDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.BookDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BookDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_,
            this.BooksName_,
            this.BooksAuthor_,
            this.BooksPrice_});
            this.BookDataGrid.Location = new System.Drawing.Point(354, 71);
            this.BookDataGrid.Name = "BookDataGrid";
            this.BookDataGrid.Size = new System.Drawing.Size(446, 378);
            this.BookDataGrid.TabIndex = 4;
            // 
            // Id_
            // 
            this.Id_.HeaderText = "Id_";
            this.Id_.Name = "Id_";
            this.Id_.ReadOnly = true;
            this.Id_.Visible = false;
            // 
            // BooksName_
            // 
            this.BooksName_.HeaderText = "Name_";
            this.BooksName_.Name = "BooksName_";
            this.BooksName_.ReadOnly = true;
            // 
            // BooksAuthor_
            // 
            this.BooksAuthor_.HeaderText = "Author_";
            this.BooksAuthor_.Name = "BooksAuthor_";
            this.BooksAuthor_.ReadOnly = true;
            // 
            // BooksPrice_
            // 
            this.BooksPrice_.HeaderText = "Price_";
            this.BooksPrice_.Name = "BooksPrice_";
            this.BooksPrice_.ReadOnly = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 415);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(327, 34);
            this.button2.TabIndex = 5;
            this.button2.Text = "Order";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // txtBookSearch
            // 
            this.txtBookSearch.Location = new System.Drawing.Point(365, 42);
            this.txtBookSearch.Name = "txtBookSearch";
            this.txtBookSearch.Size = new System.Drawing.Size(333, 20);
            this.txtBookSearch.TabIndex = 6;
            // 
            // btnSearch_Books
            // 
            this.btnSearch_Books.Location = new System.Drawing.Point(715, 42);
            this.btnSearch_Books.Name = "btnSearch_Books";
            this.btnSearch_Books.Size = new System.Drawing.Size(75, 23);
            this.btnSearch_Books.TabIndex = 7;
            this.btnSearch_Books.Text = "Search";
            this.btnSearch_Books.UseVisualStyleBackColor = true;
            this.btnSearch_Books.Click += new System.EventHandler(this.BtnSearch_Books_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "Clients";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(365, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 23);
            this.label2.TabIndex = 9;
            this.label2.Text = "Books";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSearch_Books);
            this.Controls.Add(this.txtBookSearch);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.BookDataGrid);
            this.Controls.Add(this.ClientDataGrid);
            this.Controls.Add(this.btnSeach_Client);
            this.Controls.Add(this.txtClientsSearch);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClientDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BookDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem booksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem authorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriesToolStripMenuItem;
        private System.Windows.Forms.TextBox txtClientsSearch;
        private System.Windows.Forms.Button btnSeach_Client;
        private System.Windows.Forms.DataGridView ClientDataGrid;
        private System.Windows.Forms.DataGridView BookDataGrid;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtBookSearch;
        private System.Windows.Forms.Button btnSearch_Books;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clients__Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clients_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clients_Surname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clients_Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clients_Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_;
        private System.Windows.Forms.DataGridViewTextBoxColumn BooksName_;
        private System.Windows.Forms.DataGridViewTextBoxColumn BooksAuthor_;
        private System.Windows.Forms.DataGridViewTextBoxColumn BooksPrice_;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
    }
}


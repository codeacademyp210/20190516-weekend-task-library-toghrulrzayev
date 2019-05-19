using Library.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            GenerateClients();
            GenerateBooks();
        }

        private void BooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Books newBook = new Books();
            newBook.ShowDialog();
         
        }

        private void AuthorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Authors newAuthor = new Authors();
            newAuthor.ShowDialog();
          
        }

        private void ClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clients newClientss= new Clients();
            newClientss.ShowDialog();
            
        }

        private void OrdersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Orders newOrder = new Orders();
            newOrder.ShowDialog();
           
        }

        private void CategoriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Categories newCategory = new Categories();
            newCategory.ShowDialog();
           
        }

        private void GenerateClients()
        {
            ClientDataGrid.Rows.Clear();

            using (LibraryEntities db = new LibraryEntities())
            {
                List<Client> clients = db.Clients.ToList();

                foreach (var client in clients)
                {
                    ClientDataGrid.Rows.Add(client.Id,
                                             client.Name,
                                             client.Surname,
                                             client.Email,
                                             client.Phone);
                }
            }
        }

        private void GenerateBooks()
        {
            BookDataGrid.Rows.Clear();

            using (LibraryEntities db = new LibraryEntities())
            {
                List<Book> books = db.Books.ToList();
                List<Author> author = db.Authors.ToList();

                foreach (var book in books)
                {
                    BookDataGrid.Rows.Add(book.Id,
                                             book.Name,
                                             book.CategoryId,
                                             book.Price);
                }
              
                
            }
        }

        private void BtnSeach_Client_Click(object sender, EventArgs e)
        {
            string searchText = txtClientsSearch.Text.Trim().ToLower();
            using (LibraryEntities db = new LibraryEntities())
            {
                List<Client> clientList = db.Clients.Where(c =>
                  c.Name.ToLower().Contains(searchText) ||
                  c.Surname.ToLower().Contains(searchText)||
                  c.Email.ToLower().Contains(searchText)||
                  c.Phone.ToLower().Contains(searchText)).ToList();
               
            }
        }

        private void BtnSearch_Books_Click(object sender, EventArgs e)
        {
            string searchText = txtBookSearch.Text.Trim().ToLower();
            using (LibraryEntities db = new LibraryEntities())
            {
                List<Book> bookList = db.Books.Where(b =>
                  b.Name.ToLower().Contains(searchText)).ToList();

            }
        }
    }
}

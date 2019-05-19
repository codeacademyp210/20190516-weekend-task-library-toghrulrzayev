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
    public partial class Authors : Form
    {
        Author authorGlobal = new Author();
        public Authors()
        {
            InitializeComponent();
            GenerateAuthors();
        }

        private void GenerateAuthors()
        {
            AuthorsDataGrid.Rows.Clear();

            using (LibraryEntities db= new LibraryEntities())
            {
                List<Author> authors = db.Authors.ToList();

                foreach (var author in authors)
                {
                    AuthorsDataGrid.Rows.Add(author.Id,
                                             author.Name,
                                             author.Surname);
                }
            }
        }

        private void TxtName_Author_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Zehmet olmasa herf daxil edin:)");
            }
        }

        private void TxtSurname_Author_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Zehmet olmasa herf daxil edin:)");
            }
        }

        private void BtnSave_Author_Click(object sender, EventArgs e)
        {
            if (txtName_Author.Text == "" || txtSurname_Author.Text == "")
            {
                MessageBox.Show("Zehmet olmasa Xanalari bos buraxmayin!");
            }
            else if(btnDelete_Author.Enabled){
                if (!UpdateAuthor())
                {
                    MessageBox.Show("Tələbə yenilənmədi.");
                    return;
                }

                MessageBox.Show("Tələbə yeniləndi");
            }
            else
            {
                if (CreateAuthor())
                {
                    MessageBox.Show("Telebe Yaradilmadi!");
                    return;
                }
                else 
                {
                    GenerateAuthors();
                    MessageBox.Show("Telebe Yaradildi!");
                }
                
                    txtName_Author.Clear();
                    txtSurname_Author.Clear();
            }
           
        }

        private bool CreateAuthor()
        {

            int affectedRows = 0;
            using (LibraryEntities db = new LibraryEntities())
            {
                Models.Author newauthor = new Models.Author
                {
                    Name = txtName_Author.Text,
                    Surname = txtSurname_Author.Text
                };
                db.Authors.Add(newauthor);

                db.SaveChanges();
            }
            if(affectedRows>0){
                return true;
            }
            else
            {
                return false;
            }
        }
        private bool UpdateAuthor()
        {
            int affectedRows = 0;
            using (LibraryEntities db = new LibraryEntities())
            {

                Author newAut=db.Authors.Where(a => a.Id == authorGlobal.Id).FirstOrDefault();
                newAut.Name = txtName_Author.Text;
                newAut.Surname = txtSurname_Author.Text;
           
                db.SaveChanges();
            }
            if (affectedRows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
   
        private void AuthorsDataGrid_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int authorID = (int)AuthorsDataGrid.Rows[e.RowIndex].Cells[0].Value;

            using (LibraryEntities db =new LibraryEntities())
            {
                 authorGlobal = db.Authors.Where(a => a.Id == authorID).FirstOrDefault();
                if(authorGlobal != null)
                {
                    txtName_Author.Text =authorGlobal.Name;
                    txtSurname_Author.Text = authorGlobal.Surname;
                }
            }

            btnSave_Author.Text = "Update";
            btnDelete_Author.Enabled = true;
        }

        private void ResetAuthorForm()
        {
            txtName_Author.Clear();
            txtSurname_Author.Clear();

            btnSave_Author.Text = "Save";
            btnDelete_Author.Enabled = false;
        }

        private void BtnReset_Author_Click(object sender, EventArgs e)
        {
            ResetAuthorForm();
        }
        private bool DeleteAuthor()
        {
            int affectedRows = 0;
            using (LibraryEntities db = new LibraryEntities())
            {

                Author newStu = db.Authors.Where(s => s.Id == authorGlobal.Id).FirstOrDefault();
                db.Authors.Remove(newStu);
                affectedRows = db.SaveChanges();

            }
            if (affectedRows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void BtnDelete_Author_Click(object sender, EventArgs e)
        {
            var message = MessageBox.Show(authorGlobal.Name + " " + authorGlobal.Surname + " yazicisini silmək istəyirsinizmi?", "Yazici   Silmə", MessageBoxButtons.OKCancel);

            if (DialogResult.OK != message)
            {
                return;
            }

            if (!DeleteAuthor())
            {
                MessageBox.Show("Yazici Silinmədi", "Diqqət");
                return;
            }

            MessageBox.Show("Yazici Silindi");

            GenerateAuthors();
            ResetAuthorForm();
        }
    }
}

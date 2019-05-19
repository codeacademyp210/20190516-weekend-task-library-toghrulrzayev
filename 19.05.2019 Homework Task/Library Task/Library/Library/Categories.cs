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
    public partial class Categories : Form
    {
        Category globalCateg = new Category();
        public Categories()
        {
            InitializeComponent();
        }

        private void GenerateCategories()
        {
            CategoriesDataGrid.Rows.Clear();

            using (LibraryEntities db = new LibraryEntities())
            {
                List<Category> categories = db.Categories.ToList();

                foreach (var category in categories)
                {
                    CategoriesDataGrid.Rows.Add(category.Id,
                                             category.Name
                                             );
                }
            }
        }

        private void TxtNameCategori_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Zehmet olmasa herf daxil edin:)");
            }
        }

        private void BtnSaveCategori_Click(object sender, EventArgs e)
        {
            if (txtNameCategori.Text == "")
            {
                MessageBox.Show("Zehmet olmasa Xanalari bos buraxmayin!");
            }
            else if (btnDeleteCategori.Enabled)
            {
                if (!UpdateCategori())
                {
                    MessageBox.Show("Tələbə yenilənmədi.");
                    return;
                }

                MessageBox.Show("Tələbə yeniləndi");
            }
            else
            {
                if (CreateCategori())
                {
                    MessageBox.Show("Telebe Yaradilmadi!");
                    return;
                }
                else
                {
                    GenerateCategories();
                    MessageBox.Show("Telebe Yaradildi!");
                }

                txtNameCategori.Clear();
               
            }
        }

        private bool CreateCategori()
        {

            int affectedRows = 0;
            using (LibraryEntities db = new LibraryEntities())
            {
                Models.Category newcategori = new Models.Category
                {
                    Name = txtNameCategori.Text
                    
                };
                db.Categories.Add(newcategori);

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
        private bool UpdateCategori()
        {
            int affectedRows = 0;
            using (LibraryEntities db = new LibraryEntities())
            {

                Category newCat = db.Categories.Where(a => a.Id == globalCateg.Id).FirstOrDefault();
                newCat.Name = txtNameCategori.Text;
               

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
        private void CategoriesDataGrid_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int categID = (int)CategoriesDataGrid.Rows[e.RowIndex].Cells[0].Value;

            using (LibraryEntities db = new LibraryEntities())
            {
                globalCateg = db.Categories.Where(a => a.Id == categID).FirstOrDefault();
                if (globalCateg != null)
                {
                    txtNameCategori.Text = globalCateg.Name;
                   
                }
            }

            btnSaveCategori.Text = "Update";
            btnDeleteCategori.Enabled = true;
        }

        private void ResetCategoriForm()
        {
            txtNameCategori.Clear();
          

            btnSaveCategori.Text = "Save";
            btnDeleteCategori.Enabled = false;
        }
        private void BtnResetCategori_Click(object sender, EventArgs e)
        {
            ResetCategoriForm();
        }

        private bool DeleteCategori()
        {
            int affectedRows = 0;
            using (LibraryEntities db = new LibraryEntities())
            {

                Category newCat = db.Categories.Where(s => s.Id == globalCateg.Id).FirstOrDefault();
                db.Categories.Remove(newCat);
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

        private void BtnDeleteCategori_Click(object sender, EventArgs e)
        {
            var message = MessageBox.Show(globalCateg.Name + " " + " yazicisini silmək istəyirsinizmi?", "Yazici   Silmə", MessageBoxButtons.OKCancel);

            if (DialogResult.OK != message)
            {
                return;
            }

            if (!DeleteCategori())
            {
                MessageBox.Show("Yazici Silinmədi", "Diqqət");
                return;
            }

            MessageBox.Show("Yazici Silindi");

            GenerateCategories();
            ResetCategoriForm();
        }
    }
}

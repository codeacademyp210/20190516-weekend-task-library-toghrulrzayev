using Library.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class Clients : Form
    {

        Client globalClient = new Client();
        public Clients()
        {
            InitializeComponent();
            GenerateClients();
        }

        private void GenerateClients()
        {
            ClientsDataGrid.Rows.Clear();

            using (LibraryEntities db = new LibraryEntities())
            {
                List<Client> clients = db.Clients.ToList();

                foreach (var client in clients)
                {
                    ClientsDataGrid.Rows.Add(client.Id,
                                             client.Name,
                                             client.Surname,
                                             client.Email,
                                             client.Phone);
                }
            }
        }

        private void TxtName_Client_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Zehmet olmasa herf daxil edin:)");
            }
        }

        private void TxtSurname_Client_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Zehmet olmasa herf daxil edin:)");
            }
        }

        private void TxtPhone_Client_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Zehmet olmasa reqem daxil edin:)");
            }
        }
        private void BtnSave_Client_Click(object sender, EventArgs e)
        {
            string pattern = @"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*";
            if (txtName_Client.Text == "" || txtSurname_Client.Text == "" || txtEmail_Client.Text=="" || txtPhone_Client.Text=="")
            {
                MessageBox.Show("Zehmet olmasa Xanalari bos buraxmayin!");
            }
            else if (!Regex.IsMatch(txtEmail_Client.Text, pattern))
            {
                MessageBox.Show("Email-i Sehv daxil etdiniz.Meselen: ToghrulRr@code.edu.az bu sekilde daxil edin");
            }
            else if (btnDelete_Client.Enabled)
            {
                if (!UpdateClient())
                {
                    MessageBox.Show("Kliyent yenilənmədi.");
                    return;
                }

                MessageBox.Show("Kliyent yeniləndi");
            }
            else
            {
                if (CreateClient())
                {
                    MessageBox.Show("Kliyent Yaradilmadi!");
                    return;
                }
                else
                {
                    GenerateClients();
                    MessageBox.Show("Kliyent Yaradildi!");
                }

                txtName_Client.Clear();
                txtSurname_Client.Clear();
                txtEmail_Client.Clear();
                txtPhone_Client.Clear(); 
            }
        }

        private bool CreateClient()
        {

            int affectedRows = 0;
            using (LibraryEntities db = new LibraryEntities())
            {
                Models.Client newclient = new Models.Client
                {
                    Name = txtName_Client.Text,
                    Surname = txtSurname_Client.Text,
                    Email=txtEmail_Client.Text,
                    Phone = txtPhone_Client.Text
                };
                db.Clients.Add(newclient);

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
        private bool UpdateClient()
        {
            int affectedRows = 0;
            using (LibraryEntities db = new LibraryEntities())
            {

                Client newcly = db.Clients.Where(a => a.Id == globalClient.Id).FirstOrDefault();
                newcly.Name = txtName_Client.Text;
                newcly.Surname =txtSurname_Client.Text;
                newcly.Email = txtEmail_Client.Text;
                newcly.Phone = txtPhone_Client.Text;
 

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

        private void ClientsDataGrid_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int clientID = (int)ClientsDataGrid.Rows[e.RowIndex].Cells[0].Value;

            using (LibraryEntities db = new LibraryEntities())
            {
                globalClient = db.Clients.Where(a => a.Id == clientID).FirstOrDefault();
                if (globalClient != null)
                {
                    txtName_Client.Text = globalClient.Name;
                    txtSurname_Client.Text = globalClient.Surname;
                    txtEmail_Client.Text = globalClient.Email;
                    txtPhone_Client.Text = globalClient.Phone;
                }
            }

            btnSave_Client.Text = "Update";
            btnDelete_Client.Enabled = true;
        }
        private void ResetClientForm()
        {
            txtName_Client.Clear();
            txtSurname_Client.Clear();
            txtEmail_Client.Clear();
            txtPhone_Client.Clear();

            btnSave_Client.Text = "Save";
            btnDelete_Client.Enabled = false;
        }

        private void BtnReset_Client_Click(object sender, EventArgs e)
        {
            ResetClientForm();
        }

        private bool DeleteClient()
        {
            int affectedRows = 0;
            using (LibraryEntities db = new LibraryEntities())
            {

                Client newcly = db.Clients.Where(s => s.Id == globalClient.Id).FirstOrDefault();
                db.Clients.Remove(newcly);

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

        private void BtnDelete_Client_Click(object sender, EventArgs e)
        {
            var message = MessageBox.Show(globalClient.Name + " " + globalClient.Surname + " kliyentini silmək istəyirsinizmi?", "Kliyent   Silmə", MessageBoxButtons.OKCancel);

            if (DialogResult.OK != message)
            {
                return;
            }

            if (!DeleteClient())
            {
                MessageBox.Show("Kliyent Silinmədi", "Diqqət");
                return;
            }

            MessageBox.Show("Kliyent Silindi");

            GenerateClients();
            ResetClientForm();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp4
{
    public partial class EditAccountForm : Form
    {
        public int userId;
        public String username, password, role;

        private DbConnect conRef = new DbConnect();
        public Modules reference { get; set; }
        public EditAccountForm()
        {
            InitializeComponent();
        }

        private void EditAccountForm_Load(object sender, EventArgs e)
        {

        }

        private void txtEditUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void butCancel_Click(object sender, EventArgs e)
        {
            showPref();
        }
        private void showPref()
        {
            this.Hide();
            reference.readData();
            reference.Show();
            
        }
        private void clearFields()
        {

        }

        private void EditAccountForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            showPref();
        }

        private void comboEditRole_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtEditPass1.Text) || String.IsNullOrWhiteSpace(txtEditUserName.Text))
            {
                btnUpdate.Enabled = false;

            }
            else
            {
                btnUpdate.Enabled = true;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Boolean flag = false;
            if (comboEditRole.SelectedItem == null)
            {
                MessageBox.Show("please specify the role of the user");
                flag = true;

            }
            if (comboStatus.SelectedItem == null)
            {
                MessageBox.Show("please specify the status of the user");
                flag = true;

            }
        
            /*
            if (txtPass.Text != txtPass2.Text)
            {
                MessageBox.Show("Passwords do not match please try again");
            }
            */



            else if (flag == false)
            {
                Modules frm = new Modules();

                // MySqlConnection con = conRef.connectFunc();
                String query1 = ("UPDATE users_table SET username ='" + txtEditUserName.Text + "', password = '" + txtEditPass1.Text + "', roleuser ='" + comboEditRole.Text + "', statususer ='"+comboStatus.Text+"' " +
                    "WHERE idUser ='" +userId+"' ");
                MySqlConnection con = conRef.connectFunc();
                using (MySqlCommand cmd = new MySqlCommand(query1, con))
                {
                   
                    con.Open();
                    int result = cmd.ExecuteNonQuery();
                    //checking for errors
                    if (result < 0)
                    {
                        Console.WriteLine("Error inserting data into users_table!");
                    }
                    else
                    {
                        MessageBox.Show("succesfully updated");

                    }
                    con.Close();
                    reference.readData();
                    showPref();
                }

                //Form();
            }
            else
            {
                MessageBox.Show(" error");
            }



        }
    }
}

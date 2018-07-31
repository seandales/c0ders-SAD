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
    public partial class AddStaffForm : Form
    {
        public Staff_Manag_Form reference {get; set;}
        DbConnect conRef = new DbConnect();
        Staff_Manag_Form frmObject = new Staff_Manag_Form();

        public AddStaffForm()
        {
            InitializeComponent();
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy-mm-dd";
            butAdd.Enabled = false;
        }
        

        private void AddStaffForm_Load(object sender, EventArgs e)
        {
            comboxGend.SelectedItem = null;
            comboxGend.SelectedText = "--select--";
            comboCivil.SelectedItem = null;
            comboCivil.SelectedText = "--select--";
            comboxStatus.SelectedItem = null;
            comboxStatus.SelectedText = "--select--";
        }

        private void AddStaffForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            reference.Show();
        }


        //DbConnect con = new DbConnect();

        private void butAdd_Click(object sender, EventArgs e)
        {

            Boolean flag = false;
            foreach (Control control in groupBox1.Controls)
            {
                
                string controlType = control.GetType().ToString();
                if (controlType == "System.Windows.Forms.TextBox")
                {
                    TextBox txtBox = (TextBox)control;

                    if (string.IsNullOrEmpty(txtBox.Text))
                    {
                        MessageBox.Show(txtBox.Name + " Can not be empty");
                        flag = true;
                    }
                }

                if (controlType == "System.Window.Form.DateTimePicker")
                {
                    TextBox txtBox = (TextBox)control;
                    if (string.IsNullOrEmpty(txtBox.Text))
                    {
                        MessageBox.Show(txtBox.Name + " Can not be empty");
                        flag = true;
                    }
                }

                if (controlType == "System.Window.Form.ComboBox")
                {
                    TextBox txtBox = (TextBox)control;
                    if (string.IsNullOrEmpty(txtBox.Text))
                    {
                        MessageBox.Show(txtBox.Name + " Can not be empty");
                        flag = true;
                        
                    }
                }
            }
            if(comboxGend.SelectedItem == null)
            {
                MessageBox.Show("please specify the gender of staff member");
                flag = true;

            }
            else if (comboCivil.SelectedItem == null)
            {
                MessageBox.Show("please specify Civil status of staff member ");
                flag = true;

            }
            else if (comboxStatus.SelectedItem == null)
            {
                MessageBox.Show("please specify Status of selected member");
                flag = true;

            }
            

            else if (flag==false)
                {

                string strQuery = "INSERT INTO staff(first_name, middle_name, last_name, birthdate, gender, address, nationality, civil_status, email, religion, status, age) " +
                "VALUES (@firstName, @middleName, @lastName, @birthDate, @gender, @address, @nationality, @civilStatus, @email, @religion, @status, @age)";
                MySqlConnection con = conRef.connectFunc();
                MySqlCommand cmd = new MySqlCommand(strQuery, con);
                cmd.Parameters.AddWithValue("@firstName", txtFn.Text);
                cmd.Parameters.AddWithValue("@middleName", txtMn.Text);
                cmd.Parameters.AddWithValue("@lastName", txtLn.Text);
                cmd.Parameters.AddWithValue("@birthDate", dateTimePicker1.Value.Date);
                cmd.Parameters.AddWithValue("@gender", comboxGend.Text);
                cmd.Parameters.AddWithValue("@address", txtAddress.Text);
                cmd.Parameters.AddWithValue("@nationality", txtNationality.Text);
                cmd.Parameters.AddWithValue("@civilStatus", comboCivil.Text);
                cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@religion", txtReligion.Text);
                cmd.Parameters.AddWithValue("@status", comboxStatus.Text);
                cmd.Parameters.AddWithValue("@age", txtAge.Text);
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("successfully inserted");
                reference.readData();
                showPrevForm();
                }
            else
            {
                MessageBox.Show(" error");
            }





            }
        



        private void showPrevForm()
        {
            this.Hide();
            reference.Show();
        }

        private void AddStaffForm_Shown(object sender, EventArgs e)
        {
            
        }

        private void groupBox1_TextChanged(object sender, EventArgs e)
        {

        }

    
       
        private void Textbox_TextChanged(object sender, EventArgs e)
        {
            
            
            if (String.IsNullOrWhiteSpace(txtFn.Text) || String.IsNullOrWhiteSpace(txtLn.Text) || String.IsNullOrWhiteSpace(txtMn.Text) ||
                String.IsNullOrWhiteSpace(txtMn.Text) || String.IsNullOrWhiteSpace(txtNationality.Text) ||
                String.IsNullOrWhiteSpace(txtAddress.Text) || String.IsNullOrWhiteSpace(txtEmail.Text) || 
                String.IsNullOrWhiteSpace(txtReligion.Text) || String.IsNullOrWhiteSpace(txtMn.Text))
            {
                butAdd.Enabled = false;

            }
           
     
           
            else {
                butAdd.Enabled = true;
            }
            
        }
        private void EnableButton()
        {
            //butAdd.Enabled = !Controls.OfType<TextBox>().Any(x => string.IsNullOrEmpty(x.Text));
        }

        private void comboxGend_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttUpdate_Click(object sender, EventArgs e)
        {
            MySqlConnection con = conRef.connectFunc();
            String query = ("UPDATE staff SET first_name='"+txtFn.Text+"', last_name='"+txtLn.Text+"', middle_name='"+txtMn.Text+"',birthdate= '"+dateTimePicker1.Text+"', gender='"+comboCivil.Text+"', age='" + txtAge.Text + "', nationality='" + txtNationality.Text + "', civil_status='" + comboCivil.Text + "', address='" + txtAddress.Text + "', email='" + txtEmail.Text + "', religion='" + txtReligion.Text + "', status='" + comboxStatus.Text + "'");
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Edit was successful");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}

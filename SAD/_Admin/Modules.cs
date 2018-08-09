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
    public partial class Modules : Form
    {
        //public Staff_Manag_Form reference { get; set; }
        DbConnect conRef = new DbConnect();
        //Staff_Manag_Form frmObject = new Staff_Manag_Form();
        public Login reference { get; set; }
        private string loginName;
        //
        //-------->Form Initialization<--------
        //
        public Modules()
        {
            InitializeComponent();
        }
        public Modules(String role)
        {
            InitializeComponent();
            loginName = role;
            btnAdd.Enabled = false;
            editButton.Enabled = true;
        }
        private void Modules_Load(object sender, EventArgs e)
        {
            label1.Text = "Welcome back, " + loginName;

            //Sets Proper Form Size
            this.Size = new Size(1200, 675);

            //Sets All Panels to Fill
            homePanel.Dock = DockStyle.Fill;
            staffsPanel.Dock = DockStyle.Fill;
            accountsPanel.Dock = DockStyle.Fill;

            //Hides All Other Panels
            staffsPanel.Visible = false;
            accountsPanel.Visible = false;
            readData();
        }
        //
        //-------->Navigation Buttons<--------
        //
        private void homeButton_Click(object sender, EventArgs e)
        {
            //Switches Button BackColors
            homeButton.BackColor = Color.FromArgb(57, 213, 255);
            staffsButton.BackColor = Color.Transparent;
            accountsButton.BackColor = Color.Transparent;

            //Switches Panel Visibility
            homePanel.Visible = true;
            staffsPanel.Visible = false;
            accountsPanel.Visible = false;

            //Changes Label
            navigationLabel.Text = "Home";
        }
        private void staffsButton_Click(object sender, EventArgs e)
        {
            //Switches Button BackColors
            homeButton.BackColor = Color.Transparent;
            staffsButton.BackColor = Color.FromArgb(57, 213, 255);
            accountsButton.BackColor = Color.Transparent;

            //Switches Panel Visibility
            staffsPanel.Visible = true;
            homePanel.Visible = false;
            accountsPanel.Visible = false;

            //Changes Label
            navigationLabel.Text = "Staffs";
        }
        private void accountsButton_Click(object sender, EventArgs e)
        {
            //Switches Button BackColors
            homeButton.BackColor = Color.Transparent;
            staffsButton.BackColor = Color.Transparent;
            accountsButton.BackColor = Color.FromArgb(57, 213, 255);

            //Switches Panel Visibility
            accountsPanel.Visible = true;
            homePanel.Visible = false;
            staffsPanel.Visible = false;

            //Changes Label
            navigationLabel.Text = "Accounts";
        }
        //
        //-------->Exit Buttons<--------
        //
        private void signOutButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Modules_FormClosing(object sender, FormClosingEventArgs e)
        {
            reference.Show();
        }

        private void btnAdd1_Click(object sender, EventArgs e)
        {
            /*
            string strQuery = "INSERT INTO users(user_name, password, role) " +
                "VALUES (@user_name, @password, @role)";
            MySqlConnection con = conRef.connectFunc();
            MySqlCommand cmd = new MySqlCommand(strQuery, con);
            cmd.Parameters.AddWithValue("@user_name", txtfn1.Text);
            cmd.Parameters.AddWithValue("@password", txtpass1.Text);
            cmd.Parameters.AddWithValue("@role", combRole.Text);
            
            con.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("successfully inserted");
            readData();
            //showPrevForm();
            */
            
        }
        DbConnect connect = new DbConnect();
        MySqlDataAdapter da;
        DataTable dt;
        public void readData()
        {
            MySqlConnection con = connect.connectFunc();
            String query = "SELECT * FROM users_table";
            dt = new DataTable();
            da = new MySqlDataAdapter(query, con);
            da.Fill(dt);
            accountListGridView.DataSource = dt;
            accountListGridView.Columns[0].Visible = false;
            //dt.Rows[0].Vi
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Textbox_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtPass.Text) || String.IsNullOrWhiteSpace(txtPass2.Text) || String.IsNullOrWhiteSpace(txtUser.Text)) { 
                btnAdd.Enabled = false;

            }
            
            if (txtPass.Text != txtPass2.Text)
            {
                btnAdd.Enabled = false;
            }
            

            else
            {
                btnAdd.Enabled = true;
            }
        }

        private void topPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtpass_TextChanged(object sender, EventArgs e)
        {

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            clear();
        }
        public void clear()
        {
            txtPass.Text = ("");
            txtPass2.Text = ("");
            txtUser.Text = ("");
            comboRoleAccounts.SelectedIndex = comboRoleAccounts.Items.IndexOf(0);
        }

   

        private void accountsPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Boolean flag = false;
            if (comboRoleAccounts.SelectedItem == null  || comboRoleAccounts.SelectedIndex == 0)
            {
                MessageBox.Show("please specify the role of the user");
                flag = true;

            }
            if(txtPass.Text != txtPass2.Text)
            {
                MessageBox.Show("Passwords do not match please try again");
            }
           


            else if (flag == false)
            {
                int number = 1;
                String query1 = "INSERT INTO users_table (username,password,roleuser, statususer) VALUES (@username, @password, @roleuser, statususer)";
                MySqlConnection con = conRef.connectFunc();
                 using (MySqlCommand cmd = new MySqlCommand(query1, con))
                 {
                    cmd.Parameters.AddWithValue("@username", txtUser.Text);
                    cmd.Parameters.AddWithValue("@password", txtPass.Text);
                    cmd.Parameters.AddWithValue(@"roleuser", comboRoleAccounts.Text);
                    cmd.Parameters.AddWithValue("@statususer", number);
                    
                    con.Open();
                    int result = cmd.ExecuteNonQuery();
                    //checking for errors
                    if (result < 0)
                    {
                        Console.WriteLine("Error inserting data into users_table!");
                    }
                    else
                    {
                        MessageBox.Show("succesfully inserted");

                    }
                    con.Close();
                    readData();
                }

                //Form();
            }
            else
            {
                MessageBox.Show(" error");
            }





        }

        private void clearButton_Click_1(object sender, EventArgs e)
        {
            clear();
        }

        private void topPanel_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void accountListGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        int id;
        public String username1, password1, role1;

        private void comboRoleAccounts_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void editButton_Click_2(object sender, EventArgs e)
        {

            EditAccountForm f = new EditAccountForm();
            for (int i = 0; i < accountListGridView.SelectedRows.Count; i++)
            {
                f.userId = Convert.ToInt32(accountListGridView.SelectedRows[i].Cells[0].Value.ToString());
                f.textBox1.Text = (accountListGridView.SelectedRows[i].Cells[0].Value.ToString());
                f.txtEditUserName.Text = accountListGridView.SelectedRows[i].Cells[1].Value.ToString();
                f.txtEditPass1.Text = accountListGridView.SelectedRows[i].Cells[2].Value.ToString();
                f.comboEditRole.Text = accountListGridView.SelectedRows[i].Cells[3].Value.ToString();
                //f.dateTimePicker1.Text = accountListGridView.SelectedRows[i].Cells[4].Value.ToString();
                f.comboStatus.Text = accountListGridView.SelectedRows[i].Cells[5].Value.ToString();
                


            }
            this.Hide();
            //ddStaffForm addForm = new AddStaffForm();
            f.reference = this;
            //addForm.butAdd.Enabled = false;
           // addForm.butAdd.Enabled = true;
            f.Show();
        }

        private void accountListGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //editButton.Enabled = true;
            
            id = Convert.ToInt32(accountListGridView.Rows[e.RowIndex].Cells["idUser"].Value.ToString());
            MySqlConnection con = connect.connectFunc();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM users_table WHERE idUser=" + id + "";
            con.Open();
            cmd.ExecuteNonQuery();
            dt = new DataTable();
            da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            //String username, password, role;
            foreach (DataRow dr in dt.Rows)
            {
                username1 = dr["firstname"].ToString();
                password1 = dr["password"].ToString();
                role1 = dr["role"].ToString();
        
            }
            
            
        }


    }
}


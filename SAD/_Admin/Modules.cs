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
            editButton.Enabled = false;
            btnStaffAdd.Enabled = false;
            btnStaffEdit.Enabled = false;
            accountListGridView.ClearSelection();
            staffListGridView.ClearSelection();
        }
        private void Modules_Load(object sender, EventArgs e)
        {
            label1.Text = "Welcome back, " + loginName;

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
            accountListGridView.ClearSelection();
            staffListGridView.ClearSelection();
            readData();
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
            editButton.Enabled = false;
            btnAdd.Enabled = false;
            accountListGridView.ClearSelection();
            staffListGridView.ClearSelection();
            readData();
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
        MySqlDataAdapter da, da2;
        DataTable dt, dt2;
        
        public void readData()
        {
            MySqlConnection con = connect.connectFunc();
            String query = "SELECT * FROM users_table";
            String query2 = "SELECT * FROM staff_table"; 
            dt = new DataTable();
            dt2 = new DataTable();

            da = new MySqlDataAdapter(query, con);
            da2 = new MySqlDataAdapter(query2, con);
            da.Fill(dt);
            
            BindingSource bSource = new BindingSource();
            bSource.DataSource = dt;
            

            da2.Fill(dt2);
            accountListGridView.DataSource = bSource;
            staffListGridView.DataSource = dt2;
            staffListGridView.Columns[0].Visible = false;
            accountListGridView.Columns[0].Visible = false;
            //dt.Rows[0].Vi
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Textbox_TextChanged(object sender, EventArgs e)
        {
            editButton.Enabled = false;
            if (String.IsNullOrWhiteSpace(txtPass.Text) || String.IsNullOrWhiteSpace(txtPass2.Text) || String.IsNullOrWhiteSpace(txtUser.Text)) { 
                btnAdd.Enabled = false;
                
            }
            
            else if (txtPass.Text != txtPass2.Text)
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
            clearAccountFields();
        }
        public void clearAccountFields()
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
                String query1 = "INSERT INTO users_table (username,password,roleuser, statususer) VALUES (@username, @password, @roleuser, @statususer)";
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
                    clearAccountFields();
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
            clearAccountFields();
        }

        private void topPanel_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void accountListGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            editButton.Enabled = true;
        }
        int id;
        public String username1, password1, role1;

        private void comboRoleAccounts_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        private void staffsPanel_Paint(object sender, PaintEventArgs e)
        {

        }

       
        private void TextBox_TextChanged2(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtFn.Text) || String.IsNullOrWhiteSpace(txtMn.Text) || String.IsNullOrWhiteSpace(txtLn.Text))
            { 
                btnStaffAdd.Enabled = false;

            }
            
            /*
            if (txtPass.Text != txtPass2.Text)
            {
                btnStaffAdd.Enabled = false;
            }
            */
            

            else
            {
                btnStaffAdd.Enabled = true;
            }
        }

        private void btnStaffAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnStaffAdd_Click_1(object sender, EventArgs e)
        {
            int statusNumber = 1;
            Boolean flag = false;
            Boolean flag2 = false;
            if (comboRoleStaffs.Text == null || comboRoleAccounts.SelectedIndex == 0)
            {
                MessageBox.Show("please specify the role of the staff memeber");
                flag = true;

            }
            if (comboCivilStatus.Text == null || comboCivilStatus.SelectedIndex == 0)
            {
                MessageBox.Show("Please specify the civilstatus of the user");
                flag = true;
            }
            if (comboGender.Text == null || comboGender.SelectedIndex == 0)
            {
                MessageBox.Show("Please specify the civilstatus of the user");
                flag = true;
            }
            if(comboRoleStaffs.Text == "Supervisor")
            {
                flag2 = true;
                MessageBox.Show("Pfda"  +flag2);

            }
            //Inserts to staff_table then to user_table
            if (flag == false && flag2 == true)
            {
                
                String query1 = ("INSERT INTO staff_table (firstname,middlename,lastname, birthdate, gender, civilstatus, staffstatus, staffrole) " +
                    "VALUES (@firstname, @middlename, @lastname, @birthdate, @gender, @civilstatus, @staffstatus, @staffrole)");
                //String query2 = "INSERT INTO users_table (username,password,roleuser, statususer) VALUES (@username, @password, @roleuser, statususer)";
                long jarrod;
                MySqlConnection con = conRef.connectFunc();
                using (MySqlCommand cmd = new MySqlCommand(query1, con))
                {
                    cmd.Parameters.AddWithValue("@firstname", txtFn.Text);
                    cmd.Parameters.AddWithValue("@middlename", txtMn.Text);
                    cmd.Parameters.AddWithValue("@lastname", txtLn.Text);
                    cmd.Parameters.AddWithValue("@birthdate", dateTimeBirthdate.Value.Date);
                    cmd.Parameters.AddWithValue("@gender", comboGender.Text);
                    cmd.Parameters.AddWithValue("@civilstatus", comboCivilStatus.Text);
                    cmd.Parameters.AddWithValue("@staffstatus", statusNumber);
                    cmd.Parameters.AddWithValue("@staffrole", comboRoleStaffs.Text);
                    // object identity = Convert.ToInt32(cmd.ExecuteScalar());
                    // object identity = Convert.ToInt32(cmd.ExecuteScalar());

                    //MessageBox.Show(identity.ToString());
                    /*
                    cmd.Parameters.AddWithValue("@birthdate", number);
                    cmd.Parameters.AddWithValue("@birthdate", number);
                    cmd.Parameters.AddWithValue("@birthdate", number);
                    */




                    con.Open();
                    cmd.ExecuteNonQuery();
                    jarrod = cmd.LastInsertedId;
                    //settingId(jarrod);
                    MessageBox.Show(jarrod.ToString());
                    //int insertedID = Convert.ToInt32(cmd.ExecuteScalar());

                    if (jarrod < 0)
                    {
                        Console.WriteLine("Error inserting data into staff_table!");
                        con.Close();
                    }
                    else
                    {
                        MessageBox.Show("succesfully inserted into staff table");
                        con.Close();
                    }
                }
                //Inserting into accounts table
                
                String query2  = "INSERT INTO users_table (username,password,roleuser, idStaff, statususer) VALUES (@username, @password, @roleuser, @idStaff, @statususer)";
                using (MySqlCommand cmd = new MySqlCommand(query2, con))
                {
                    cmd.Parameters.AddWithValue("@username", "works");
                    cmd.Parameters.AddWithValue("@password", "root");
                    cmd.Parameters.AddWithValue("@roleuser", comboRoleStaffs.Text);
                    cmd.Parameters.AddWithValue("@idStaff", jarrod);
                    cmd.Parameters.AddWithValue("@statususer", statusNumber);
                
                    // object identity = Convert.ToInt32(cmd.ExecuteScalar());
                    // object identity = Convert.ToInt32(cmd.ExecuteScalar());

                    //MessageBox.Show(identity.ToString());
                    /*
                    cmd.Parameters.AddWithValue("@birthdate", number);
                    cmd.Parameters.AddWithValue("@birthdate", number);
                    cmd.Parameters.AddWithValue("@birthdate", number);
                    */




                    con.Open();
                    int result = cmd.ExecuteNonQuery();
                    // long jarrod = cmd.LastInsertedId;
                   // MessageBox.Show(jarrod.ToString());
                    //int insertedID = Convert.ToInt32(cmd.ExecuteScalar());

                    if (result  < 0)
                    {
                        Console.WriteLine("Error inserting data into user_table!");
                    }
                    else
                    {
                        MessageBox.Show("succesfully inserted into user_table");

                    }
                    //MessageBox.Show(gettingId().ToString());
                    con.Close();
                }

                /*


                using (MySqlCommand cmd2 = new MySqlCommand(query2, con))
                {
                    cmd2.Parameters.AddWithValue("@username", txtUser.Text);
                    cmd2.Parameters.AddWithValue("@password", txtPass.Text);
                    cmd2.Parameters.AddWithValue(@"roleuser", comboRoleAccounts.Text);
                    cmd2.Parameters.AddWithValue("@statususer", number);

                    con.Open();
                    int result2 = cmd2.ExecuteNonQuery();
                    //checking for errors
                    if (result2 < 0)
                    {
                        Console.WriteLine("Error inserting data into users_table!");
                    }
                    else
                    {
                        MessageBox.Show("succesfully inserted");

                    }
                    con.Close();
                    clearStaffFields();
                    readData();
                    MessageBox.Show(" into staff table" + flag2);

                }
                */




                /*
                if (txtPass.Text != txtPass2.Text)
                {
                    MessageBox.Show("Passwords do not match please try again");
                }
                if (txtPass.Text != txtPass2.Text)
                {
                    MessageBox.Show("Passwords do not match please try again");
                }
                */

            }
            else if (flag == false)
            {
                int number = 1;
                String query1 = "INSERT INTO staff_table (firstname,middlename,lastname, birthdate, gender, civilstatus, staffstatus, staffrole) " +
                    "VALUES (@firstname, @middlename, @lastname, @birthdate, @gender, @civilstatus, @staffstatus, @staffrole)";
                MySqlConnection con = conRef.connectFunc();
                using (MySqlCommand cmd = new MySqlCommand(query1, con))
                {
                    cmd.Parameters.AddWithValue("@firstname", txtFn.Text);
                    cmd.Parameters.AddWithValue("@middlename", txtMn.Text);
                    cmd.Parameters.AddWithValue(@"lastname", txtLn.Text);
                    cmd.Parameters.AddWithValue("@birthdate", dateTimeBirthdate.Value.Date);
                    cmd.Parameters.AddWithValue("@gender", comboGender.Text);
                    cmd.Parameters.AddWithValue("@civilstatus", comboCivilStatus.Text);
                    cmd.Parameters.AddWithValue("@staffstatus", number);
                    cmd.Parameters.AddWithValue("@staffrole", comboRoleStaffs.Text);
                    /*
                    cmd.Parameters.AddWithValue("@birthdate", number);
                    cmd.Parameters.AddWithValue("@birthdate", number);
                    cmd.Parameters.AddWithValue("@birthdate", number);
                    */




                    con.Open();
                    int result = cmd.ExecuteNonQuery();
                    //checking for errors
                    if (result < 0)
                    {
                        Console.WriteLine("Error inserting data into staff_table!");
                    }
                    else
                    {
                        MessageBox.Show("succesfully inserted into staff table");

                    }
                    con.Close();
                    clearStaffFields();
                    readData();
                    MessageBox.Show(" into staff table" + flag2);


                }




                //Form();
            }
            else
            {
                MessageBox.Show(" error");

            }
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
            /*
            accountListGridView.ClearSelection();
            staffListGridView.ClearSelection();
            */
            this.Hide();
            //ddStaffForm addForm = new AddStaffForm();
            f.reference = this;
            //addForm.butAdd.Enabled = false;
           // addForm.butAdd.Enabled = true;
            f.Show();
        }

        private void comboGender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void addPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void accountListGridView_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            editButton.Enabled = true;
        }

        private void accountListGridView_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            //editButton.Enabled = false;
        }

        private void addPanel_Enter(object sender, EventArgs e)
        {
            disableAccountEditButton();
            accountListGridView.ClearSelection();
            staffListGridView.ClearSelection();
        }

        private void accountsPanel_Enter(object sender, EventArgs e)
        {
            disableAccountEditButton();
        }

        private void addPanel_Click(object sender, EventArgs e)
        {
            disableAccountEditButton();
        }
        public void disableAccountEditButton()
        {
            editButton.Enabled = false;

        }

        private void comboRoleStaffs_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void civilStatusLabel_Click(object sender, EventArgs e)
        {

        }

        private void staffListGridView_Enter(object sender, EventArgs e)
        {
           // btnStaffEdit.Enabled = true;
        }

        private void panel2_Enter(object sender, EventArgs e)
        {
            btnStaffEdit.Enabled = false;
            accountListGridView.ClearSelection();
            staffListGridView.ClearSelection();

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void staffListGridView_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            btnStaffEdit.Enabled = true;

        }

        private void editButton_Click(object sender, EventArgs e)
        {
            EditAccountForm f = new EditAccountForm();
            for (int i = 0; i < staffListGridView.SelectedRows.Count; i++)
            {
                f.userId = Convert.ToInt32(accountListGridView.SelectedRows[i].Cells[0].Value.ToString());
                f.textBox1.Text = (accountListGridView.SelectedRows[i].Cells[0].Value.ToString());
                f.txtEditUserName.Text = (accountListGridView.SelectedRows[i].Cells[1].Value.ToString());
                f.txtEditPass1.Text = accountListGridView.SelectedRows[i].Cells[2].Value.ToString();
                f.comboEditRole.Text = accountListGridView.SelectedRows[i].Cells[3].Value.ToString();
                f.comboStatus.Text = accountListGridView.SelectedRows[i].Cells[5].Value.ToString();

                //f.dateTimePickerBirthdate.Text = accountListGridView.SelectedRows[i].Cells[3].Value.ToString();
                //f.dateTimePicker1.Text = accountListGridView.SelectedRows[i].Cells[4].Value.ToString();
                //f.comboStatus.Text = accountListGridView.SelectedRows[i].Cells[5].Value.ToString();



            }
            
            this.Hide();
            //ddStaffForm addForm = new AddStaffForm();
            f.reference = this;
            //addForm.butAdd.Enabled = false;
            // addForm.butAdd.Enabled = true;
            f.Show();
        }

        private void dateTimeBirthdate_ValueChanged(object sender, EventArgs e)
        {

        }
        DataTable dtSearch = new DataTable();

        MySqlDataAdapter ad;
        private void searchAccounts_TextChanged(object sender, EventArgs e)
        {
            using (MySqlConnection conn = conRef.connectFunc())
            {
                conn.Open();
                string query = ("SELECT * FROM users_table WHERE username LIKE '" +txtSearchAccounts.Text + "%'");
                ad = new MySqlDataAdapter(query, conn);
                dt = new DataTable();
                ad.Fill(dt);
                accountListGridView.DataSource = dt;
            }
            //DataView DV = new DataView(dt);
            //DV.RowFilter = string.Format("username LIKE '%[0]%'", txtSearchAccounts.Text);
            //DV.RowFilter = string.Format("username LIKE '%[0]%'", txtSearchAccounts.Text);
            //accountListGridView.DataSource = DV;

        }

        MySqlDataAdapter ad2;
        DataTable newdt2;
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            using (MySqlConnection conn = conRef.connectFunc())
            {
                conn.Open();
                string query = ("SELECT * FROM staff_table WHERE firstname LIKE '" + txtStaffSearch
                    
                    
                    
                    
                    
                    
                    
                    .Text + "%'");
                ad2 = new MySqlDataAdapter(query, conn);
                newdt2 = new DataTable();
                ad2.Fill(newdt2);
                staffListGridView.DataSource = newdt2;
            }
        }

        private void btnStaffEdit_Click(object sender, EventArgs e)
        {

            EditStaffForm f = new EditStaffForm();
            for (int i = 0; i < staffListGridView.SelectedRows.Count; i++)
            {
                f.staffId = Convert.ToInt32(staffListGridView.SelectedRows[i].Cells[0].Value.ToString());
                f.textBox1.Text = (staffListGridView.SelectedRows[i].Cells[0].Value.ToString());
                f.txtEditStaffFn.Text = (staffListGridView.SelectedRows[i].Cells[1].Value.ToString());
                f.txtEditStaffMn.Text = staffListGridView.SelectedRows[i].Cells[2].Value.ToString();
                f.txtEditStaffLn.Text = staffListGridView.SelectedRows[i].Cells[3].Value.ToString();
                f.dateTimePickerBirthdate.Text = staffListGridView.SelectedRows[i].Cells[4].Value.ToString();
                f.comboBoxGender.Text = (staffListGridView.SelectedRows[i].Cells[5].Value.ToString());
                f.comboBoxCivilStatus.Text = staffListGridView.SelectedRows[i].Cells[7].Value.ToString();
                f.comboBoxStaffStatus.Text = staffListGridView.SelectedRows[i].Cells[8].Value.ToString();
                f.comboBoxRole.Text = staffListGridView.SelectedRows[i].Cells[9].Value.ToString();
                //f.dateTimePickerBirthdate.Text = accountListGridView.SelectedRows[i].Cells[3].Value.ToString();
                //f.dateTimePicker1.Text = accountListGridView.SelectedRows[i].Cells[4].Value.ToString();
                //f.comboStatus.Text = accountListGridView.SelectedRows[i].Cells[5].Value.ToString();



            }
            this.Hide();
            //ddStaffForm addForm = new AddStaffForm();
            f.reference = this;
            //addForm.butAdd.Enabled = false;
            // addForm.butAdd.Enabled = true;
            f.Show();
        }

        private void staffListGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void accountListGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //editButton.Enabled = true;
            /*
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
            */
            
            
        }
        public void clearStaffFields()
        {
            txtFn.Text = "";
            txtMn.Text = "";
            txtLn.Text = "";
            dateTimeBirthdate.ResetText();
            comboGender.SelectedIndex = comboGender.Items.IndexOf(0);
            //comboRoleAccounts.SelectedIndex = comboRoleAccounts.Items.IndexOf(0);
            comboCivilStatus.SelectedIndex = comboCivilStatus.Items.IndexOf(0);
            comboRoleStaffs.SelectedIndex = comboCivilStatus.Items.IndexOf(0);


        }
        //user defined methods
        void AutoCompleteText()
        {
            //txtStaffSearch.AutoCompleteCustomSource = AutoCompleteMode.SuggestAppend();
        }


    }
}


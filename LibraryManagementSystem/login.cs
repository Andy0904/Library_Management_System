﻿using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LibraryManagementSystem
{
    public partial class login : Form
    {   
        SqlConnection con = new SqlConnection(@"Data Source=ANDY\SQLEXPRESS;Initial Catalog=library_management_system;Integrated Security=True;Pooling=False;Encrypt=True;TrustServerCertificate=True");
        int count = 0;
        public login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType= CommandType.Text;
            cmd.CommandText = "select * from library_person where username='"+ textBox1.Text +"' and password='"+ textBox2.Text +"'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            count = Convert.ToInt32(dt.Rows.Count.ToString());
            if (count == 0)
            {
                MessageBox.Show("UserName or Password does not match !!!! ");
            }
            else 
            { 
                this.Hide();
                mdi_user mu= new mdi_user();
                mu.Show();
            }

        }

        private void login_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open) 
            {
                con.Close();    
            }
            con.Open();
        }
    }
}

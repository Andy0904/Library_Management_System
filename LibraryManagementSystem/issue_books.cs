using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LibraryManagementSystem
{
    public partial class issue_books : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=ANDY\SQLEXPRESS;Initial Catalog=library_management_system;Integrated Security=True;Pooling=False;Encrypt=True;TrustServerCertificate=True");

        public issue_books()
        {
            InitializeComponent();
        }

        private void issue_books_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int i=0;
                
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from student where S_UID ="+uid.Text+"";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                i = Convert.ToInt32(dt.Rows.Count.ToString());

                if (i == 0)
                {
                    MessageBox.Show("Student Record not found!!!");
                }
                else
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        sname.Text= dr["Sname"].ToString();
                        branch.Text=dr["Sbranch"].ToString();
                        email.Text = dr["Semail"].ToString();
                        phoneno.Text = dr["Sphone"].ToString() ;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox6_KeyUp(object sender, KeyEventArgs e)
        {
            //
        }

        private void bname_KeyUp(object sender, KeyEventArgs e)
        {
            int count = 0;

            if (e.KeyCode != Keys.Enter)
            {
                listBox1.Items.Clear();


                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from books where BookName like('&"+bname.Text+"&')";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                count = Convert.ToInt32(dt.Rows.Count.ToString());

                if (count > 0)
                {
                    listBox1.Visible = true;

                    foreach (DataRow dr in dt.Rows)
                    {
                        listBox1.Items.Add(dr["BookName"].ToString());
                    }
                }
            }
        }

        private void bname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                listBox1.Focus();
                listBox1.SelectedIndex = 0;
            }
        }

        private void textBox6_KeyDown(object sender, KeyEventArgs e)
        {
            //
        }

        private void listBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bname.Text=listBox1.SelectedItem.ToString();
                listBox1.Visible=false;
            }
        }

        private void listBox1_MouseClick(object sender, MouseEventArgs e)
        {
            bname.Text = listBox1.SelectedItem.ToString();
            listBox1.Visible = false;
        }

        private void issuebook_Click(object sender, EventArgs e)
        {
           /* SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into issue_books values("++",'"++"','"++"','"++"','"++"','"++"',"++",'"++"')";
            cmd.ExecuteNonQuery();

            mess
           
            */
        }

        
    }
}

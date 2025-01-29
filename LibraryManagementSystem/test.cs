using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class test : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=ANDY\SQLEXPRESS;Initial Catalog=library_management_system;Integrated Security=True;Pooling=False;Encrypt=True;TrustServerCertificate=True");

        public test()
        {
            InitializeComponent();
        }

        private void test_Load(object sender, EventArgs e)
        {
            if(con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {

            int count = 0;

            if (e.KeyCode != Keys.Enter)
            {
                listBox1.Items.Clear();


                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from books where BookName like '&" + book.Text + "&' ";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                
                count = Convert.ToInt32(dt.Rows.Count.ToString());
                MessageBox.Show(count.ToString());

                if (count >= 0)
                {
                    listBox1.Visible = true;

                    foreach (DataRow dr in dt.Rows)
                    {
                        listBox1.Items.Add(dr["BookName"].ToString());
                        listBox1.Items.Add(dr["BookISBN"].ToString());
                    }
                }   
            }
        }

        
    }
}

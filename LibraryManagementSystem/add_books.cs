using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LibraryManagementSystem
{
    public partial class add_books : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=ANDY\SQLEXPRESS;Initial Catalog=library_management_system;Integrated Security=True;Pooling=False;Encrypt=True;TrustServerCertificate=True");

        public add_books()
        {
            InitializeComponent();
        }

        private void add_books_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into books values('" + textBox1.Text + "','" + textBox2.Text + "'," + textBox3.Text + "," + textBox4.Text + "," + textBox5.Text + ",'" + Convert.ToDateTime(dateTimePicker1.Text) + "')";
            cmd.ExecuteNonQuery();
            con.Close();

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            //textBox6.Text = "";
            
            MessageBox.Show("Book Added Succesfully!!");

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VSMSOOPProject
{
    public partial class frmLoginAdmin : Form
    {
        public frmLoginAdmin()
        {
            InitializeComponent();
        }
<<<<<<< HEAD

        private void frmLoginAdmin_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string InputUsername = UsernameBox.Text;
            string InputPassword = PasswordBox.Text;
            clsAdmin objAdmin = new clsAdmin(InputUsername, InputPassword);
            objAdmin.Login(InputUsername, InputPassword);
        }
=======
        

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-BSVHRGN;Initial Catalog=DB_VSMSOOPProject;Integrated Security=True");
            con.Open();
            string username, user_password;

            username = textBox1.Text;
            user_password = textBox2.Text;

            try
            {
                string querry = "Select * from Customers where Username = '" + textBox1 + "'and  Password = '" + textBox2 + "'";
                SqlDataAdapter sda = new SqlDataAdapter(querry, con);
                DataTable dtable = new DataTable();
                sda.Fill(dtable);
                if (dtable.Rows.Count > 0)
                {
                    username = textBox1.Text;
                    user_password = textBox2.Text;

                    frmInventroy obj = new frmInventroy();
                    obj.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid Details", "Error", MessageBoxButtons.OK);
                    textBox1.Clear();
                    textBox2.Clear();

                    textBox1.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Invalid Log in Details");
            }
            finally
            {
                con.Close();
            }
        }


>>>>>>> 12ee19f675ab48f76df6a005370627a4be6e2cb8
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
    }
}

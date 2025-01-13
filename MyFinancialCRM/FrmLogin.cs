using MyFinancialCRM.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFinancialCRM
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        DBFinancialCRMEntities db = new DBFinancialCRMEntities();

        private void btnLogin_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtUserId.Text);
            string password = txtPassword.Text;
            var users = db.Users.Find(id);
                if (users.UserId == id && users.Password == password)
                {
                    FrmDashboard frm = new FrmDashboard();
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Kullanıcı ID veya Şifre hatalı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        
    }
}

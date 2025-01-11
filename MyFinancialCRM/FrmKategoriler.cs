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
    public partial class FrmKategoriler : Form
    {
        public FrmKategoriler()
        {
            InitializeComponent();
        }
        DBFinancialCRMEntities db = new DBFinancialCRMEntities();
        private void btnKategoriler_Click(object sender, EventArgs e)
        {
            FrmKategoriler frm = new FrmKategoriler();
            frm.Show();
            this.Hide();
        }

        private void btnBanks_Click(object sender, EventArgs e)
        {
            FrmBanks frm = new FrmBanks();
            frm.Show();
            this.Hide();
        }

        private void btnFaturalar_Click(object sender, EventArgs e)
        {
            FrmBillings frm = new FrmBillings();
            frm.Show();
            this.Hide();
        }

        private void btnGiderler_Click(object sender, EventArgs e)
        {
            FrmSpendings frm = new FrmSpendings();
            frm.Show();
            this.Hide();
        }

        private void btnBankaHareketleri_Click(object sender, EventArgs e)
        {
            FrmBankaHareketleri frm = new FrmBankaHareketleri();
            frm.Show();
            this.Hide();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            FrmDashboard frm = new FrmDashboard();
            frm.Show();
            this.Hide();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            FrmSettings frm = new FrmSettings();
            frm.Show();
            this.Hide();
        }

        private void btnListCategory_Click(object sender, EventArgs e)
        {
            var values = (from category in db.Categories
                          select new
                          {
                              category.CategoryId,
                              category.CategoryName
                          }).ToList();
            dataGridView1.DataSource = values;
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            string Name = txtCategoryName.Text;
            Categories categories = new Categories();
            categories.CategoryName = Name;
            db.Categories.Add(categories);
            db.SaveChanges();
            MessageBox.Show("Kategori başarılı bir şekilde sisteme eklendi!", "Kategori Formu", MessageBoxButtons.OK, MessageBoxIcon.Information);
            var values = (from category in db.Categories
                          select new
                          {
                              category.CategoryId,
                              category.CategoryName
                          }).ToList();
            dataGridView1.DataSource = values;
        }

        private void btnDeleteCategory_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtKategoriId.Text);
            var removeValue = db.Categories.Find(id);
            db.Categories.Remove(removeValue);
            db.SaveChanges();
            MessageBox.Show("Kategori başarılı bir şekilde sistemden silindi!", "Kategori Formu", MessageBoxButtons.OK, MessageBoxIcon.Information);
            var values = (from category in db.Categories
                          select new
                          {
                              category.CategoryId,
                              category.CategoryName
                          }).ToList();
            dataGridView1.DataSource = values;
        }

        private void btnUpdateCategory_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtKategoriId.Text);
            string name = txtCategoryName.Text;

            var categories = db.Categories.Find(id);
            categories.CategoryName = name;
            db.SaveChanges();
            MessageBox.Show("Kategori başarılı bir şekilde sistemde güncellendi!", "Kategori Formu", MessageBoxButtons.OK, MessageBoxIcon.Information);
            var values = (from category in db.Categories
                          select new
                          {
                              category.CategoryId,
                              category.CategoryName
                          }).ToList();
            dataGridView1.DataSource = values;
        }

        private void FrmKategoriler_Load(object sender, EventArgs e)
        {
            var values = (from category in db.Categories
                          select new
                          {
                              category.CategoryId,
                              category.CategoryName
                          }).ToList();
            dataGridView1.DataSource = values;
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

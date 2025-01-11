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
    public partial class FrmSpendings : Form
    {
        public FrmSpendings()
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

        private void btnListSpending_Click(object sender, EventArgs e)
        {
            var values = (from spending in db.Spendings
                          join category in db.Categories
                          on spending.CategoryId equals category.CategoryId
                          select new
                          {
                              spending.SpendingId,
                              spending.SpendingTitle,
                              spending.SpendingAmount,
                              spending.SpendingDate,
                              CategoryName = category.CategoryName 
                          }).ToList();
            dataGridView1.DataSource = values;
        }

        private void btnAddSpending_Click(object sender, EventArgs e)
        {
            string title = txtSpendingTitle.Text;
            decimal amount = decimal.Parse(txtSpendingAmount.Text);
            DateTime date = Convert.ToDateTime(txtSpendingDate.Text);
            int categoryName = int.Parse(cmbCategory.SelectedValue.ToString()); 

            Spendings spendings = new Spendings();
            spendings.SpendingTitle = title;
            spendings.SpendingAmount = amount;
            spendings.SpendingDate = date;
            spendings.CategoryId = categoryName;
            db.Spendings.Add(spendings);
            db.SaveChanges();
            MessageBox.Show("Harcama başarılı bir şekilde sisteme eklendi!", "Giderler Formu", MessageBoxButtons.OK, MessageBoxIcon.Information);
            var values = (from spending in db.Spendings
                          join category in db.Categories
                          on spending.CategoryId equals category.CategoryId
                          select new
                          {
                              spending.SpendingId,
                              spending.SpendingTitle,
                              spending.SpendingAmount,
                              spending.SpendingDate,
                              CategoryName = category.CategoryName
                          }).ToList();
            dataGridView1.DataSource = values;
        }

        private void FrmSpendings_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'dBFinancialCRMDataSet.Categories' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.categoriesTableAdapter.Fill(this.dBFinancialCRMDataSet.Categories);
            var values = (from spending in db.Spendings
                          join category in db.Categories
                          on spending.CategoryId equals category.CategoryId
                          select new
                          {
                              spending.SpendingId,
                              spending.SpendingTitle,
                              spending.SpendingAmount,
                              spending.SpendingDate,
                              CategoryName = category.CategoryName
                          }).ToList();
            dataGridView1.DataSource = values;
        }

        private void btnDeleteSpending_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtSpendingId.Text);
            var removeValue = db.Spendings.Find(id);
            db.Spendings.Remove(removeValue);
            db.SaveChanges();
            MessageBox.Show("Harcama başarılı bir şekilde sistemden silindi!", "Giderler Formu", MessageBoxButtons.OK, MessageBoxIcon.Information);
            var values = (from spending in db.Spendings
                          join category in db.Categories
                          on spending.CategoryId equals category.CategoryId
                          select new
                          {
                              spending.SpendingId,
                              spending.SpendingTitle,
                              spending.SpendingAmount,
                              spending.SpendingDate,
                              CategoryName = category.CategoryName
                          }).ToList();
            dataGridView1.DataSource = values;
        }

        private void btnUpdateSpending_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtSpendingId.Text);
            string title = txtSpendingTitle.Text;
            decimal amount = decimal.Parse(txtSpendingAmount.Text);
            DateTime date = Convert.ToDateTime(txtSpendingDate.Text);
            int categoryName = int.Parse(cmbCategory.SelectedValue.ToString());


            var spendings = db.Spendings.Find(id);
            spendings.SpendingTitle = title;
            spendings.SpendingAmount = amount;
            spendings.SpendingDate = date;
            spendings.CategoryId = categoryName;
            db.SaveChanges();
            MessageBox.Show("Harcama başarılı bir şekilde sistemde güncellendi!", "Giderler Formu", MessageBoxButtons.OK, MessageBoxIcon.Information);
            var values = (from spending in db.Spendings
                          join category in db.Categories
                          on spending.CategoryId equals category.CategoryId
                          select new
                          {
                              spending.SpendingId,
                              spending.SpendingTitle,
                              spending.SpendingAmount,
                              spending.SpendingDate,
                              CategoryName = category.CategoryName
                          }).ToList();
            dataGridView1.DataSource = values;
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

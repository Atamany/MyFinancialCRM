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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace MyFinancialCRM
{
    public partial class FrmBankaHareketleri : Form
    {
        public FrmBankaHareketleri()
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

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmBankaHareketleri_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'dBFinancialCRMDataSet1.Banks' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.banksTableAdapter.Fill(this.dBFinancialCRMDataSet1.Banks);
            var values = (from process in db.BankProcesses
                          join banks in db.Banks
                          on process.BankId equals banks.BankId
                          select new
                          {
                              process.BankProcessId,
                              process.Description,
                              process.ProcessDate,
                              process.ProcessType,
                              process.Amount,
                              BankName = banks.BankTitle
                          }).ToList();
            dataGridView1.DataSource = values;
        }

        private void btnListProcesses_Click(object sender, EventArgs e)
        {
            var values = (from process in db.BankProcesses
                          join banks in db.Banks
                          on process.BankId equals banks.BankId
                          select new
                          {
                              process.BankProcessId,
                              process.Description,
                              process.ProcessDate,
                              process.ProcessType,
                              process.Amount,
                              BankName = banks.BankTitle
                          }).ToList();
            dataGridView1.DataSource = values;
        }

        private void btnAddProcess_Click(object sender, EventArgs e)
        {
            string description = txtDescription.Text;
            DateTime date = DateTime.Parse(txtDate.Text);
            decimal amount = decimal.Parse(txtMiktar.Text);
            int BankName = int.Parse(cmbBank.SelectedValue.ToString());
            string type = "0";
            if (gelenHavale.Checked) { type = gelenHavale.Text; }  
            else if (gidenHavale.Checked) { type = gidenHavale.Text; }
                

            BankProcesses BankProcess = new BankProcesses();
            BankProcess.Description = description;
            BankProcess.ProcessDate = date;
            BankProcess.ProcessType = type;
            BankProcess.Amount = amount;
            BankProcess.BankId = BankName;
            db.BankProcesses.Add(BankProcess);
            db.SaveChanges();
            MessageBox.Show("İşlem başarılı bir şekilde sisteme eklendi!", "Banka Hareketleri Formu", MessageBoxButtons.OK, MessageBoxIcon.Information);
            var values = (from process in db.BankProcesses
                          join banks in db.Banks
                          on process.BankId equals banks.BankId
                          select new
                          {
                              process.BankProcessId,
                              process.Description,
                              process.ProcessDate,
                              process.ProcessType,
                              process.Amount,
                              BankName = banks.BankTitle
                          }).ToList();
            dataGridView1.DataSource = values;
        }

        private void btnDeleteProcess_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtBankProcessId.Text);
            var removeValue = db.BankProcesses.Find(id);
            db.BankProcesses.Remove(removeValue);
            db.SaveChanges();
            MessageBox.Show("İşlem başarılı bir şekilde sistemden silindi!", "Banka Hareketleri Formu", MessageBoxButtons.OK, MessageBoxIcon.Information);
            var values = (from process in db.BankProcesses
                          join banks in db.Banks
                          on process.BankId equals banks.BankId
                          select new
                          {
                              process.BankProcessId,
                              process.Description,
                              process.ProcessDate,
                              process.ProcessType,
                              process.Amount,
                              BankName = banks.BankTitle
                          }).ToList();
            dataGridView1.DataSource = values;
        }

        private void btnUpdateProcess_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtBankProcessId.Text);
            string description = txtDescription.Text;
            DateTime date = DateTime.Parse(txtDate.Text);
            decimal amount = decimal.Parse(txtMiktar.Text);
            int BankName = int.Parse(cmbBank.SelectedValue.ToString());
            string type = "0";
            if (gelenHavale.Checked) { type = gelenHavale.Text; }
            else if (gidenHavale.Checked) { type = gidenHavale.Text; }



            var BankProcess = db.BankProcesses.Find(id);
            BankProcess.Description = description;
            BankProcess.ProcessDate = date;
            BankProcess.ProcessType = type;
            BankProcess.Amount = amount;
            BankProcess.BankId = BankName;
            db.SaveChanges();
            MessageBox.Show("İşlem başarılı bir şekilde sistemde güncellendi!", "Banka Hareketleri Formu", MessageBoxButtons.OK, MessageBoxIcon.Information);
            var values = (from process in db.BankProcesses
                          join banks in db.Banks
                          on process.BankId equals banks.BankId
                          select new
                          {
                              process.BankProcessId,
                              process.Description,
                              process.ProcessDate,
                              process.ProcessType,
                              process.Amount,
                              BankName = banks.BankTitle
                          }).ToList();
            dataGridView1.DataSource = values;
        }
    }
}

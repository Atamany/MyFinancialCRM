namespace MyFinancialCRM
{
    partial class FrmBillings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnKategoriler = new System.Windows.Forms.Button();
            this.btnGiderler = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnFaturalar = new System.Windows.Forms.Button();
            this.btnBankaHareketleri = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.btnBanks = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnListBill = new System.Windows.Forms.Button();
            this.btnAddBill = new System.Windows.Forms.Button();
            this.btnUpdateBill = new System.Windows.Forms.Button();
            this.btnDeleteBill = new System.Windows.Forms.Button();
            this.txtBillPeriod = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBillAmount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBillTitle = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBillId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Blue;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1375, 95);
            this.panel2.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(11, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(334, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "Faturalar Formu";
            // 
            // btnQuit
            // 
            this.btnQuit.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnQuit.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnQuit.ForeColor = System.Drawing.Color.White;
            this.btnQuit.Location = new System.Drawing.Point(29, 528);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(233, 43);
            this.btnQuit.TabIndex = 7;
            this.btnQuit.Text = "Çıkış Yap!";
            this.btnQuit.UseVisualStyleBackColor = false;
            // 
            // btnKategoriler
            // 
            this.btnKategoriler.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnKategoriler.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKategoriler.ForeColor = System.Drawing.Color.White;
            this.btnKategoriler.Location = new System.Drawing.Point(29, 87);
            this.btnKategoriler.Name = "btnKategoriler";
            this.btnKategoriler.Size = new System.Drawing.Size(233, 43);
            this.btnKategoriler.TabIndex = 0;
            this.btnKategoriler.Text = "Kategoriler";
            this.btnKategoriler.UseVisualStyleBackColor = false;
            this.btnKategoriler.Click += new System.EventHandler(this.btnKategoriler_Click);
            // 
            // btnGiderler
            // 
            this.btnGiderler.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnGiderler.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGiderler.ForeColor = System.Drawing.Color.White;
            this.btnGiderler.Location = new System.Drawing.Point(29, 276);
            this.btnGiderler.Name = "btnGiderler";
            this.btnGiderler.Size = new System.Drawing.Size(233, 43);
            this.btnGiderler.TabIndex = 3;
            this.btnGiderler.Text = "Giderler";
            this.btnGiderler.UseVisualStyleBackColor = false;
            this.btnGiderler.Click += new System.EventHandler(this.btnGiderler_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnSettings.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSettings.ForeColor = System.Drawing.Color.White;
            this.btnSettings.Location = new System.Drawing.Point(29, 465);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(233, 43);
            this.btnSettings.TabIndex = 6;
            this.btnSettings.Text = "Ayarlar";
            this.btnSettings.UseVisualStyleBackColor = false;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnFaturalar
            // 
            this.btnFaturalar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnFaturalar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFaturalar.ForeColor = System.Drawing.Color.White;
            this.btnFaturalar.Location = new System.Drawing.Point(29, 213);
            this.btnFaturalar.Name = "btnFaturalar";
            this.btnFaturalar.Size = new System.Drawing.Size(233, 43);
            this.btnFaturalar.TabIndex = 2;
            this.btnFaturalar.Text = "Faturalar";
            this.btnFaturalar.UseVisualStyleBackColor = false;
            this.btnFaturalar.Click += new System.EventHandler(this.btnFaturalar_Click);
            // 
            // btnBankaHareketleri
            // 
            this.btnBankaHareketleri.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnBankaHareketleri.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBankaHareketleri.ForeColor = System.Drawing.Color.White;
            this.btnBankaHareketleri.Location = new System.Drawing.Point(29, 339);
            this.btnBankaHareketleri.Name = "btnBankaHareketleri";
            this.btnBankaHareketleri.Size = new System.Drawing.Size(233, 43);
            this.btnBankaHareketleri.TabIndex = 4;
            this.btnBankaHareketleri.Text = "Banka Hareketleri";
            this.btnBankaHareketleri.UseVisualStyleBackColor = false;
            this.btnBankaHareketleri.Click += new System.EventHandler(this.btnBankaHareketleri_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnDashboard.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.Location = new System.Drawing.Point(29, 402);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(233, 43);
            this.btnDashboard.TabIndex = 5;
            this.btnDashboard.Text = "Kullanıcı Paneli";
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // btnBanks
            // 
            this.btnBanks.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnBanks.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBanks.ForeColor = System.Drawing.Color.White;
            this.btnBanks.Location = new System.Drawing.Point(29, 150);
            this.btnBanks.Name = "btnBanks";
            this.btnBanks.Size = new System.Drawing.Size(233, 43);
            this.btnBanks.TabIndex = 1;
            this.btnBanks.Text = "Bankalar";
            this.btnBanks.UseVisualStyleBackColor = false;
            this.btnBanks.Click += new System.EventHandler(this.btnBanks_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.btnQuit);
            this.panel1.Controls.Add(this.btnKategoriler);
            this.panel1.Controls.Add(this.btnGiderler);
            this.panel1.Controls.Add(this.btnSettings);
            this.panel1.Controls.Add(this.btnFaturalar);
            this.panel1.Controls.Add(this.btnBankaHareketleri);
            this.panel1.Controls.Add(this.btnDashboard);
            this.panel1.Controls.Add(this.btnBanks);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(0, 95);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(285, 631);
            this.panel1.TabIndex = 11;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dataGridView1);
            this.panel4.Location = new System.Drawing.Point(305, 343);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1057, 373);
            this.panel4.TabIndex = 14;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, -5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1056, 383);
            this.dataGridView1.TabIndex = 9;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnListBill);
            this.panel3.Controls.Add(this.btnAddBill);
            this.panel3.Controls.Add(this.btnUpdateBill);
            this.panel3.Controls.Add(this.btnDeleteBill);
            this.panel3.Controls.Add(this.txtBillPeriod);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.txtBillAmount);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.txtBillTitle);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.txtBillId);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(306, 116);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1056, 220);
            this.panel3.TabIndex = 13;
            // 
            // btnListBill
            // 
            this.btnListBill.BackColor = System.Drawing.SystemColors.Control;
            this.btnListBill.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnListBill.ForeColor = System.Drawing.Color.Black;
            this.btnListBill.Location = new System.Drawing.Point(106, 167);
            this.btnListBill.Name = "btnListBill";
            this.btnListBill.Size = new System.Drawing.Size(213, 43);
            this.btnListBill.TabIndex = 13;
            this.btnListBill.Text = "Ödeme Listesi";
            this.btnListBill.UseVisualStyleBackColor = false;
            this.btnListBill.Click += new System.EventHandler(this.btnListBill_Click);
            // 
            // btnAddBill
            // 
            this.btnAddBill.BackColor = System.Drawing.SystemColors.Control;
            this.btnAddBill.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddBill.ForeColor = System.Drawing.Color.Black;
            this.btnAddBill.Location = new System.Drawing.Point(348, 167);
            this.btnAddBill.Name = "btnAddBill";
            this.btnAddBill.Size = new System.Drawing.Size(213, 43);
            this.btnAddBill.TabIndex = 12;
            this.btnAddBill.Text = "Yeni Ödeme";
            this.btnAddBill.UseVisualStyleBackColor = false;
            this.btnAddBill.Click += new System.EventHandler(this.btnAddBill_Click);
            // 
            // btnUpdateBill
            // 
            this.btnUpdateBill.BackColor = System.Drawing.SystemColors.Control;
            this.btnUpdateBill.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdateBill.ForeColor = System.Drawing.Color.Black;
            this.btnUpdateBill.Location = new System.Drawing.Point(833, 167);
            this.btnUpdateBill.Name = "btnUpdateBill";
            this.btnUpdateBill.Size = new System.Drawing.Size(213, 43);
            this.btnUpdateBill.TabIndex = 11;
            this.btnUpdateBill.Text = "Ödeme Güncelle";
            this.btnUpdateBill.UseVisualStyleBackColor = false;
            this.btnUpdateBill.Click += new System.EventHandler(this.btnUpdateBill_Click);
            // 
            // btnDeleteBill
            // 
            this.btnDeleteBill.BackColor = System.Drawing.SystemColors.Control;
            this.btnDeleteBill.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDeleteBill.ForeColor = System.Drawing.Color.Black;
            this.btnDeleteBill.Location = new System.Drawing.Point(590, 168);
            this.btnDeleteBill.Name = "btnDeleteBill";
            this.btnDeleteBill.Size = new System.Drawing.Size(213, 43);
            this.btnDeleteBill.TabIndex = 10;
            this.btnDeleteBill.Text = "Ödeme Sil";
            this.btnDeleteBill.UseVisualStyleBackColor = false;
            this.btnDeleteBill.Click += new System.EventHandler(this.btnDeleteBill_Click);
            // 
            // txtBillPeriod
            // 
            this.txtBillPeriod.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtBillPeriod.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBillPeriod.Location = new System.Drawing.Point(106, 130);
            this.txtBillPeriod.Name = "txtBillPeriod";
            this.txtBillPeriod.Size = new System.Drawing.Size(940, 32);
            this.txtBillPeriod.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(26, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 24);
            this.label5.TabIndex = 6;
            this.label5.Text = "Periyot:";
            // 
            // txtBillAmount
            // 
            this.txtBillAmount.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtBillAmount.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBillAmount.Location = new System.Drawing.Point(106, 92);
            this.txtBillAmount.Name = "txtBillAmount";
            this.txtBillAmount.Size = new System.Drawing.Size(940, 32);
            this.txtBillAmount.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(30, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "Miktar:";
            // 
            // txtBillTitle
            // 
            this.txtBillTitle.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtBillTitle.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBillTitle.Location = new System.Drawing.Point(106, 54);
            this.txtBillTitle.Name = "txtBillTitle";
            this.txtBillTitle.Size = new System.Drawing.Size(940, 32);
            this.txtBillTitle.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(37, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Başlık:";
            // 
            // txtBillId
            // 
            this.txtBillId.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtBillId.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBillId.Location = new System.Drawing.Point(106, 15);
            this.txtBillId.Name = "txtBillId";
            this.txtBillId.Size = new System.Drawing.Size(940, 32);
            this.txtBillId.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(3, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ödeme ID:";
            // 
            // FrmBillings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1374, 727);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmBillings";
            this.Text = "Faturalar";
            this.Load += new System.EventHandler(this.FrmBillings_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button btnKategoriler;
        private System.Windows.Forms.Button btnGiderler;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnFaturalar;
        private System.Windows.Forms.Button btnBankaHareketleri;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnBanks;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnListBill;
        private System.Windows.Forms.Button btnAddBill;
        private System.Windows.Forms.Button btnUpdateBill;
        private System.Windows.Forms.Button btnDeleteBill;
        private System.Windows.Forms.TextBox txtBillPeriod;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBillAmount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBillTitle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBillId;
        private System.Windows.Forms.Label label2;
    }
}
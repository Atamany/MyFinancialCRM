namespace MyFinancialCRM
{
    partial class FrmBankaHareketleri
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
            this.components = new System.ComponentModel.Container();
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
            this.gidenHavale = new System.Windows.Forms.RadioButton();
            this.gelenHavale = new System.Windows.Forms.RadioButton();
            this.txtBankProcessId = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbBank = new System.Windows.Forms.ComboBox();
            this.banksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBFinancialCRMDataSet1 = new MyFinancialCRM.DBFinancialCRMDataSet1();
            this.label6 = new System.Windows.Forms.Label();
            this.btnListProcesses = new System.Windows.Forms.Button();
            this.btnAddProcess = new System.Windows.Forms.Button();
            this.btnUpdateProcess = new System.Windows.Forms.Button();
            this.btnDeleteProcess = new System.Windows.Forms.Button();
            this.txtMiktar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dBFinancialCRMDataSet = new MyFinancialCRM.DBFinancialCRMDataSet();
            this.dBFinancialCRMDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.banksTableAdapter = new MyFinancialCRM.DBFinancialCRMDataSet1TableAdapters.BanksTableAdapter();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.banksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBFinancialCRMDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBFinancialCRMDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBFinancialCRMDataSetBindingSource)).BeginInit();
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
            this.label1.Size = new System.Drawing.Size(498, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "Banka Hareketleri Formu";
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
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
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
            this.panel4.Location = new System.Drawing.Point(305, 410);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1057, 303);
            this.panel4.TabIndex = 18;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1056, 339);
            this.dataGridView1.TabIndex = 9;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.gidenHavale);
            this.panel3.Controls.Add(this.gelenHavale);
            this.panel3.Controls.Add(this.txtBankProcessId);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.cmbBank);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.btnListProcesses);
            this.panel3.Controls.Add(this.btnAddProcess);
            this.panel3.Controls.Add(this.btnUpdateProcess);
            this.panel3.Controls.Add(this.btnDeleteProcess);
            this.panel3.Controls.Add(this.txtMiktar);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.txtDate);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.txtDescription);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(306, 102);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1056, 302);
            this.panel3.TabIndex = 17;
            // 
            // gidenHavale
            // 
            this.gidenHavale.AutoSize = true;
            this.gidenHavale.Location = new System.Drawing.Point(225, 137);
            this.gidenHavale.Name = "gidenHavale";
            this.gidenHavale.Size = new System.Drawing.Size(111, 20);
            this.gidenHavale.TabIndex = 19;
            this.gidenHavale.TabStop = true;
            this.gidenHavale.Text = "Giden Havale";
            this.gidenHavale.UseVisualStyleBackColor = true;
            // 
            // gelenHavale
            // 
            this.gelenHavale.AutoSize = true;
            this.gelenHavale.Location = new System.Drawing.Point(110, 137);
            this.gelenHavale.Name = "gelenHavale";
            this.gelenHavale.Size = new System.Drawing.Size(111, 20);
            this.gelenHavale.TabIndex = 18;
            this.gelenHavale.TabStop = true;
            this.gelenHavale.Text = "Gelen Havale";
            this.gelenHavale.UseVisualStyleBackColor = true;
            // 
            // txtBankProcessId
            // 
            this.txtBankProcessId.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtBankProcessId.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBankProcessId.Location = new System.Drawing.Point(106, 16);
            this.txtBankProcessId.Name = "txtBankProcessId";
            this.txtBankProcessId.Size = new System.Drawing.Size(940, 32);
            this.txtBankProcessId.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(71, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 24);
            this.label7.TabIndex = 16;
            this.label7.Text = "ID:";
            // 
            // cmbBank
            // 
            this.cmbBank.DataSource = this.banksBindingSource;
            this.cmbBank.DisplayMember = "BankTitle";
            this.cmbBank.FormattingEnabled = true;
            this.cmbBank.Location = new System.Drawing.Point(106, 210);
            this.cmbBank.Name = "cmbBank";
            this.cmbBank.Size = new System.Drawing.Size(940, 24);
            this.cmbBank.TabIndex = 15;
            this.cmbBank.ValueMember = "BankId";
            // 
            // banksBindingSource
            // 
            this.banksBindingSource.DataMember = "Banks";
            this.banksBindingSource.DataSource = this.dBFinancialCRMDataSet1;
            // 
            // dBFinancialCRMDataSet1
            // 
            this.dBFinancialCRMDataSet1.DataSetName = "DBFinancialCRMDataSet1";
            this.dBFinancialCRMDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(37, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 24);
            this.label6.TabIndex = 14;
            this.label6.Text = "Banka:";
            // 
            // btnListProcesses
            // 
            this.btnListProcesses.BackColor = System.Drawing.SystemColors.Control;
            this.btnListProcesses.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnListProcesses.ForeColor = System.Drawing.Color.Black;
            this.btnListProcesses.Location = new System.Drawing.Point(106, 246);
            this.btnListProcesses.Name = "btnListProcesses";
            this.btnListProcesses.Size = new System.Drawing.Size(213, 43);
            this.btnListProcesses.TabIndex = 13;
            this.btnListProcesses.Text = "İşlem Listesi";
            this.btnListProcesses.UseVisualStyleBackColor = false;
            this.btnListProcesses.Click += new System.EventHandler(this.btnListProcesses_Click);
            // 
            // btnAddProcess
            // 
            this.btnAddProcess.BackColor = System.Drawing.SystemColors.Control;
            this.btnAddProcess.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddProcess.ForeColor = System.Drawing.Color.Black;
            this.btnAddProcess.Location = new System.Drawing.Point(348, 246);
            this.btnAddProcess.Name = "btnAddProcess";
            this.btnAddProcess.Size = new System.Drawing.Size(213, 43);
            this.btnAddProcess.TabIndex = 12;
            this.btnAddProcess.Text = "Yeni İşlem";
            this.btnAddProcess.UseVisualStyleBackColor = false;
            this.btnAddProcess.Click += new System.EventHandler(this.btnAddProcess_Click);
            // 
            // btnUpdateProcess
            // 
            this.btnUpdateProcess.BackColor = System.Drawing.SystemColors.Control;
            this.btnUpdateProcess.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdateProcess.ForeColor = System.Drawing.Color.Black;
            this.btnUpdateProcess.Location = new System.Drawing.Point(833, 246);
            this.btnUpdateProcess.Name = "btnUpdateProcess";
            this.btnUpdateProcess.Size = new System.Drawing.Size(213, 43);
            this.btnUpdateProcess.TabIndex = 11;
            this.btnUpdateProcess.Text = "İşlem Güncelle";
            this.btnUpdateProcess.UseVisualStyleBackColor = false;
            this.btnUpdateProcess.Click += new System.EventHandler(this.btnUpdateProcess_Click);
            // 
            // btnDeleteProcess
            // 
            this.btnDeleteProcess.BackColor = System.Drawing.SystemColors.Control;
            this.btnDeleteProcess.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDeleteProcess.ForeColor = System.Drawing.Color.Black;
            this.btnDeleteProcess.Location = new System.Drawing.Point(590, 247);
            this.btnDeleteProcess.Name = "btnDeleteProcess";
            this.btnDeleteProcess.Size = new System.Drawing.Size(213, 43);
            this.btnDeleteProcess.TabIndex = 10;
            this.btnDeleteProcess.Text = "İşlem Sil";
            this.btnDeleteProcess.UseVisualStyleBackColor = false;
            this.btnDeleteProcess.Click += new System.EventHandler(this.btnDeleteProcess_Click);
            // 
            // txtMiktar
            // 
            this.txtMiktar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtMiktar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMiktar.Location = new System.Drawing.Point(106, 169);
            this.txtMiktar.Name = "txtMiktar";
            this.txtMiktar.Size = new System.Drawing.Size(940, 32);
            this.txtMiktar.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(33, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 24);
            this.label5.TabIndex = 6;
            this.label5.Text = "Miktar:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(61, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tür:";
            // 
            // txtDate
            // 
            this.txtDate.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtDate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtDate.Location = new System.Drawing.Point(106, 93);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(940, 32);
            this.txtDate.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(47, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tarih:";
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtDescription.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtDescription.Location = new System.Drawing.Point(106, 54);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(940, 32);
            this.txtDescription.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(13, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Açıklama:";
            // 
            // dBFinancialCRMDataSet
            // 
            this.dBFinancialCRMDataSet.DataSetName = "DBFinancialCRMDataSet";
            this.dBFinancialCRMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dBFinancialCRMDataSetBindingSource
            // 
            this.dBFinancialCRMDataSetBindingSource.DataSource = this.dBFinancialCRMDataSet;
            this.dBFinancialCRMDataSetBindingSource.Position = 0;
            // 
            // banksTableAdapter
            // 
            this.banksTableAdapter.ClearBeforeFill = true;
            // 
            // FrmBankaHareketleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1374, 727);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmBankaHareketleri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Banka Hareketleri";
            this.Load += new System.EventHandler(this.FrmBankaHareketleri_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.banksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBFinancialCRMDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBFinancialCRMDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBFinancialCRMDataSetBindingSource)).EndInit();
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
        private System.Windows.Forms.ComboBox cmbBank;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnListProcesses;
        private System.Windows.Forms.Button btnAddProcess;
        private System.Windows.Forms.Button btnUpdateProcess;
        private System.Windows.Forms.Button btnDeleteProcess;
        private System.Windows.Forms.TextBox txtMiktar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBankProcessId;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton gidenHavale;
        private System.Windows.Forms.RadioButton gelenHavale;
        private DBFinancialCRMDataSet dBFinancialCRMDataSet;
        private System.Windows.Forms.BindingSource dBFinancialCRMDataSetBindingSource;
        private DBFinancialCRMDataSet1 dBFinancialCRMDataSet1;
        private System.Windows.Forms.BindingSource banksBindingSource;
        private DBFinancialCRMDataSet1TableAdapters.BanksTableAdapter banksTableAdapter;
    }
}
namespace Ogrencıtablouygulaması
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_Ad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_Soyad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.comboBoxBolum1 = new System.Windows.Forms.ComboBox();
            this.comboBoxSehir2 = new System.Windows.Forms.ComboBox();
            this.Txt_Ekle = new System.Windows.Forms.Button();
            this.Txt_Sil = new System.Windows.Forms.Button();
            this.Txt_guncelle = new System.Windows.Forms.Button();
            this.Txt_Listele = new System.Windows.Forms.Button();
            this.Txt_Ara = new System.Windows.Forms.Button();
            this.ogrenciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new System.Data.DataSet();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ogrnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bolumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sehirDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrenciBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ogrenciDataSet = new Ogrencıtablouygulaması.OgrenciDataSet();
            this.ogrenciTableAdapter1 = new Ogrencıtablouygulaması.OgrenciDataSetTableAdapters.OgrenciTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ogrno";
            // 
            // Txt_Ad
            // 
            this.Txt_Ad.Location = new System.Drawing.Point(112, 92);
            this.Txt_Ad.Name = "Txt_Ad";
            this.Txt_Ad.Size = new System.Drawing.Size(176, 20);
            this.Txt_Ad.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ad";
            // 
            // Txt_Soyad
            // 
            this.Txt_Soyad.Location = new System.Drawing.Point(112, 137);
            this.Txt_Soyad.Name = "Txt_Soyad";
            this.Txt_Soyad.Size = new System.Drawing.Size(176, 20);
            this.Txt_Soyad.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Soyad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Bolum";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Sehir";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(112, 50);
            this.maskedTextBox1.Mask = "00000000000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(176, 20);
            this.maskedTextBox1.TabIndex = 9;
            this.maskedTextBox1.ValidatingType = typeof(int);
            // 
            // comboBoxBolum1
            // 
            this.comboBoxBolum1.FormattingEnabled = true;
            this.comboBoxBolum1.Items.AddRange(new object[] {
            "Bilgisayar Programcılığı",
            "Ziraat Mühendisliğ",
            "Sosyoloji",
            "Psikoloji",
            "Bilgisayar Mühendisliği"});
            this.comboBoxBolum1.Location = new System.Drawing.Point(112, 189);
            this.comboBoxBolum1.Name = "comboBoxBolum1";
            this.comboBoxBolum1.Size = new System.Drawing.Size(197, 21);
            this.comboBoxBolum1.TabIndex = 10;
            // 
            // comboBoxSehir2
            // 
            this.comboBoxSehir2.FormattingEnabled = true;
            this.comboBoxSehir2.Items.AddRange(new object[] {
            "Kahramanmaraş ",
            "İstanbul",
            "Ankara",
            "İzmir ",
            "Manisa",
            "Muğla",
            "Aydın",
            "Sivas"});
            this.comboBoxSehir2.Location = new System.Drawing.Point(112, 227);
            this.comboBoxSehir2.Name = "comboBoxSehir2";
            this.comboBoxSehir2.Size = new System.Drawing.Size(197, 21);
            this.comboBoxSehir2.TabIndex = 11;
            // 
            // Txt_Ekle
            // 
            this.Txt_Ekle.Location = new System.Drawing.Point(48, 275);
            this.Txt_Ekle.Name = "Txt_Ekle";
            this.Txt_Ekle.Size = new System.Drawing.Size(75, 23);
            this.Txt_Ekle.TabIndex = 12;
            this.Txt_Ekle.Text = "Ekle";
            this.Txt_Ekle.UseVisualStyleBackColor = true;
            this.Txt_Ekle.Click += new System.EventHandler(this.Txt_Ekle_Click);
            // 
            // Txt_Sil
            // 
            this.Txt_Sil.Location = new System.Drawing.Point(139, 275);
            this.Txt_Sil.Name = "Txt_Sil";
            this.Txt_Sil.Size = new System.Drawing.Size(75, 23);
            this.Txt_Sil.TabIndex = 13;
            this.Txt_Sil.Text = "Sil";
            this.Txt_Sil.UseVisualStyleBackColor = true;
            this.Txt_Sil.Click += new System.EventHandler(this.Txt_Sil_Click);
            // 
            // Txt_guncelle
            // 
            this.Txt_guncelle.Location = new System.Drawing.Point(234, 275);
            this.Txt_guncelle.Name = "Txt_guncelle";
            this.Txt_guncelle.Size = new System.Drawing.Size(75, 23);
            this.Txt_guncelle.TabIndex = 14;
            this.Txt_guncelle.Text = "Güncelle";
            this.Txt_guncelle.UseVisualStyleBackColor = true;
            this.Txt_guncelle.Click += new System.EventHandler(this.Txt_guncelle_Click);
            // 
            // Txt_Listele
            // 
            this.Txt_Listele.Location = new System.Drawing.Point(337, 275);
            this.Txt_Listele.Name = "Txt_Listele";
            this.Txt_Listele.Size = new System.Drawing.Size(75, 23);
            this.Txt_Listele.TabIndex = 15;
            this.Txt_Listele.Text = "Listele";
            this.Txt_Listele.UseVisualStyleBackColor = true;
            this.Txt_Listele.Click += new System.EventHandler(this.Txt_Listele_Click);
            // 
            // Txt_Ara
            // 
            this.Txt_Ara.Location = new System.Drawing.Point(427, 275);
            this.Txt_Ara.Name = "Txt_Ara";
            this.Txt_Ara.Size = new System.Drawing.Size(75, 23);
            this.Txt_Ara.TabIndex = 16;
            this.Txt_Ara.Text = "Ara";
            this.Txt_Ara.UseVisualStyleBackColor = true;
            this.Txt_Ara.Click += new System.EventHandler(this.Txt_Ara_Click);
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "NewDataSet";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ogrnoDataGridViewTextBoxColumn,
            this.adDataGridViewTextBoxColumn,
            this.soyadDataGridViewTextBoxColumn,
            this.bolumDataGridViewTextBoxColumn,
            this.sehirDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ogrenciBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 304);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(545, 193);
            this.dataGridView1.TabIndex = 17;
            // 
            // ogrnoDataGridViewTextBoxColumn
            // 
            this.ogrnoDataGridViewTextBoxColumn.DataPropertyName = "Ogrno";
            this.ogrnoDataGridViewTextBoxColumn.HeaderText = "Ogrno";
            this.ogrnoDataGridViewTextBoxColumn.Name = "ogrnoDataGridViewTextBoxColumn";
            this.ogrnoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // adDataGridViewTextBoxColumn
            // 
            this.adDataGridViewTextBoxColumn.DataPropertyName = "Ad ";
            this.adDataGridViewTextBoxColumn.HeaderText = "Ad ";
            this.adDataGridViewTextBoxColumn.Name = "adDataGridViewTextBoxColumn";
            // 
            // soyadDataGridViewTextBoxColumn
            // 
            this.soyadDataGridViewTextBoxColumn.DataPropertyName = "Soyad";
            this.soyadDataGridViewTextBoxColumn.HeaderText = "Soyad";
            this.soyadDataGridViewTextBoxColumn.Name = "soyadDataGridViewTextBoxColumn";
            // 
            // bolumDataGridViewTextBoxColumn
            // 
            this.bolumDataGridViewTextBoxColumn.DataPropertyName = "Bolum";
            this.bolumDataGridViewTextBoxColumn.HeaderText = "Bolum";
            this.bolumDataGridViewTextBoxColumn.Name = "bolumDataGridViewTextBoxColumn";
            // 
            // sehirDataGridViewTextBoxColumn
            // 
            this.sehirDataGridViewTextBoxColumn.DataPropertyName = "Sehir";
            this.sehirDataGridViewTextBoxColumn.HeaderText = "Sehir";
            this.sehirDataGridViewTextBoxColumn.Name = "sehirDataGridViewTextBoxColumn";
            // 
            // ogrenciBindingSource1
            // 
            this.ogrenciBindingSource1.DataMember = "Ogrenci";
            this.ogrenciBindingSource1.DataSource = this.ogrenciDataSet;
            // 
            // ogrenciDataSet
            // 
            this.ogrenciDataSet.DataSetName = "OgrenciDataSet";
            this.ogrenciDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ogrenciTableAdapter1
            // 
            this.ogrenciTableAdapter1.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(569, 500);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Txt_Ara);
            this.Controls.Add(this.Txt_Listele);
            this.Controls.Add(this.Txt_guncelle);
            this.Controls.Add(this.Txt_Sil);
            this.Controls.Add(this.Txt_Ekle);
            this.Controls.Add(this.comboBoxSehir2);
            this.Controls.Add(this.comboBoxBolum1);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Txt_Soyad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Txt_Ad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_Ad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txt_Soyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.ComboBox comboBoxBolum1;
        private System.Windows.Forms.ComboBox comboBoxSehir2;
        private System.Windows.Forms.Button Txt_Ekle;
        private System.Windows.Forms.Button Txt_Sil;
        private System.Windows.Forms.Button Txt_guncelle;
        private System.Windows.Forms.Button Txt_Listele;
        private System.Windows.Forms.Button Txt_Ara;
        private System.Data.DataSet dataSet1;
        private System.Windows.Forms.BindingSource ogrenciBindingSource;
    
        private System.Windows.Forms.DataGridView dataGridView1;
        private OgrenciDataSet ogrenciDataSet;
        private System.Windows.Forms.BindingSource ogrenciBindingSource1;
        private OgrenciDataSetTableAdapters.OgrenciTableAdapter ogrenciTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bolumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sehirDataGridViewTextBoxColumn;
    }
}



namespace Telebe_Yataqxanasi
{
    partial class frmIsciler
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
            this.txtIsciId = new System.Windows.Forms.TextBox();
            this.txtIsciAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIsciSobe = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnYaddaSaxla = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.isciIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isciAdSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isciSobeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iscilerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.telebeYataqxanasiDataSet6 = new Telebe_Yataqxanasi.TelebeYataqxanasiDataSet6();
            this.iscilerTableAdapter = new Telebe_Yataqxanasi.TelebeYataqxanasiDataSet6TableAdapters.IscilerTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iscilerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.telebeYataqxanasiDataSet6)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "İşçi İD:";
            // 
            // txtIsciId
            // 
            this.txtIsciId.BackColor = System.Drawing.Color.AliceBlue;
            this.txtIsciId.Enabled = false;
            this.txtIsciId.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIsciId.Location = new System.Drawing.Point(113, 12);
            this.txtIsciId.Name = "txtIsciId";
            this.txtIsciId.Size = new System.Drawing.Size(200, 25);
            this.txtIsciId.TabIndex = 1;
            // 
            // txtIsciAd
            // 
            this.txtIsciAd.BackColor = System.Drawing.Color.AliceBlue;
            this.txtIsciAd.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIsciAd.Location = new System.Drawing.Point(113, 43);
            this.txtIsciAd.Name = "txtIsciAd";
            this.txtIsciAd.Size = new System.Drawing.Size(200, 25);
            this.txtIsciAd.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "İşçi Ad:";
            // 
            // txtIsciSobe
            // 
            this.txtIsciSobe.BackColor = System.Drawing.Color.AliceBlue;
            this.txtIsciSobe.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIsciSobe.Location = new System.Drawing.Point(113, 74);
            this.txtIsciSobe.Name = "txtIsciSobe";
            this.txtIsciSobe.Size = new System.Drawing.Size(200, 25);
            this.txtIsciSobe.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "İşçi Şöbə:";
            // 
            // btnYaddaSaxla
            // 
            this.btnYaddaSaxla.BackColor = System.Drawing.Color.CadetBlue;
            this.btnYaddaSaxla.Location = new System.Drawing.Point(13, 139);
            this.btnYaddaSaxla.Name = "btnYaddaSaxla";
            this.btnYaddaSaxla.Size = new System.Drawing.Size(110, 44);
            this.btnYaddaSaxla.TabIndex = 6;
            this.btnYaddaSaxla.Text = "Yadda Saxla";
            this.btnYaddaSaxla.UseVisualStyleBackColor = false;
            this.btnYaddaSaxla.Click += new System.EventHandler(this.btnYaddaSaxla_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.CadetBlue;
            this.btnSil.Location = new System.Drawing.Point(156, 139);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(110, 44);
            this.btnSil.TabIndex = 7;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.CadetBlue;
            this.btnGuncelle.Location = new System.Drawing.Point(298, 139);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(110, 44);
            this.btnGuncelle.TabIndex = 8;
            this.btnGuncelle.Text = "Güncəllə";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.isciIdDataGridViewTextBoxColumn,
            this.isciAdSoyadDataGridViewTextBoxColumn,
            this.isciSobeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.iscilerBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(2, 189);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(484, 206);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // isciIdDataGridViewTextBoxColumn
            // 
            this.isciIdDataGridViewTextBoxColumn.DataPropertyName = "IsciId";
            this.isciIdDataGridViewTextBoxColumn.HeaderText = "IsciId";
            this.isciIdDataGridViewTextBoxColumn.Name = "isciIdDataGridViewTextBoxColumn";
            // 
            // isciAdSoyadDataGridViewTextBoxColumn
            // 
            this.isciAdSoyadDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.isciAdSoyadDataGridViewTextBoxColumn.DataPropertyName = "IsciAdSoyad";
            this.isciAdSoyadDataGridViewTextBoxColumn.HeaderText = "IsciAdSoyad";
            this.isciAdSoyadDataGridViewTextBoxColumn.Name = "isciAdSoyadDataGridViewTextBoxColumn";
            this.isciAdSoyadDataGridViewTextBoxColumn.Width = 133;
            // 
            // isciSobeDataGridViewTextBoxColumn
            // 
            this.isciSobeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.isciSobeDataGridViewTextBoxColumn.DataPropertyName = "IsciSobe";
            this.isciSobeDataGridViewTextBoxColumn.HeaderText = "IsciSobe";
            this.isciSobeDataGridViewTextBoxColumn.Name = "isciSobeDataGridViewTextBoxColumn";
            // 
            // iscilerBindingSource
            // 
            this.iscilerBindingSource.DataMember = "Isciler";
            this.iscilerBindingSource.DataSource = this.telebeYataqxanasiDataSet6;
            // 
            // telebeYataqxanasiDataSet6
            // 
            this.telebeYataqxanasiDataSet6.DataSetName = "TelebeYataqxanasiDataSet6";
            this.telebeYataqxanasiDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // iscilerTableAdapter
            // 
            this.iscilerTableAdapter.ClearBeforeFill = true;
            // 
            // frmIsciler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(487, 395);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnYaddaSaxla);
            this.Controls.Add(this.txtIsciSobe);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtIsciAd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIsciId);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmIsciler";
            this.ShowIcon = false;
            this.Text = "İşçilər";
            this.Load += new System.EventHandler(this.frmIsciler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iscilerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.telebeYataqxanasiDataSet6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIsciId;
        private System.Windows.Forms.TextBox txtIsciAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIsciSobe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnYaddaSaxla;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private TelebeYataqxanasiDataSet6 telebeYataqxanasiDataSet6;
        private System.Windows.Forms.BindingSource iscilerBindingSource;
        private TelebeYataqxanasiDataSet6TableAdapters.IscilerTableAdapter iscilerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn isciIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn isciAdSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn isciSobeDataGridViewTextBoxColumn;
    }
}
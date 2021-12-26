
namespace Telebe_Yataqxanasi
{
    partial class frmAdminGuncelle
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
            this.txtİstifadeciİd = new System.Windows.Forms.TextBox();
            this.txtİstifadeciAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnYaddaSaxla = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.adminIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adminAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adminSifreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adminBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.telebeYataqxanasiDataSet5 = new Telebe_Yataqxanasi.TelebeYataqxanasiDataSet5();
            this.adminTableAdapter = new Telebe_Yataqxanasi.TelebeYataqxanasiDataSet5TableAdapters.AdminTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.telebeYataqxanasiDataSet5)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "İstifadəçi İD:";
            // 
            // txtİstifadeciİd
            // 
            this.txtİstifadeciİd.BackColor = System.Drawing.Color.AliceBlue;
            this.txtİstifadeciİd.Enabled = false;
            this.txtİstifadeciİd.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtİstifadeciİd.Location = new System.Drawing.Point(171, 38);
            this.txtİstifadeciİd.Name = "txtİstifadeciİd";
            this.txtİstifadeciİd.Size = new System.Drawing.Size(235, 25);
            this.txtİstifadeciİd.TabIndex = 1;
            // 
            // txtİstifadeciAd
            // 
            this.txtİstifadeciAd.BackColor = System.Drawing.Color.AliceBlue;
            this.txtİstifadeciAd.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtİstifadeciAd.Location = new System.Drawing.Point(171, 75);
            this.txtİstifadeciAd.Name = "txtİstifadeciAd";
            this.txtİstifadeciAd.Size = new System.Drawing.Size(235, 25);
            this.txtİstifadeciAd.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(53, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "İstifadəçi Ad:";
            // 
            // txtSifre
            // 
            this.txtSifre.BackColor = System.Drawing.Color.AliceBlue;
            this.txtSifre.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSifre.Location = new System.Drawing.Point(171, 112);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(235, 25);
            this.txtSifre.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(111, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Şifrə:";
            // 
            // btnYaddaSaxla
            // 
            this.btnYaddaSaxla.BackColor = System.Drawing.Color.CadetBlue;
            this.btnYaddaSaxla.Location = new System.Drawing.Point(1, 167);
            this.btnYaddaSaxla.Name = "btnYaddaSaxla";
            this.btnYaddaSaxla.Size = new System.Drawing.Size(167, 40);
            this.btnYaddaSaxla.TabIndex = 6;
            this.btnYaddaSaxla.Text = "Yadda Saxla";
            this.btnYaddaSaxla.UseVisualStyleBackColor = false;
            this.btnYaddaSaxla.Click += new System.EventHandler(this.btnYaddaSaxla_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.CadetBlue;
            this.btnSil.Location = new System.Drawing.Point(198, 167);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(167, 40);
            this.btnSil.TabIndex = 7;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.CadetBlue;
            this.btnGuncelle.Location = new System.Drawing.Point(393, 167);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(167, 40);
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
            this.adminIdDataGridViewTextBoxColumn,
            this.adminAdDataGridViewTextBoxColumn,
            this.adminSifreDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.adminBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(1, 216);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(454, 195);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // adminIdDataGridViewTextBoxColumn
            // 
            this.adminIdDataGridViewTextBoxColumn.DataPropertyName = "AdminId";
            this.adminIdDataGridViewTextBoxColumn.HeaderText = "AdminId";
            this.adminIdDataGridViewTextBoxColumn.Name = "adminIdDataGridViewTextBoxColumn";
            this.adminIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // adminAdDataGridViewTextBoxColumn
            // 
            this.adminAdDataGridViewTextBoxColumn.DataPropertyName = "AdminAd";
            this.adminAdDataGridViewTextBoxColumn.HeaderText = "AdminAd";
            this.adminAdDataGridViewTextBoxColumn.Name = "adminAdDataGridViewTextBoxColumn";
            // 
            // adminSifreDataGridViewTextBoxColumn
            // 
            this.adminSifreDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.adminSifreDataGridViewTextBoxColumn.DataPropertyName = "AdminSifre";
            this.adminSifreDataGridViewTextBoxColumn.HeaderText = "AdminSifre";
            this.adminSifreDataGridViewTextBoxColumn.Name = "adminSifreDataGridViewTextBoxColumn";
            // 
            // adminBindingSource
            // 
            this.adminBindingSource.DataMember = "Admin";
            this.adminBindingSource.DataSource = this.telebeYataqxanasiDataSet5;
            // 
            // telebeYataqxanasiDataSet5
            // 
            this.telebeYataqxanasiDataSet5.DataSetName = "TelebeYataqxanasiDataSet5";
            this.telebeYataqxanasiDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // adminTableAdapter
            // 
            this.adminTableAdapter.ClearBeforeFill = true;
            // 
            // frmAdminGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(563, 410);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnYaddaSaxla);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtİstifadeciAd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtİstifadeciİd);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAdminGuncelle";
            this.ShowIcon = false;
            this.Text = "Manager";
            this.Load += new System.EventHandler(this.frmSifreGuncelle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.telebeYataqxanasiDataSet5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtİstifadeciİd;
        private System.Windows.Forms.TextBox txtİstifadeciAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnYaddaSaxla;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private TelebeYataqxanasiDataSet5 telebeYataqxanasiDataSet5;
        private System.Windows.Forms.BindingSource adminBindingSource;
        private TelebeYataqxanasiDataSet5TableAdapters.AdminTableAdapter adminTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn adminIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adminAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adminSifreDataGridViewTextBoxColumn;
    }
}

namespace Telebe_Yataqxanasi
{
    partial class frmOdemeler
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
            this.txtTlbId = new System.Windows.Forms.TextBox();
            this.txtOdenilen = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtQalanBorc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnOdemeAl = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tlbIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tlbAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tlbSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tlbQalanBorcDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.borclarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.telebeYataqxanasiDataSet2 = new Telebe_Yataqxanasi.TelebeYataqxanasiDataSet2();
            this.borclarTableAdapter = new Telebe_Yataqxanasi.TelebeYataqxanasiDataSet2TableAdapters.BorclarTableAdapter();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtOdenenAy = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.borclarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.telebeYataqxanasiDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tələbə Id:";
            // 
            // txtTlbId
            // 
            this.txtTlbId.BackColor = System.Drawing.Color.AliceBlue;
            this.txtTlbId.Location = new System.Drawing.Point(110, 29);
            this.txtTlbId.Name = "txtTlbId";
            this.txtTlbId.Size = new System.Drawing.Size(193, 26);
            this.txtTlbId.TabIndex = 2;
            // 
            // txtOdenilen
            // 
            this.txtOdenilen.BackColor = System.Drawing.Color.AliceBlue;
            this.txtOdenilen.Location = new System.Drawing.Point(110, 125);
            this.txtOdenilen.Name = "txtOdenilen";
            this.txtOdenilen.Size = new System.Drawing.Size(193, 26);
            this.txtOdenilen.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ödənilən:";
            // 
            // txtQalanBorc
            // 
            this.txtQalanBorc.BackColor = System.Drawing.Color.AliceBlue;
            this.txtQalanBorc.Location = new System.Drawing.Point(110, 157);
            this.txtQalanBorc.Name = "txtQalanBorc";
            this.txtQalanBorc.Size = new System.Drawing.Size(193, 26);
            this.txtQalanBorc.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Qalan Borc:";
            // 
            // btnOdemeAl
            // 
            this.btnOdemeAl.BackColor = System.Drawing.Color.CadetBlue;
            this.btnOdemeAl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOdemeAl.Location = new System.Drawing.Point(129, 220);
            this.btnOdemeAl.Name = "btnOdemeAl";
            this.btnOdemeAl.Size = new System.Drawing.Size(139, 41);
            this.btnOdemeAl.TabIndex = 7;
            this.btnOdemeAl.Text = "Ödəmə Al";
            this.btnOdemeAl.UseVisualStyleBackColor = false;
            this.btnOdemeAl.Click += new System.EventHandler(this.btnOdemeAl_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tlbIdDataGridViewTextBoxColumn,
            this.tlbAdDataGridViewTextBoxColumn,
            this.tlbSoyadDataGridViewTextBoxColumn,
            this.tlbQalanBorcDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.borclarBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(319, -2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(445, 232);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // tlbIdDataGridViewTextBoxColumn
            // 
            this.tlbIdDataGridViewTextBoxColumn.DataPropertyName = "TlbId";
            this.tlbIdDataGridViewTextBoxColumn.HeaderText = "TlbId";
            this.tlbIdDataGridViewTextBoxColumn.Name = "tlbIdDataGridViewTextBoxColumn";
            // 
            // tlbAdDataGridViewTextBoxColumn
            // 
            this.tlbAdDataGridViewTextBoxColumn.DataPropertyName = "TlbAd";
            this.tlbAdDataGridViewTextBoxColumn.HeaderText = "TlbAd";
            this.tlbAdDataGridViewTextBoxColumn.Name = "tlbAdDataGridViewTextBoxColumn";
            // 
            // tlbSoyadDataGridViewTextBoxColumn
            // 
            this.tlbSoyadDataGridViewTextBoxColumn.DataPropertyName = "TlbSoyad";
            this.tlbSoyadDataGridViewTextBoxColumn.HeaderText = "TlbSoyad";
            this.tlbSoyadDataGridViewTextBoxColumn.Name = "tlbSoyadDataGridViewTextBoxColumn";
            // 
            // tlbQalanBorcDataGridViewTextBoxColumn
            // 
            this.tlbQalanBorcDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tlbQalanBorcDataGridViewTextBoxColumn.DataPropertyName = "TlbQalanBorc";
            this.tlbQalanBorcDataGridViewTextBoxColumn.HeaderText = "TlbQalanBorc";
            this.tlbQalanBorcDataGridViewTextBoxColumn.Name = "tlbQalanBorcDataGridViewTextBoxColumn";
            // 
            // borclarBindingSource
            // 
            this.borclarBindingSource.DataMember = "Borclar";
            this.borclarBindingSource.DataSource = this.telebeYataqxanasiDataSet2;
            // 
            // telebeYataqxanasiDataSet2
            // 
            this.telebeYataqxanasiDataSet2.DataSetName = "TelebeYataqxanasiDataSet2";
            this.telebeYataqxanasiDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // borclarTableAdapter
            // 
            this.borclarTableAdapter.ClearBeforeFill = true;
            // 
            // txtAd
            // 
            this.txtAd.BackColor = System.Drawing.Color.AliceBlue;
            this.txtAd.Location = new System.Drawing.Point(110, 61);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(193, 26);
            this.txtAd.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(71, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 19);
            this.label4.TabIndex = 9;
            this.label4.Text = "Ad:";
            // 
            // txtSoyad
            // 
            this.txtSoyad.BackColor = System.Drawing.Color.AliceBlue;
            this.txtSoyad.Location = new System.Drawing.Point(110, 93);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(193, 26);
            this.txtSoyad.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(50, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 19);
            this.label5.TabIndex = 11;
            this.label5.Text = "Soyad:";
            // 
            // txtOdenenAy
            // 
            this.txtOdenenAy.BackColor = System.Drawing.Color.AliceBlue;
            this.txtOdenenAy.Location = new System.Drawing.Point(110, 189);
            this.txtOdenenAy.Name = "txtOdenenAy";
            this.txtOdenenAy.Size = new System.Drawing.Size(193, 26);
            this.txtOdenenAy.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(18, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 19);
            this.label6.TabIndex = 13;
            this.label6.Text = "Ödənən Ay:";
            // 
            // frmOdemeler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(764, 304);
            this.Controls.Add(this.txtOdenenAy);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnOdemeAl);
            this.Controls.Add(this.txtQalanBorc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtOdenilen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTlbId);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmOdemeler";
            this.ShowIcon = false;
            this.Text = "Gəlirlər";
            this.Load += new System.EventHandler(this.frmOdemeler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.borclarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.telebeYataqxanasiDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTlbId;
        private System.Windows.Forms.TextBox txtOdenilen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtQalanBorc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnOdemeAl;
        private System.Windows.Forms.DataGridView dataGridView1;
        private TelebeYataqxanasiDataSet2 telebeYataqxanasiDataSet2;
        private System.Windows.Forms.BindingSource borclarBindingSource;
        private TelebeYataqxanasiDataSet2TableAdapters.BorclarTableAdapter borclarTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn tlbIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tlbAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tlbSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tlbQalanBorcDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtOdenenAy;
        private System.Windows.Forms.Label label6;
    }
}
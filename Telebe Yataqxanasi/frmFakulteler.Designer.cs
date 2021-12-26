
namespace Telebe_Yataqxanasi
{
    partial class frmFakulteler
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
            this.txtFakulteId = new System.Windows.Forms.TextBox();
            this.txtFakulteAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnElaveEt = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.fakulteIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fakulteAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fakultelerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.telebeYataqxanasiDataSet = new Telebe_Yataqxanasi.TelebeYataqxanasiDataSet();
            this.fakultelerTableAdapter = new Telebe_Yataqxanasi.TelebeYataqxanasiDataSetTableAdapters.FakultelerTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fakultelerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.telebeYataqxanasiDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fakültə İd:";
            // 
            // txtFakulteId
            // 
            this.txtFakulteId.BackColor = System.Drawing.Color.AliceBlue;
            this.txtFakulteId.Enabled = false;
            this.txtFakulteId.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFakulteId.Location = new System.Drawing.Point(113, 33);
            this.txtFakulteId.Name = "txtFakulteId";
            this.txtFakulteId.Size = new System.Drawing.Size(194, 25);
            this.txtFakulteId.TabIndex = 1;
            // 
            // txtFakulteAd
            // 
            this.txtFakulteAd.BackColor = System.Drawing.Color.AliceBlue;
            this.txtFakulteAd.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFakulteAd.Location = new System.Drawing.Point(113, 71);
            this.txtFakulteAd.Name = "txtFakulteAd";
            this.txtFakulteAd.Size = new System.Drawing.Size(194, 25);
            this.txtFakulteAd.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fakültə Ad:";
            // 
            // btnElaveEt
            // 
            this.btnElaveEt.BackColor = System.Drawing.Color.CadetBlue;
            this.btnElaveEt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnElaveEt.Location = new System.Drawing.Point(349, 21);
            this.btnElaveEt.Name = "btnElaveEt";
            this.btnElaveEt.Size = new System.Drawing.Size(145, 31);
            this.btnElaveEt.TabIndex = 4;
            this.btnElaveEt.Text = "Əlavə Et";
            this.btnElaveEt.UseVisualStyleBackColor = false;
            this.btnElaveEt.Click += new System.EventHandler(this.btnElaveEt_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.CadetBlue;
            this.btnSil.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSil.Location = new System.Drawing.Point(349, 68);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(145, 31);
            this.btnSil.TabIndex = 5;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.CadetBlue;
            this.btnGuncelle.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuncelle.Location = new System.Drawing.Point(349, 115);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(145, 31);
            this.btnGuncelle.TabIndex = 6;
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
            this.fakulteIdDataGridViewTextBoxColumn,
            this.fakulteAdDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.fakultelerBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(2, 192);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(514, 221);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // fakulteIdDataGridViewTextBoxColumn
            // 
            this.fakulteIdDataGridViewTextBoxColumn.DataPropertyName = "FakulteId";
            this.fakulteIdDataGridViewTextBoxColumn.HeaderText = "FakulteId";
            this.fakulteIdDataGridViewTextBoxColumn.Name = "fakulteIdDataGridViewTextBoxColumn";
            this.fakulteIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fakulteAdDataGridViewTextBoxColumn
            // 
            this.fakulteAdDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fakulteAdDataGridViewTextBoxColumn.DataPropertyName = "FakulteAd";
            this.fakulteAdDataGridViewTextBoxColumn.HeaderText = "FakulteAd";
            this.fakulteAdDataGridViewTextBoxColumn.Name = "fakulteAdDataGridViewTextBoxColumn";
            // 
            // fakultelerBindingSource
            // 
            this.fakultelerBindingSource.DataMember = "Fakulteler";
            this.fakultelerBindingSource.DataSource = this.telebeYataqxanasiDataSet;
            // 
            // telebeYataqxanasiDataSet
            // 
            this.telebeYataqxanasiDataSet.DataSetName = "TelebeYataqxanasiDataSet";
            this.telebeYataqxanasiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fakultelerTableAdapter
            // 
            this.fakultelerTableAdapter.ClearBeforeFill = true;
            // 
            // frmFakulteler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(516, 411);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnElaveEt);
            this.Controls.Add(this.txtFakulteAd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFakulteId);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmFakulteler";
            this.ShowIcon = false;
            this.Text = "Fakultə";
            this.Load += new System.EventHandler(this.frmFakulteler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fakultelerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.telebeYataqxanasiDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFakulteId;
        private System.Windows.Forms.TextBox txtFakulteAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnElaveEt;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private TelebeYataqxanasiDataSet telebeYataqxanasiDataSet;
        private System.Windows.Forms.BindingSource fakultelerBindingSource;
        private TelebeYataqxanasiDataSetTableAdapters.FakultelerTableAdapter fakultelerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn fakulteIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fakulteAdDataGridViewTextBoxColumn;
    }
}
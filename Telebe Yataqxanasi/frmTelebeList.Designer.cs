
namespace Telebe_Yataqxanasi
{
    partial class frmTelebeList
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tlbIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tlbAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tlbSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tlbTelefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tlbDogumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tlbFakulteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tlbMailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tlbOtaqNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tlbValideynAdSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tlbValideynTelefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tlbAdresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telebeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.telebeYataqxanasiDataSet3 = new Telebe_Yataqxanasi.TelebeYataqxanasiDataSet3();
            this.telebeTableAdapter = new Telebe_Yataqxanasi.TelebeYataqxanasiDataSet3TableAdapters.TelebeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.telebeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.telebeYataqxanasiDataSet3)).BeginInit();
            this.SuspendLayout();
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
            this.tlbTelefonDataGridViewTextBoxColumn,
            this.tlbDogumDataGridViewTextBoxColumn,
            this.tlbFakulteDataGridViewTextBoxColumn,
            this.tlbMailDataGridViewTextBoxColumn,
            this.tlbOtaqNoDataGridViewTextBoxColumn,
            this.tlbValideynAdSoyadDataGridViewTextBoxColumn,
            this.tlbValideynTelefonDataGridViewTextBoxColumn,
            this.tlbAdresDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.telebeBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1143, 450);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // tlbIdDataGridViewTextBoxColumn
            // 
            this.tlbIdDataGridViewTextBoxColumn.DataPropertyName = "TlbId";
            this.tlbIdDataGridViewTextBoxColumn.HeaderText = "TlbId";
            this.tlbIdDataGridViewTextBoxColumn.Name = "tlbIdDataGridViewTextBoxColumn";
            this.tlbIdDataGridViewTextBoxColumn.ReadOnly = true;
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
            // tlbTelefonDataGridViewTextBoxColumn
            // 
            this.tlbTelefonDataGridViewTextBoxColumn.DataPropertyName = "TlbTelefon";
            this.tlbTelefonDataGridViewTextBoxColumn.HeaderText = "TlbTelefon";
            this.tlbTelefonDataGridViewTextBoxColumn.Name = "tlbTelefonDataGridViewTextBoxColumn";
            // 
            // tlbDogumDataGridViewTextBoxColumn
            // 
            this.tlbDogumDataGridViewTextBoxColumn.DataPropertyName = "TlbDogum";
            this.tlbDogumDataGridViewTextBoxColumn.HeaderText = "TlbDogum";
            this.tlbDogumDataGridViewTextBoxColumn.Name = "tlbDogumDataGridViewTextBoxColumn";
            // 
            // tlbFakulteDataGridViewTextBoxColumn
            // 
            this.tlbFakulteDataGridViewTextBoxColumn.DataPropertyName = "TlbFakulte";
            this.tlbFakulteDataGridViewTextBoxColumn.HeaderText = "TlbFakulte";
            this.tlbFakulteDataGridViewTextBoxColumn.Name = "tlbFakulteDataGridViewTextBoxColumn";
            // 
            // tlbMailDataGridViewTextBoxColumn
            // 
            this.tlbMailDataGridViewTextBoxColumn.DataPropertyName = "TlbMail";
            this.tlbMailDataGridViewTextBoxColumn.HeaderText = "TlbMail";
            this.tlbMailDataGridViewTextBoxColumn.Name = "tlbMailDataGridViewTextBoxColumn";
            // 
            // tlbOtaqNoDataGridViewTextBoxColumn
            // 
            this.tlbOtaqNoDataGridViewTextBoxColumn.DataPropertyName = "TlbOtaqNo";
            this.tlbOtaqNoDataGridViewTextBoxColumn.HeaderText = "TlbOtaqNo";
            this.tlbOtaqNoDataGridViewTextBoxColumn.Name = "tlbOtaqNoDataGridViewTextBoxColumn";
            // 
            // tlbValideynAdSoyadDataGridViewTextBoxColumn
            // 
            this.tlbValideynAdSoyadDataGridViewTextBoxColumn.DataPropertyName = "TlbValideynAdSoyad";
            this.tlbValideynAdSoyadDataGridViewTextBoxColumn.HeaderText = "TlbValideynAdSoyad";
            this.tlbValideynAdSoyadDataGridViewTextBoxColumn.Name = "tlbValideynAdSoyadDataGridViewTextBoxColumn";
            // 
            // tlbValideynTelefonDataGridViewTextBoxColumn
            // 
            this.tlbValideynTelefonDataGridViewTextBoxColumn.DataPropertyName = "TlbValideynTelefon";
            this.tlbValideynTelefonDataGridViewTextBoxColumn.HeaderText = "TlbValideynTelefon";
            this.tlbValideynTelefonDataGridViewTextBoxColumn.Name = "tlbValideynTelefonDataGridViewTextBoxColumn";
            // 
            // tlbAdresDataGridViewTextBoxColumn
            // 
            this.tlbAdresDataGridViewTextBoxColumn.DataPropertyName = "TlbAdres";
            this.tlbAdresDataGridViewTextBoxColumn.HeaderText = "TlbAdres";
            this.tlbAdresDataGridViewTextBoxColumn.Name = "tlbAdresDataGridViewTextBoxColumn";
            // 
            // telebeBindingSource
            // 
            this.telebeBindingSource.DataMember = "Telebe";
            this.telebeBindingSource.DataSource = this.telebeYataqxanasiDataSet3;
            // 
            // telebeYataqxanasiDataSet3
            // 
            this.telebeYataqxanasiDataSet3.DataSetName = "TelebeYataqxanasiDataSet3";
            this.telebeYataqxanasiDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // telebeTableAdapter
            // 
            this.telebeTableAdapter.ClearBeforeFill = true;
            // 
            // frmTelebeList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1143, 450);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTelebeList";
            this.ShowIcon = false;
            this.Text = "Tələbə Cədvəli";
            this.Load += new System.EventHandler(this.frmTelebeList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.telebeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.telebeYataqxanasiDataSet3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private TelebeYataqxanasiDataSet3 telebeYataqxanasiDataSet3;
        private System.Windows.Forms.BindingSource telebeBindingSource;
        private TelebeYataqxanasiDataSet3TableAdapters.TelebeTableAdapter telebeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn tlbIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tlbAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tlbSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tlbTelefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tlbDogumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tlbFakulteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tlbMailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tlbOtaqNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tlbValideynAdSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tlbValideynTelefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tlbAdresDataGridViewTextBoxColumn;
    }
}
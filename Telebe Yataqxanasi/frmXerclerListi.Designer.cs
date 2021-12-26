
namespace Telebe_Yataqxanasi
{
    partial class frmXerclerListi
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
            this.odemeIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isiqDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.suDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qazDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.internetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qidaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isciDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.digerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.odemelerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.telebeYataqxanasiDataSet4 = new Telebe_Yataqxanasi.TelebeYataqxanasiDataSet4();
            this.odemelerTableAdapter = new Telebe_Yataqxanasi.TelebeYataqxanasiDataSet4TableAdapters.OdemelerTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.odemelerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.telebeYataqxanasiDataSet4)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.odemeIdDataGridViewTextBoxColumn,
            this.isiqDataGridViewTextBoxColumn,
            this.suDataGridViewTextBoxColumn,
            this.qazDataGridViewTextBoxColumn,
            this.internetDataGridViewTextBoxColumn,
            this.qidaDataGridViewTextBoxColumn,
            this.isciDataGridViewTextBoxColumn,
            this.digerDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.odemelerBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(842, 430);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // odemeIdDataGridViewTextBoxColumn
            // 
            this.odemeIdDataGridViewTextBoxColumn.DataPropertyName = "OdemeId";
            this.odemeIdDataGridViewTextBoxColumn.HeaderText = "OdemeId";
            this.odemeIdDataGridViewTextBoxColumn.Name = "odemeIdDataGridViewTextBoxColumn";
            this.odemeIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // isiqDataGridViewTextBoxColumn
            // 
            this.isiqDataGridViewTextBoxColumn.DataPropertyName = "Isiq";
            this.isiqDataGridViewTextBoxColumn.HeaderText = "Isiq";
            this.isiqDataGridViewTextBoxColumn.Name = "isiqDataGridViewTextBoxColumn";
            // 
            // suDataGridViewTextBoxColumn
            // 
            this.suDataGridViewTextBoxColumn.DataPropertyName = "Su";
            this.suDataGridViewTextBoxColumn.HeaderText = "Su";
            this.suDataGridViewTextBoxColumn.Name = "suDataGridViewTextBoxColumn";
            // 
            // qazDataGridViewTextBoxColumn
            // 
            this.qazDataGridViewTextBoxColumn.DataPropertyName = "Qaz";
            this.qazDataGridViewTextBoxColumn.HeaderText = "Qaz";
            this.qazDataGridViewTextBoxColumn.Name = "qazDataGridViewTextBoxColumn";
            // 
            // internetDataGridViewTextBoxColumn
            // 
            this.internetDataGridViewTextBoxColumn.DataPropertyName = "Internet";
            this.internetDataGridViewTextBoxColumn.HeaderText = "Internet";
            this.internetDataGridViewTextBoxColumn.Name = "internetDataGridViewTextBoxColumn";
            // 
            // qidaDataGridViewTextBoxColumn
            // 
            this.qidaDataGridViewTextBoxColumn.DataPropertyName = "Qida";
            this.qidaDataGridViewTextBoxColumn.HeaderText = "Qida";
            this.qidaDataGridViewTextBoxColumn.Name = "qidaDataGridViewTextBoxColumn";
            // 
            // isciDataGridViewTextBoxColumn
            // 
            this.isciDataGridViewTextBoxColumn.DataPropertyName = "Isci";
            this.isciDataGridViewTextBoxColumn.HeaderText = "Isci";
            this.isciDataGridViewTextBoxColumn.Name = "isciDataGridViewTextBoxColumn";
            // 
            // digerDataGridViewTextBoxColumn
            // 
            this.digerDataGridViewTextBoxColumn.DataPropertyName = "Diger";
            this.digerDataGridViewTextBoxColumn.HeaderText = "Diger";
            this.digerDataGridViewTextBoxColumn.Name = "digerDataGridViewTextBoxColumn";
            // 
            // odemelerBindingSource
            // 
            this.odemelerBindingSource.DataMember = "Odemeler";
            this.odemelerBindingSource.DataSource = this.telebeYataqxanasiDataSet4;
            // 
            // telebeYataqxanasiDataSet4
            // 
            this.telebeYataqxanasiDataSet4.DataSetName = "TelebeYataqxanasiDataSet4";
            this.telebeYataqxanasiDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // odemelerTableAdapter
            // 
            this.odemelerTableAdapter.ClearBeforeFill = true;
            // 
            // frmXerclerListi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(842, 430);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmXerclerListi";
            this.ShowIcon = false;
            this.Text = "Xərc Cədvəli";
            this.Load += new System.EventHandler(this.frmXerclerListi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.odemelerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.telebeYataqxanasiDataSet4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private TelebeYataqxanasiDataSet4 telebeYataqxanasiDataSet4;
        private System.Windows.Forms.BindingSource odemelerBindingSource;
        private TelebeYataqxanasiDataSet4TableAdapters.OdemelerTableAdapter odemelerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn odemeIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn isiqDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn suDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qazDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn internetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qidaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn isciDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn digerDataGridViewTextBoxColumn;
    }
}
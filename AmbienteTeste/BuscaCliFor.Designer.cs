﻿namespace AmbienteTeste
{
    partial class BuscaCliFor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuscaCliFor));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.vieworgBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.viewCliForDataSet = new AmbienteTeste.viewCliForDataSet();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.txtBusca = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAdicionar = new System.Windows.Forms.ToolStripButton();
            this.tsFechar = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.view_orgTableAdapter = new AmbienteTeste.viewCliForDataSetTableAdapters.view_orgTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strieorgDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strimorgDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strcependDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strnumeroendDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strufendDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strcomarcaendDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vieworgBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewCliForDataSet)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.strieorgDataGridViewTextBoxColumn,
            this.strimorgDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn5,
            this.strcependDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn6,
            this.strnumeroendDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn7,
            this.strufendDataGridViewTextBoxColumn,
            this.strcomarcaendDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.vieworgBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 58);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(800, 392);
            this.dataGridView1.TabIndex = 162;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // vieworgBindingSource
            // 
            this.vieworgBindingSource.DataMember = "view_org";
            this.vieworgBindingSource.DataSource = this.viewCliForDataSet;
            // 
            // viewCliForDataSet
            // 
            this.viewCliForDataSet.DataSetName = "viewCliForDataSet";
            this.viewCliForDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = global::AmbienteTeste.Properties.Resources.trash;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.ReadOnly = true;
            this.dataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn2.Width = 50;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.Frozen = true;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::AmbienteTeste.Properties.Resources.edit__1_;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.Width = 50;
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::AmbienteTeste.Properties.Resources.refresh_arrow;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Margin = new System.Windows.Forms.Padding(7, 1, 0, 2);
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 25);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 28);
            // 
            // txtBusca
            // 
            this.txtBusca.Margin = new System.Windows.Forms.Padding(1, 0, 5, 0);
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.Size = new System.Drawing.Size(100, 28);
            this.txtBusca.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBusca_KeyPress);
            this.txtBusca.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBusca_KeyUp);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(164)))), ((int)(((byte)(32)))));
            this.toolStripLabel1.Margin = new System.Windows.Forms.Padding(3, 1, 5, 2);
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(70, 25);
            this.toolStripLabel1.Text = "Pesquise";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 28);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnAdicionar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAdicionar.Image = global::AmbienteTeste.Properties.Resources.add__1_;
            this.btnAdicionar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(23, 25);
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // tsFechar
            // 
            this.tsFechar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsFechar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsFechar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsFechar.ForeColor = System.Drawing.Color.White;
            this.tsFechar.Image = ((System.Drawing.Image)(resources.GetObject("tsFechar.Image")));
            this.tsFechar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsFechar.Name = "tsFechar";
            this.tsFechar.Size = new System.Drawing.Size(60, 25);
            this.tsFechar.Text = "Fechar";
            this.tsFechar.Click += new System.EventHandler(this.tsFechar_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Gray;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsFechar,
            this.btnAdicionar,
            this.toolStripSeparator1,
            this.toolStripLabel1,
            this.txtBusca,
            this.toolStripSeparator2,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 30, 1, 0);
            this.toolStrip1.Size = new System.Drawing.Size(800, 58);
            this.toolStrip1.TabIndex = 161;
            // 
            // view_orgTableAdapter
            // 
            this.view_orgTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "int_id_org";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "str_identificao_org";
            this.dataGridViewTextBoxColumn2.HeaderText = "CPF/CNPJ";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "str_razao_org";
            this.dataGridViewTextBoxColumn3.HeaderText = "Razão Social";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "str_fantasia_org";
            this.dataGridViewTextBoxColumn4.HeaderText = "Nome/Nome Fantasia";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // strieorgDataGridViewTextBoxColumn
            // 
            this.strieorgDataGridViewTextBoxColumn.DataPropertyName = "str_ie_org";
            this.strieorgDataGridViewTextBoxColumn.HeaderText = "Inscrição Estadual";
            this.strieorgDataGridViewTextBoxColumn.Name = "strieorgDataGridViewTextBoxColumn";
            this.strieorgDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // strimorgDataGridViewTextBoxColumn
            // 
            this.strimorgDataGridViewTextBoxColumn.DataPropertyName = "str_im_org";
            this.strimorgDataGridViewTextBoxColumn.HeaderText = "Inscrição Municipal";
            this.strimorgDataGridViewTextBoxColumn.Name = "strimorgDataGridViewTextBoxColumn";
            this.strimorgDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "str_email_mail";
            this.dataGridViewTextBoxColumn5.HeaderText = "E-Mail";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // strcependDataGridViewTextBoxColumn
            // 
            this.strcependDataGridViewTextBoxColumn.DataPropertyName = "str_cep_end";
            this.strcependDataGridViewTextBoxColumn.HeaderText = "CEP";
            this.strcependDataGridViewTextBoxColumn.Name = "strcependDataGridViewTextBoxColumn";
            this.strcependDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "str_logradouro_end";
            this.dataGridViewTextBoxColumn6.HeaderText = "Logradouro";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // strnumeroendDataGridViewTextBoxColumn
            // 
            this.strnumeroendDataGridViewTextBoxColumn.DataPropertyName = "str_numero_end";
            this.strnumeroendDataGridViewTextBoxColumn.HeaderText = "Número";
            this.strnumeroendDataGridViewTextBoxColumn.Name = "strnumeroendDataGridViewTextBoxColumn";
            this.strnumeroendDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "str_bairro_end";
            this.dataGridViewTextBoxColumn7.HeaderText = "Bairro";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // strufendDataGridViewTextBoxColumn
            // 
            this.strufendDataGridViewTextBoxColumn.DataPropertyName = "str_uf_end";
            this.strufendDataGridViewTextBoxColumn.HeaderText = "UF";
            this.strufendDataGridViewTextBoxColumn.Name = "strufendDataGridViewTextBoxColumn";
            this.strufendDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // strcomarcaendDataGridViewTextBoxColumn
            // 
            this.strcomarcaendDataGridViewTextBoxColumn.DataPropertyName = "str_comarca_end";
            this.strcomarcaendDataGridViewTextBoxColumn.HeaderText = "Comarca";
            this.strcomarcaendDataGridViewTextBoxColumn.Name = "strcomarcaendDataGridViewTextBoxColumn";
            this.strcomarcaendDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // BuscaCliFor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BuscaCliFor";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "BuscaCliFor";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.BuscaCliFor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vieworgBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewCliForDataSet)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn intidorgDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stridentificaoorgDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn strrazaoorgDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn strfantasiaorgDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stremailmailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn strlogradouroendDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn strbairroendDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripTextBox txtBusca;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnAdicionar;
        private System.Windows.Forms.ToolStripButton tsFechar;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private viewCliForDataSet viewCliForDataSet;
        private System.Windows.Forms.BindingSource vieworgBindingSource;
        private viewCliForDataSetTableAdapters.view_orgTableAdapter view_orgTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn strieorgDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn strimorgDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn strcependDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn strnumeroendDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn strufendDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn strcomarcaendDataGridViewTextBoxColumn;
    }
}
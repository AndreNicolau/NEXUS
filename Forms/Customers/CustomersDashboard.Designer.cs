namespace NEXUS.Forms
{
    partial class CustomersDashboard
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvClients = new System.Windows.Forms.DataGridView();
            this.btnNewClient = new System.Windows.Forms.Button();
            this.buttonOpenCustomerFile = new System.Windows.Forms.Button();
            this.topPanel = new System.Windows.Forms.Panel();
            this.textBoxSearchValue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).BeginInit();
            this.topPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvClients
            // 
            this.dgvClients.AllowUserToAddRows = false;
            this.dgvClients.AllowUserToDeleteRows = false;
            this.dgvClients.AllowUserToOrderColumns = true;
            this.dgvClients.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black;
            this.dgvClients.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvClients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClients.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvClients.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvClients.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClients.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvClients.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvClients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvClients.Location = new System.Drawing.Point(0, 70);
            this.dgvClients.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvClients.Name = "dgvClients";
            this.dgvClients.ReadOnly = true;
            this.dgvClients.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvClients.RowHeadersVisible = false;
            this.dgvClients.RowHeadersWidth = 51;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Black;
            this.dgvClients.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvClients.RowTemplate.Height = 24;
            this.dgvClients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClients.Size = new System.Drawing.Size(1280, 650);
            this.dgvClients.TabIndex = 0;
            this.dgvClients.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClients_DoubleClick);
            // 
            // btnNewClient
            // 
            this.btnNewClient.BackColor = System.Drawing.Color.Transparent;
            this.btnNewClient.FlatAppearance.BorderSize = 0;
            this.btnNewClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewClient.ForeColor = System.Drawing.Color.Black;
            this.btnNewClient.Image = global::NEXUS.Properties.Resources.user_add_icon_24px;
            this.btnNewClient.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNewClient.Location = new System.Drawing.Point(9, 9);
            this.btnNewClient.Margin = new System.Windows.Forms.Padding(0);
            this.btnNewClient.Name = "btnNewClient";
            this.btnNewClient.Size = new System.Drawing.Size(130, 55);
            this.btnNewClient.TabIndex = 3;
            this.btnNewClient.Text = "Novo cliente";
            this.btnNewClient.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNewClient.UseVisualStyleBackColor = false;
            this.btnNewClient.Click += new System.EventHandler(this.btnNewClient_Click);
            // 
            // buttonOpenCustomerFile
            // 
            this.buttonOpenCustomerFile.BackColor = System.Drawing.Color.Transparent;
            this.buttonOpenCustomerFile.FlatAppearance.BorderSize = 0;
            this.buttonOpenCustomerFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpenCustomerFile.ForeColor = System.Drawing.Color.Black;
            this.buttonOpenCustomerFile.Image = global::NEXUS.Properties.Resources.document_icon_24px;
            this.buttonOpenCustomerFile.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonOpenCustomerFile.Location = new System.Drawing.Point(139, 9);
            this.buttonOpenCustomerFile.Margin = new System.Windows.Forms.Padding(0);
            this.buttonOpenCustomerFile.Name = "buttonOpenCustomerFile";
            this.buttonOpenCustomerFile.Size = new System.Drawing.Size(160, 55);
            this.buttonOpenCustomerFile.TabIndex = 2;
            this.buttonOpenCustomerFile.Text = "Ficha de cliente";
            this.buttonOpenCustomerFile.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonOpenCustomerFile.UseVisualStyleBackColor = false;
            this.buttonOpenCustomerFile.Click += new System.EventHandler(this.buttonOpenCustomerFile_Click);
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.White;
            this.topPanel.Controls.Add(this.textBoxSearchValue);
            this.topPanel.Controls.Add(this.label1);
            this.topPanel.Controls.Add(this.btnNewClient);
            this.topPanel.Controls.Add(this.buttonOpenCustomerFile);
            this.topPanel.Controls.Add(this.buttonRefresh);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1280, 70);
            this.topPanel.TabIndex = 7;
            // 
            // textBoxSearchValue
            // 
            this.textBoxSearchValue.Location = new System.Drawing.Point(522, 21);
            this.textBoxSearchValue.Name = "textBoxSearchValue";
            this.textBoxSearchValue.Size = new System.Drawing.Size(284, 30);
            this.textBoxSearchValue.TabIndex = 6;
            this.textBoxSearchValue.TextChanged += new System.EventHandler(this.textBoxSearchValue_TextChanged);
            // 
            // label1
            // 
            this.label1.Image = global::NEXUS.Properties.Resources.search_icon_24px;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Location = new System.Drawing.Point(402, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 55);
            this.label1.TabIndex = 5;
            this.label1.Text = "Procurar";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.BackColor = System.Drawing.Color.Transparent;
            this.buttonRefresh.FlatAppearance.BorderSize = 0;
            this.buttonRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRefresh.ForeColor = System.Drawing.Color.Black;
            this.buttonRefresh.Image = global::NEXUS.Properties.Resources.refresh_icon_24px;
            this.buttonRefresh.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonRefresh.Location = new System.Drawing.Point(299, 9);
            this.buttonRefresh.Margin = new System.Windows.Forms.Padding(0);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(100, 55);
            this.buttonRefresh.TabIndex = 4;
            this.buttonRefresh.Text = "Atualizar";
            this.buttonRefresh.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonRefresh.UseVisualStyleBackColor = false;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // CustomersDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.dgvClients);
            this.Controls.Add(this.topPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CustomersDashboard";
            this.Text = "CustomersDashboard";
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).EndInit();
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvClients;
        private System.Windows.Forms.Button btnNewClient;
        private System.Windows.Forms.Button buttonOpenCustomerFile;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxSearchValue;
    }
}
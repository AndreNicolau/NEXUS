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
            this.dgvClients = new System.Windows.Forms.DataGridView();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.btnNewClient = new System.Windows.Forms.Button();
            this.buttonOpenCustomerFile = new System.Windows.Forms.Button();
            this.topPanel = new System.Windows.Forms.Panel();
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
            this.dgvClients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClients.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvClients.Location = new System.Drawing.Point(0, 70);
            this.dgvClients.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvClients.Name = "dgvClients";
            this.dgvClients.ReadOnly = true;
            this.dgvClients.RowHeadersWidth = 51;
            this.dgvClients.RowTemplate.Height = 24;
            this.dgvClients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClients.Size = new System.Drawing.Size(1280, 650);
            this.dgvClients.TabIndex = 0;
            // 
            // buttonSearch
            // 
            this.buttonSearch.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonSearch.BackColor = System.Drawing.Color.Transparent;
            this.buttonSearch.FlatAppearance.BorderSize = 0;
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearch.ForeColor = System.Drawing.Color.Black;
            this.buttonSearch.Image = global::NEXUS.Properties.Resources.search_icon_24px;
            this.buttonSearch.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonSearch.Location = new System.Drawing.Point(0, 8);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(0);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(95, 55);
            this.buttonSearch.TabIndex = 1;
            this.buttonSearch.Text = "Procurar";
            this.buttonSearch.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // btnNewClient
            // 
            this.btnNewClient.BackColor = System.Drawing.Color.Transparent;
            this.btnNewClient.FlatAppearance.BorderSize = 0;
            this.btnNewClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewClient.ForeColor = System.Drawing.Color.Black;
            this.btnNewClient.Image = global::NEXUS.Properties.Resources.user_add_icon_24px;
            this.btnNewClient.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNewClient.Location = new System.Drawing.Point(255, 8);
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
            this.buttonOpenCustomerFile.Location = new System.Drawing.Point(95, 8);
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
            this.topPanel.Controls.Add(this.buttonRefresh);
            this.topPanel.Controls.Add(this.buttonSearch);
            this.topPanel.Controls.Add(this.btnNewClient);
            this.topPanel.Controls.Add(this.buttonOpenCustomerFile);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1280, 70);
            this.topPanel.TabIndex = 7;
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.BackColor = System.Drawing.Color.Transparent;
            this.buttonRefresh.FlatAppearance.BorderSize = 0;
            this.buttonRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRefresh.ForeColor = System.Drawing.Color.Black;
            this.buttonRefresh.Image = global::NEXUS.Properties.Resources.refresh_icon_24px;
            this.buttonRefresh.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonRefresh.Location = new System.Drawing.Point(385, 8);
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
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvClients;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button btnNewClient;
        private System.Windows.Forms.Button buttonOpenCustomerFile;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Button buttonRefresh;
    }
}
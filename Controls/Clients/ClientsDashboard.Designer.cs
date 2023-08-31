namespace NEXUS
{
    partial class ClientsDashboard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnNewClient = new System.Windows.Forms.Button();
            this.btnOpenClientFile = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.topPanel = new System.Windows.Forms.Panel();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.dgvClients = new System.Windows.Forms.DataGridView();
            this.topPanel.SuspendLayout();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNewClient
            // 
            this.btnNewClient.BackColor = System.Drawing.Color.Transparent;
            this.btnNewClient.FlatAppearance.BorderSize = 0;
            this.btnNewClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewClient.ForeColor = System.Drawing.Color.Black;
            this.btnNewClient.Image = global::NEXUS.Properties.Resources.user_add_icon_24px;
            this.btnNewClient.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNewClient.Location = new System.Drawing.Point(260, 5);
            this.btnNewClient.Margin = new System.Windows.Forms.Padding(0);
            this.btnNewClient.Name = "btnNewClient";
            this.btnNewClient.Size = new System.Drawing.Size(130, 60);
            this.btnNewClient.TabIndex = 3;
            this.btnNewClient.Text = "Novo cliente";
            this.btnNewClient.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNewClient.UseVisualStyleBackColor = false;
            // 
            // btnOpenClientFile
            // 
            this.btnOpenClientFile.BackColor = System.Drawing.Color.Transparent;
            this.btnOpenClientFile.FlatAppearance.BorderSize = 0;
            this.btnOpenClientFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenClientFile.ForeColor = System.Drawing.Color.Black;
            this.btnOpenClientFile.Image = global::NEXUS.Properties.Resources.document_icon_24px;
            this.btnOpenClientFile.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnOpenClientFile.Location = new System.Drawing.Point(95, 5);
            this.btnOpenClientFile.Margin = new System.Windows.Forms.Padding(0);
            this.btnOpenClientFile.Name = "btnOpenClientFile";
            this.btnOpenClientFile.Size = new System.Drawing.Size(165, 60);
            this.btnOpenClientFile.TabIndex = 2;
            this.btnOpenClientFile.Text = "Ficha de cliente";
            this.btnOpenClientFile.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnOpenClientFile.UseVisualStyleBackColor = false;
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
            this.buttonSearch.Location = new System.Drawing.Point(0, 5);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(0);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(95, 60);
            this.buttonSearch.TabIndex = 1;
            this.buttonSearch.Text = "Procurar";
            this.buttonSearch.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.White;
            this.topPanel.Controls.Add(this.buttonSearch);
            this.topPanel.Controls.Add(this.btnNewClient);
            this.topPanel.Controls.Add(this.btnOpenClientFile);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1280, 70);
            this.topPanel.TabIndex = 5;
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.dgvClients);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 70);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1280, 650);
            this.mainPanel.TabIndex = 6;
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
            this.dgvClients.Location = new System.Drawing.Point(0, 0);
            this.dgvClients.Name = "dgvClients";
            this.dgvClients.RowHeadersWidth = 51;
            this.dgvClients.RowTemplate.Height = 24;
            this.dgvClients.Size = new System.Drawing.Size(1280, 650);
            this.dgvClients.TabIndex = 0;
            // 
            // ClientsDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.topPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ClientsDashboard";
            this.Size = new System.Drawing.Size(1280, 720);
            this.Load += new System.EventHandler(this.Load_Clients);
            this.topPanel.ResumeLayout(false);
            this.mainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button btnNewClient;
        private System.Windows.Forms.Button btnOpenClientFile;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.DataGridView dgvClients;
    }
}

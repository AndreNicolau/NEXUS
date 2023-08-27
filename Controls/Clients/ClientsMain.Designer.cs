namespace NEXUS
{
    partial class ClientsMain
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
            this.dgvClients = new System.Windows.Forms.DataGridView();
            this.btnNewClient = new System.Windows.Forms.Button();
            this.btnOpenClientFile = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvClients
            // 
            this.dgvClients.AllowUserToAddRows = false;
            this.dgvClients.AllowUserToDeleteRows = false;
            this.dgvClients.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvClients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClients.Location = new System.Drawing.Point(340, 0);
            this.dgvClients.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvClients.Name = "dgvClients";
            this.dgvClients.ReadOnly = true;
            this.dgvClients.RowHeadersWidth = 51;
            this.dgvClients.RowTemplate.Height = 24;
            this.dgvClients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClients.Size = new System.Drawing.Size(940, 720);
            this.dgvClients.TabIndex = 4;
            // 
            // btnNewClient
            // 
            this.btnNewClient.Location = new System.Drawing.Point(4, 134);
            this.btnNewClient.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNewClient.Name = "btnNewClient";
            this.btnNewClient.Size = new System.Drawing.Size(326, 36);
            this.btnNewClient.TabIndex = 3;
            this.btnNewClient.Text = "Novo cliente";
            this.btnNewClient.UseVisualStyleBackColor = true;
            // 
            // btnOpenClientFile
            // 
            this.btnOpenClientFile.Location = new System.Drawing.Point(4, 91);
            this.btnOpenClientFile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnOpenClientFile.Name = "btnOpenClientFile";
            this.btnOpenClientFile.Size = new System.Drawing.Size(326, 36);
            this.btnOpenClientFile.TabIndex = 2;
            this.btnOpenClientFile.Text = "Abrir ficha de cliente";
            this.btnOpenClientFile.UseVisualStyleBackColor = true;
            // 
            // buttonSearch
            // 
            this.buttonSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSearch.Location = new System.Drawing.Point(4, 48);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(326, 36);
            this.buttonSearch.TabIndex = 1;
            this.buttonSearch.Text = "Pesquisar";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // ClientsMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.btnOpenClientFile);
            this.Controls.Add(this.btnNewClient);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.dgvClients);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ClientsMain";
            this.Size = new System.Drawing.Size(1280, 720);
            this.Load += new System.EventHandler(this.Clients_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvClients;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button btnNewClient;
        private System.Windows.Forms.Button btnOpenClientFile;
    }
}

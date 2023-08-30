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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.dgvClients.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Green;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DarkGreen;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightGreen;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Green;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClients.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Green;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvClients.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvClients.GridColor = System.Drawing.Color.Green;
            this.dgvClients.Location = new System.Drawing.Point(165, 0);
            this.dgvClients.Margin = new System.Windows.Forms.Padding(0);
            this.dgvClients.Name = "dgvClients";
            this.dgvClients.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Green;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkGreen;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClients.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvClients.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.LightGreen;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Green;
            this.dgvClients.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvClients.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.LightGreen;
            this.dgvClients.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvClients.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Green;
            this.dgvClients.RowTemplate.Height = 24;
            this.dgvClients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClients.Size = new System.Drawing.Size(1115, 720);
            this.dgvClients.TabIndex = 4;
            // 
            // btnNewClient
            // 
            this.btnNewClient.BackColor = System.Drawing.Color.Transparent;
            this.btnNewClient.FlatAppearance.BorderSize = 0;
            this.btnNewClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewClient.ForeColor = System.Drawing.Color.Black;
            this.btnNewClient.Image = global::NEXUS.Properties.Resources.user_add_icon_24px;
            this.btnNewClient.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNewClient.Location = new System.Drawing.Point(0, 134);
            this.btnNewClient.Margin = new System.Windows.Forms.Padding(0);
            this.btnNewClient.Name = "btnNewClient";
            this.btnNewClient.Size = new System.Drawing.Size(165, 57);
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
            this.btnOpenClientFile.Location = new System.Drawing.Point(0, 67);
            this.btnOpenClientFile.Margin = new System.Windows.Forms.Padding(0);
            this.btnOpenClientFile.Name = "btnOpenClientFile";
            this.btnOpenClientFile.Size = new System.Drawing.Size(165, 57);
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
            this.buttonSearch.Location = new System.Drawing.Point(0, 0);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(0);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(165, 57);
            this.buttonSearch.TabIndex = 1;
            this.buttonSearch.Text = "Procurar";
            this.buttonSearch.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // ClientsDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.btnOpenClientFile);
            this.Controls.Add(this.btnNewClient);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.dgvClients);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ClientsDashboard";
            this.Size = new System.Drawing.Size(1280, 720);
            this.Load += new System.EventHandler(this.Load_Clients);
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

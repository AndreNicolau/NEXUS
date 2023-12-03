namespace NEXUS
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.sidePanel = new System.Windows.Forms.Panel();
            this.buttonEquipments = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonTickets = new System.Windows.Forms.Button();
            this.buttonClients = new System.Windows.Forms.Button();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.sidePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidePanel
            // 
            this.sidePanel.AutoSize = true;
            this.sidePanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.sidePanel.BackColor = System.Drawing.SystemColors.Control;
            this.sidePanel.Controls.Add(this.buttonEquipments);
            this.sidePanel.Controls.Add(this.buttonExit);
            this.sidePanel.Controls.Add(this.buttonTickets);
            this.sidePanel.Controls.Add(this.buttonClients);
            this.sidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidePanel.Location = new System.Drawing.Point(0, 0);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(98, 720);
            this.sidePanel.TabIndex = 40;
            // 
            // buttonEquipments
            // 
            this.buttonEquipments.BackColor = System.Drawing.Color.Transparent;
            this.buttonEquipments.FlatAppearance.BorderSize = 0;
            this.buttonEquipments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEquipments.Image = global::NEXUS.Properties.Resources.devices_icon_64px;
            this.buttonEquipments.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonEquipments.Location = new System.Drawing.Point(0, 134);
            this.buttonEquipments.Margin = new System.Windows.Forms.Padding(0);
            this.buttonEquipments.Name = "buttonEquipments";
            this.buttonEquipments.Size = new System.Drawing.Size(98, 124);
            this.buttonEquipments.TabIndex = 36;
            this.buttonEquipments.Text = "Equipamentos";
            this.buttonEquipments.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonEquipments.UseVisualStyleBackColor = false;
            this.buttonEquipments.Click += new System.EventHandler(this.buttonEquipments_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.Transparent;
            this.buttonExit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonExit.FlatAppearance.BorderSize = 0;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Image = global::NEXUS.Properties.Resources.sign_out_icon_32px;
            this.buttonExit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonExit.Location = new System.Drawing.Point(0, 653);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(98, 67);
            this.buttonExit.TabIndex = 35;
            this.buttonExit.Text = "Sair";
            this.buttonExit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.ExitApplication);
            // 
            // buttonTickets
            // 
            this.buttonTickets.BackColor = System.Drawing.Color.Transparent;
            this.buttonTickets.FlatAppearance.BorderSize = 0;
            this.buttonTickets.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTickets.Image = global::NEXUS.Properties.Resources.memo_icon_32px;
            this.buttonTickets.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonTickets.Location = new System.Drawing.Point(0, 67);
            this.buttonTickets.Margin = new System.Windows.Forms.Padding(0);
            this.buttonTickets.Name = "buttonTickets";
            this.buttonTickets.Size = new System.Drawing.Size(98, 67);
            this.buttonTickets.TabIndex = 34;
            this.buttonTickets.Text = "Tickets";
            this.buttonTickets.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonTickets.UseVisualStyleBackColor = false;
            this.buttonTickets.Click += new System.EventHandler(this.buttonTickets_Click);
            // 
            // buttonClients
            // 
            this.buttonClients.BackColor = System.Drawing.Color.Transparent;
            this.buttonClients.FlatAppearance.BorderSize = 0;
            this.buttonClients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClients.Image = global::NEXUS.Properties.Resources.user_icon_32px;
            this.buttonClients.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonClients.Location = new System.Drawing.Point(0, 0);
            this.buttonClients.Margin = new System.Windows.Forms.Padding(0);
            this.buttonClients.Name = "buttonClients";
            this.buttonClients.Size = new System.Drawing.Size(98, 67);
            this.buttonClients.TabIndex = 33;
            this.buttonClients.Text = "Clientes";
            this.buttonClients.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonClients.UseVisualStyleBackColor = false;
            this.buttonClients.Click += new System.EventHandler(this.buttonClients_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.White;
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(98, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1182, 720);
            this.mainPanel.TabIndex = 41;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.sidePanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Dashboard_FormClosed);
            this.sidePanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel sidePanel;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Button buttonClients;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonTickets;
        private System.Windows.Forms.Button buttonEquipments;
    }
}
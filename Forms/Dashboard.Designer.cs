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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonTicketsClosed = new System.Windows.Forms.Button();
            this.buttonTicketsOpened = new System.Windows.Forms.Button();
            this.buttonTicketsNew = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonShutdown = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonClientsSearch = new System.Windows.Forms.Button();
            this.buttonClientsNew = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.buttonClientsGeneral = new System.Windows.Forms.Button();
            this.buttonTicketsGeneral = new System.Windows.Forms.Button();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 28);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(0, 0);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Clientes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 3);
            this.label2.Margin = new System.Windows.Forms.Padding(3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Aplicação";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 3);
            this.label3.Margin = new System.Windows.Forms.Padding(3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "Tickets";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.Color.LightBlue;
            this.panel1.Controls.Add(this.buttonTicketsGeneral);
            this.panel1.Controls.Add(this.buttonTicketsClosed);
            this.panel1.Controls.Add(this.buttonTicketsOpened);
            this.panel1.Controls.Add(this.buttonTicketsNew);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(0, 144);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(158, 171);
            this.panel1.TabIndex = 12;
            // 
            // buttonTicketsClosed
            // 
            this.buttonTicketsClosed.BackColor = System.Drawing.Color.Blue;
            this.buttonTicketsClosed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTicketsClosed.ForeColor = System.Drawing.Color.White;
            this.buttonTicketsClosed.Location = new System.Drawing.Point(5, 138);
            this.buttonTicketsClosed.Name = "buttonTicketsClosed";
            this.buttonTicketsClosed.Size = new System.Drawing.Size(150, 30);
            this.buttonTicketsClosed.TabIndex = 19;
            this.buttonTicketsClosed.Text = "Fechados";
            this.buttonTicketsClosed.UseVisualStyleBackColor = false;
            // 
            // buttonTicketsOpened
            // 
            this.buttonTicketsOpened.BackColor = System.Drawing.Color.Blue;
            this.buttonTicketsOpened.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTicketsOpened.ForeColor = System.Drawing.Color.White;
            this.buttonTicketsOpened.Location = new System.Drawing.Point(5, 103);
            this.buttonTicketsOpened.Name = "buttonTicketsOpened";
            this.buttonTicketsOpened.Size = new System.Drawing.Size(150, 30);
            this.buttonTicketsOpened.TabIndex = 18;
            this.buttonTicketsOpened.Text = "Abertos";
            this.buttonTicketsOpened.UseVisualStyleBackColor = false;
            // 
            // buttonTicketsNew
            // 
            this.buttonTicketsNew.BackColor = System.Drawing.Color.Blue;
            this.buttonTicketsNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTicketsNew.ForeColor = System.Drawing.Color.White;
            this.buttonTicketsNew.Location = new System.Drawing.Point(5, 68);
            this.buttonTicketsNew.Name = "buttonTicketsNew";
            this.buttonTicketsNew.Size = new System.Drawing.Size(150, 30);
            this.buttonTicketsNew.TabIndex = 17;
            this.buttonTicketsNew.Text = "Novo";
            this.buttonTicketsNew.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.AutoSize = true;
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.BackColor = System.Drawing.Color.Bisque;
            this.panel2.Controls.Add(this.buttonShutdown);
            this.panel2.Controls.Add(this.buttonExit);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(0, 323);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(156, 103);
            this.panel2.TabIndex = 13;
            // 
            // buttonShutdown
            // 
            this.buttonShutdown.BackColor = System.Drawing.Color.Orange;
            this.buttonShutdown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonShutdown.ForeColor = System.Drawing.Color.White;
            this.buttonShutdown.Location = new System.Drawing.Point(3, 70);
            this.buttonShutdown.Name = "buttonShutdown";
            this.buttonShutdown.Size = new System.Drawing.Size(150, 30);
            this.buttonShutdown.TabIndex = 19;
            this.buttonShutdown.Text = "Encerrar";
            this.buttonShutdown.UseVisualStyleBackColor = false;
            this.buttonShutdown.Click += new System.EventHandler(this.ShutdownApplication);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.Orange;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.ForeColor = System.Drawing.Color.White;
            this.buttonExit.Location = new System.Drawing.Point(3, 34);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(150, 30);
            this.buttonExit.TabIndex = 18;
            this.buttonExit.Text = "Sair";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.ExitApplication);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.AutoSize = true;
            this.panel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel3.BackColor = System.Drawing.Color.LightGreen;
            this.panel3.Controls.Add(this.buttonClientsGeneral);
            this.panel3.Controls.Add(this.buttonClientsSearch);
            this.panel3.Controls.Add(this.buttonClientsNew);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.flowLayoutPanel1);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(156, 136);
            this.panel3.TabIndex = 14;
            // 
            // buttonClientsSearch
            // 
            this.buttonClientsSearch.BackColor = System.Drawing.Color.Green;
            this.buttonClientsSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClientsSearch.ForeColor = System.Drawing.Color.White;
            this.buttonClientsSearch.Location = new System.Drawing.Point(3, 103);
            this.buttonClientsSearch.Name = "buttonClientsSearch";
            this.buttonClientsSearch.Size = new System.Drawing.Size(150, 30);
            this.buttonClientsSearch.TabIndex = 16;
            this.buttonClientsSearch.Text = "Procurar";
            this.buttonClientsSearch.UseVisualStyleBackColor = false;
            // 
            // buttonClientsNew
            // 
            this.buttonClientsNew.BackColor = System.Drawing.Color.Green;
            this.buttonClientsNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClientsNew.ForeColor = System.Drawing.Color.White;
            this.buttonClientsNew.Location = new System.Drawing.Point(3, 68);
            this.buttonClientsNew.Name = "buttonClientsNew";
            this.buttonClientsNew.Size = new System.Drawing.Size(150, 30);
            this.buttonClientsNew.TabIndex = 15;
            this.buttonClientsNew.Text = "Novo";
            this.buttonClientsNew.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            this.panel4.AutoSize = true;
            this.panel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel4.Controls.Add(this.panel1);
            this.panel4.Controls.Add(this.panel2);
            this.panel4.Controls.Add(this.panel3);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(158, 600);
            this.panel4.TabIndex = 15;
            // 
            // buttonClientsGeneral
            // 
            this.buttonClientsGeneral.BackColor = System.Drawing.Color.Green;
            this.buttonClientsGeneral.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClientsGeneral.ForeColor = System.Drawing.Color.White;
            this.buttonClientsGeneral.Location = new System.Drawing.Point(3, 33);
            this.buttonClientsGeneral.Name = "buttonClientsGeneral";
            this.buttonClientsGeneral.Size = new System.Drawing.Size(150, 30);
            this.buttonClientsGeneral.TabIndex = 17;
            this.buttonClientsGeneral.Text = "Geral";
            this.buttonClientsGeneral.UseVisualStyleBackColor = false;
            // 
            // buttonTicketsGeneral
            // 
            this.buttonTicketsGeneral.BackColor = System.Drawing.Color.Blue;
            this.buttonTicketsGeneral.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTicketsGeneral.ForeColor = System.Drawing.Color.White;
            this.buttonTicketsGeneral.Location = new System.Drawing.Point(4, 33);
            this.buttonTicketsGeneral.Name = "buttonTicketsGeneral";
            this.buttonTicketsGeneral.Size = new System.Drawing.Size(150, 30);
            this.buttonTicketsGeneral.TabIndex = 20;
            this.buttonTicketsGeneral.Text = "Geral";
            this.buttonTicketsGeneral.UseVisualStyleBackColor = false;
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(158, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1042, 600);
            this.mainPanel.TabIndex = 16;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1200, 600);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.panel4);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button buttonClientsSearch;
        private System.Windows.Forms.Button buttonClientsNew;
        private System.Windows.Forms.Button buttonTicketsClosed;
        private System.Windows.Forms.Button buttonTicketsOpened;
        private System.Windows.Forms.Button buttonTicketsNew;
        private System.Windows.Forms.Button buttonShutdown;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonTicketsGeneral;
        private System.Windows.Forms.Button buttonClientsGeneral;
        private System.Windows.Forms.Panel mainPanel;
    }
}
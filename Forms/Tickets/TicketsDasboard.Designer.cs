namespace NEXUS.Forms.Tickets
{
    partial class TicketsDasboard
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            this.topPanel = new System.Windows.Forms.Panel();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.radioButtonOpened = new System.Windows.Forms.RadioButton();
            this.buttonNewTicket = new System.Windows.Forms.Button();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.dataGridViewTickets = new System.Windows.Forms.DataGridView();
            this.radioButtonClosedTickets = new System.Windows.Forms.RadioButton();
            this.topPanel.SuspendLayout();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTickets)).BeginInit();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.White;
            this.topPanel.Controls.Add(this.radioButtonClosedTickets);
            this.topPanel.Controls.Add(this.buttonRefresh);
            this.topPanel.Controls.Add(this.radioButtonOpened);
            this.topPanel.Controls.Add(this.buttonNewTicket);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1200, 70);
            this.topPanel.TabIndex = 0;
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.BackColor = System.Drawing.Color.Transparent;
            this.buttonRefresh.FlatAppearance.BorderSize = 0;
            this.buttonRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRefresh.ForeColor = System.Drawing.Color.Black;
            this.buttonRefresh.Image = global::NEXUS.Properties.Resources.refresh_icon_24px;
            this.buttonRefresh.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonRefresh.Location = new System.Drawing.Point(290, 9);
            this.buttonRefresh.Margin = new System.Windows.Forms.Padding(0);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(100, 55);
            this.buttonRefresh.TabIndex = 5;
            this.buttonRefresh.Text = "Atualizar";
            this.buttonRefresh.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonRefresh.UseVisualStyleBackColor = false;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // radioButtonOpened
            // 
            this.radioButtonOpened.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonOpened.Checked = true;
            this.radioButtonOpened.FlatAppearance.BorderSize = 0;
            this.radioButtonOpened.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButtonOpened.Image = global::NEXUS.Properties.Resources.document_icon_24px;
            this.radioButtonOpened.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.radioButtonOpened.Location = new System.Drawing.Point(78, 5);
            this.radioButtonOpened.Margin = new System.Windows.Forms.Padding(0);
            this.radioButtonOpened.Name = "radioButtonOpened";
            this.radioButtonOpened.Size = new System.Drawing.Size(95, 60);
            this.radioButtonOpened.TabIndex = 1;
            this.radioButtonOpened.TabStop = true;
            this.radioButtonOpened.Text = "Abertos";
            this.radioButtonOpened.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.radioButtonOpened.UseVisualStyleBackColor = true;
            this.radioButtonOpened.CheckedChanged += new System.EventHandler(this.radioButtonOpened_CheckedChanged);
            // 
            // buttonNewTicket
            // 
            this.buttonNewTicket.FlatAppearance.BorderSize = 0;
            this.buttonNewTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNewTicket.Image = global::NEXUS.Properties.Resources.add_icon_24px;
            this.buttonNewTicket.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonNewTicket.Location = new System.Drawing.Point(0, 5);
            this.buttonNewTicket.Margin = new System.Windows.Forms.Padding(0);
            this.buttonNewTicket.Name = "buttonNewTicket";
            this.buttonNewTicket.Size = new System.Drawing.Size(75, 60);
            this.buttonNewTicket.TabIndex = 0;
            this.buttonNewTicket.Text = "Novo";
            this.buttonNewTicket.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonNewTicket.UseVisualStyleBackColor = true;
            this.buttonNewTicket.Click += new System.EventHandler(this.buttonNewTicket_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.dataGridViewTickets);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 70);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1200, 633);
            this.mainPanel.TabIndex = 1;
            // 
            // dataGridViewTickets
            // 
            this.dataGridViewTickets.AllowUserToAddRows = false;
            this.dataGridViewTickets.AllowUserToDeleteRows = false;
            this.dataGridViewTickets.AllowUserToOrderColumns = true;
            this.dataGridViewTickets.AllowUserToResizeRows = false;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.Black;
            this.dataGridViewTickets.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dataGridViewTickets.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewTickets.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewTickets.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTickets.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dataGridViewTickets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTickets.DefaultCellStyle = dataGridViewCellStyle18;
            this.dataGridViewTickets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewTickets.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewTickets.Name = "dataGridViewTickets";
            this.dataGridViewTickets.ReadOnly = true;
            this.dataGridViewTickets.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTickets.RowHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.dataGridViewTickets.RowHeadersVisible = false;
            this.dataGridViewTickets.RowHeadersWidth = 51;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.Black;
            this.dataGridViewTickets.RowsDefaultCellStyle = dataGridViewCellStyle20;
            this.dataGridViewTickets.RowTemplate.Height = 24;
            this.dataGridViewTickets.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTickets.Size = new System.Drawing.Size(1200, 633);
            this.dataGridViewTickets.TabIndex = 0;
            this.dataGridViewTickets.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OverviewTicket);
            // 
            // radioButtonClosedTickets
            // 
            this.radioButtonClosedTickets.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonClosedTickets.FlatAppearance.BorderSize = 0;
            this.radioButtonClosedTickets.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButtonClosedTickets.Image = global::NEXUS.Properties.Resources.clear_icon_24px;
            this.radioButtonClosedTickets.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.radioButtonClosedTickets.Location = new System.Drawing.Point(173, 4);
            this.radioButtonClosedTickets.Margin = new System.Windows.Forms.Padding(0);
            this.radioButtonClosedTickets.Name = "radioButtonClosedTickets";
            this.radioButtonClosedTickets.Size = new System.Drawing.Size(117, 60);
            this.radioButtonClosedTickets.TabIndex = 6;
            this.radioButtonClosedTickets.Text = "Fechados";
            this.radioButtonClosedTickets.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.radioButtonClosedTickets.UseVisualStyleBackColor = true;
            this.radioButtonClosedTickets.CheckedChanged += new System.EventHandler(this.radioButtonClosedTickets_CheckedChanged);
            // 
            // TicketsDasboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1200, 703);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.topPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "TicketsDasboard";
            this.Text = "TicketsDashboard";
            this.topPanel.ResumeLayout(false);
            this.mainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTickets)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Button buttonNewTicket;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.RadioButton radioButtonOpened;
        private System.Windows.Forms.DataGridView dataGridViewTickets;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.RadioButton radioButtonClosedTickets;
    }
}
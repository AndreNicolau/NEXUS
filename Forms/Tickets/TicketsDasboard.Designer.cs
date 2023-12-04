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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.topPanel = new System.Windows.Forms.Panel();
            this.textBoxSearchValue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonOpenedTickets = new System.Windows.Forms.Button();
            this.buttonClosedTickets = new System.Windows.Forms.Button();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.buttonNewTicket = new System.Windows.Forms.Button();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.dataGridViewTickets = new System.Windows.Forms.DataGridView();
            this.topPanel.SuspendLayout();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTickets)).BeginInit();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.White;
            this.topPanel.Controls.Add(this.textBoxSearchValue);
            this.topPanel.Controls.Add(this.label1);
            this.topPanel.Controls.Add(this.buttonOpenedTickets);
            this.topPanel.Controls.Add(this.buttonClosedTickets);
            this.topPanel.Controls.Add(this.buttonRefresh);
            this.topPanel.Controls.Add(this.buttonNewTicket);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1200, 70);
            this.topPanel.TabIndex = 0;
            // 
            // textBoxSearchValue
            // 
            this.textBoxSearchValue.Location = new System.Drawing.Point(501, 21);
            this.textBoxSearchValue.Name = "textBoxSearchValue";
            this.textBoxSearchValue.Size = new System.Drawing.Size(284, 30);
            this.textBoxSearchValue.TabIndex = 10;
            this.textBoxSearchValue.TextChanged += new System.EventHandler(this.textBoxSearchValue_TextChanged);
            // 
            // label1
            // 
            this.label1.Image = global::NEXUS.Properties.Resources.search_icon_24px;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Location = new System.Drawing.Point(386, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 55);
            this.label1.TabIndex = 9;
            this.label1.Text = "Procurar";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonOpenedTickets
            // 
            this.buttonOpenedTickets.BackColor = System.Drawing.Color.Transparent;
            this.buttonOpenedTickets.FlatAppearance.BorderSize = 0;
            this.buttonOpenedTickets.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpenedTickets.ForeColor = System.Drawing.Color.Black;
            this.buttonOpenedTickets.Image = global::NEXUS.Properties.Resources.document_icon_24px;
            this.buttonOpenedTickets.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonOpenedTickets.Location = new System.Drawing.Point(76, 9);
            this.buttonOpenedTickets.Margin = new System.Windows.Forms.Padding(0);
            this.buttonOpenedTickets.Name = "buttonOpenedTickets";
            this.buttonOpenedTickets.Size = new System.Drawing.Size(89, 55);
            this.buttonOpenedTickets.TabIndex = 8;
            this.buttonOpenedTickets.Text = "Abertos";
            this.buttonOpenedTickets.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonOpenedTickets.UseVisualStyleBackColor = false;
            this.buttonOpenedTickets.Click += new System.EventHandler(this.buttonOpenedTickets_Click);
            // 
            // buttonClosedTickets
            // 
            this.buttonClosedTickets.BackColor = System.Drawing.Color.Transparent;
            this.buttonClosedTickets.FlatAppearance.BorderSize = 0;
            this.buttonClosedTickets.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClosedTickets.ForeColor = System.Drawing.Color.Black;
            this.buttonClosedTickets.Image = global::NEXUS.Properties.Resources.clear_icon_24px;
            this.buttonClosedTickets.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonClosedTickets.Location = new System.Drawing.Point(166, 9);
            this.buttonClosedTickets.Margin = new System.Windows.Forms.Padding(0);
            this.buttonClosedTickets.Name = "buttonClosedTickets";
            this.buttonClosedTickets.Size = new System.Drawing.Size(118, 55);
            this.buttonClosedTickets.TabIndex = 7;
            this.buttonClosedTickets.Text = "Fechados";
            this.buttonClosedTickets.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonClosedTickets.UseVisualStyleBackColor = false;
            this.buttonClosedTickets.Click += new System.EventHandler(this.buttonClosedTickets_Click);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.BackColor = System.Drawing.Color.Transparent;
            this.buttonRefresh.FlatAppearance.BorderSize = 0;
            this.buttonRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRefresh.ForeColor = System.Drawing.Color.Black;
            this.buttonRefresh.Image = global::NEXUS.Properties.Resources.refresh_icon_24px;
            this.buttonRefresh.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonRefresh.Location = new System.Drawing.Point(285, 9);
            this.buttonRefresh.Margin = new System.Windows.Forms.Padding(0);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(100, 55);
            this.buttonRefresh.TabIndex = 5;
            this.buttonRefresh.Text = "Atualizar";
            this.buttonRefresh.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonRefresh.UseVisualStyleBackColor = false;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // buttonNewTicket
            // 
            this.buttonNewTicket.FlatAppearance.BorderSize = 0;
            this.buttonNewTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNewTicket.Image = global::NEXUS.Properties.Resources.add_icon_24px;
            this.buttonNewTicket.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonNewTicket.Location = new System.Drawing.Point(0, 6);
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
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black;
            this.dataGridViewTickets.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTickets.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewTickets.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewTickets.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTickets.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTickets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTickets.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewTickets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewTickets.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewTickets.Name = "dataGridViewTickets";
            this.dataGridViewTickets.ReadOnly = true;
            this.dataGridViewTickets.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTickets.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewTickets.RowHeadersVisible = false;
            this.dataGridViewTickets.RowHeadersWidth = 51;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Black;
            this.dataGridViewTickets.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewTickets.RowTemplate.Height = 24;
            this.dataGridViewTickets.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTickets.Size = new System.Drawing.Size(1200, 633);
            this.dataGridViewTickets.TabIndex = 0;
            this.dataGridViewTickets.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTickets_DoubleClick);
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
            this.topPanel.PerformLayout();
            this.mainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTickets)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Button buttonNewTicket;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.DataGridView dataGridViewTickets;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Button buttonClosedTickets;
        private System.Windows.Forms.Button buttonOpenedTickets;
        private System.Windows.Forms.TextBox textBoxSearchValue;
        private System.Windows.Forms.Label label1;
    }
}
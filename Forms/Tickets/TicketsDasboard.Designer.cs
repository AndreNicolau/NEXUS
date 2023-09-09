﻿namespace NEXUS.Forms.Tickets
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
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.radioButtonOpened = new System.Windows.Forms.RadioButton();
            this.buttonNewTicket = new System.Windows.Forms.Button();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.dgvtickets = new System.Windows.Forms.DataGridView();
            this.topPanel.SuspendLayout();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtickets)).BeginInit();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.White;
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
            this.buttonRefresh.Location = new System.Drawing.Point(176, 8);
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
            this.mainPanel.Controls.Add(this.dgvtickets);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 70);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1200, 633);
            this.mainPanel.TabIndex = 1;
            // 
            // dgvtickets
            // 
            this.dgvtickets.AllowUserToAddRows = false;
            this.dgvtickets.AllowUserToDeleteRows = false;
            this.dgvtickets.AllowUserToOrderColumns = true;
            this.dgvtickets.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black;
            this.dgvtickets.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvtickets.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvtickets.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvtickets.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvtickets.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvtickets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvtickets.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvtickets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvtickets.Location = new System.Drawing.Point(0, 0);
            this.dgvtickets.Name = "dgvtickets";
            this.dgvtickets.ReadOnly = true;
            this.dgvtickets.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvtickets.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvtickets.RowHeadersVisible = false;
            this.dgvtickets.RowHeadersWidth = 51;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Black;
            this.dgvtickets.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvtickets.RowTemplate.Height = 24;
            this.dgvtickets.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvtickets.Size = new System.Drawing.Size(1200, 633);
            this.dgvtickets.TabIndex = 0;
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvtickets)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Button buttonNewTicket;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.RadioButton radioButtonOpened;
        private System.Windows.Forms.DataGridView dgvtickets;
        private System.Windows.Forms.Button buttonRefresh;
    }
}
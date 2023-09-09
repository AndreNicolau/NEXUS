﻿namespace NEXUS.Forms.Tickets
{
    partial class RegisterNewTicket
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterNewTicket));
            this.panelTop = new System.Windows.Forms.Panel();
            this.buttonRmoveCustomer = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonAssociateCustomer = new System.Windows.Forms.Button();
            this.buttonInsertCustomer = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.labelDate = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelAssociatedCustomer = new System.Windows.Forms.Label();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.SystemColors.Control;
            this.panelTop.Controls.Add(this.buttonRmoveCustomer);
            this.panelTop.Controls.Add(this.label2);
            this.panelTop.Controls.Add(this.buttonAssociateCustomer);
            this.panelTop.Controls.Add(this.buttonInsertCustomer);
            this.panelTop.Controls.Add(this.buttonClose);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1262, 70);
            this.panelTop.TabIndex = 0;
            // 
            // buttonRmoveCustomer
            // 
            this.buttonRmoveCustomer.FlatAppearance.BorderSize = 0;
            this.buttonRmoveCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRmoveCustomer.Image = ((System.Drawing.Image)(resources.GetObject("buttonRmoveCustomer.Image")));
            this.buttonRmoveCustomer.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonRmoveCustomer.Location = new System.Drawing.Point(355, 5);
            this.buttonRmoveCustomer.Margin = new System.Windows.Forms.Padding(0);
            this.buttonRmoveCustomer.Name = "buttonRmoveCustomer";
            this.buttonRmoveCustomer.Size = new System.Drawing.Size(160, 60);
            this.buttonRmoveCustomer.TabIndex = 15;
            this.buttonRmoveCustomer.Text = "Remover cliente";
            this.buttonRmoveCustomer.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonRmoveCustomer.UseVisualStyleBackColor = true;
            this.buttonRmoveCustomer.Click += new System.EventHandler(this.buttonRmoveCustomer_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1130, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 29);
            this.label2.TabIndex = 14;
            this.label2.Text = "Abir ticket";
            // 
            // buttonAssociateCustomer
            // 
            this.buttonAssociateCustomer.FlatAppearance.BorderSize = 0;
            this.buttonAssociateCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAssociateCustomer.Image = global::NEXUS.Properties.Resources.user_add_icon_24px;
            this.buttonAssociateCustomer.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonAssociateCustomer.Location = new System.Drawing.Point(195, 5);
            this.buttonAssociateCustomer.Margin = new System.Windows.Forms.Padding(0);
            this.buttonAssociateCustomer.Name = "buttonAssociateCustomer";
            this.buttonAssociateCustomer.Size = new System.Drawing.Size(160, 60);
            this.buttonAssociateCustomer.TabIndex = 4;
            this.buttonAssociateCustomer.Text = "Associar cliente";
            this.buttonAssociateCustomer.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonAssociateCustomer.UseVisualStyleBackColor = true;
            this.buttonAssociateCustomer.Click += new System.EventHandler(this.buttonAssociateCustomer_Click);
            // 
            // buttonInsertCustomer
            // 
            this.buttonInsertCustomer.FlatAppearance.BorderSize = 0;
            this.buttonInsertCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInsertCustomer.Image = global::NEXUS.Properties.Resources.assept_document_icon_24px1;
            this.buttonInsertCustomer.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonInsertCustomer.Location = new System.Drawing.Point(0, 5);
            this.buttonInsertCustomer.Margin = new System.Windows.Forms.Padding(0);
            this.buttonInsertCustomer.Name = "buttonInsertCustomer";
            this.buttonInsertCustomer.Size = new System.Drawing.Size(85, 60);
            this.buttonInsertCustomer.TabIndex = 12;
            this.buttonInsertCustomer.Text = "Inserir";
            this.buttonInsertCustomer.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonInsertCustomer.UseVisualStyleBackColor = true;
            this.buttonInsertCustomer.Click += new System.EventHandler(this.buttonInsertCustomer_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Image = global::NEXUS.Properties.Resources.circle_close_icon_24px;
            this.buttonClose.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonClose.Location = new System.Drawing.Point(90, 5);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(0);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(100, 60);
            this.buttonClose.TabIndex = 13;
            this.buttonClose.Text = "Cancelar";
            this.buttonClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(12, 76);
            this.labelDate.Margin = new System.Windows.Forms.Padding(3);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(164, 25);
            this.labelDate.TabIndex = 1;
            this.labelDate.Text = "Data: 2023/12/31";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.Location = new System.Drawing.Point(12, 163);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(1224, 213);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Descrição";
            // 
            // labelAssociatedCustomer
            // 
            this.labelAssociatedCustomer.AutoSize = true;
            this.labelAssociatedCustomer.Location = new System.Drawing.Point(12, 107);
            this.labelAssociatedCustomer.Margin = new System.Windows.Forms.Padding(3);
            this.labelAssociatedCustomer.Name = "labelAssociatedCustomer";
            this.labelAssociatedCustomer.Size = new System.Drawing.Size(407, 25);
            this.labelAssociatedCustomer.TabIndex = 4;
            this.labelAssociatedCustomer.Text = "Cliente associado: Nenhum cliente associado";
            // 
            // RegisterNewTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.labelAssociatedCustomer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.panelTop);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "RegisterNewTicket";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterNewTicket";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Button buttonInsertCustomer;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAssociateCustomer;
        private System.Windows.Forms.Label labelAssociatedCustomer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonRmoveCustomer;
    }
}
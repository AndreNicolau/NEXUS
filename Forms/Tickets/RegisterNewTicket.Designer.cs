namespace NEXUS.Forms.Tickets
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
            this.buttonInsertTicket = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.labelDate = new System.Windows.Forms.Label();
            this.richTextBoxDescription = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelAssociatedCustomer = new System.Windows.Forms.Label();
            this.comboBoxEquipment = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxBrand = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxModel = new System.Windows.Forms.ComboBox();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.SystemColors.Control;
            this.panelTop.Controls.Add(this.buttonRmoveCustomer);
            this.panelTop.Controls.Add(this.label2);
            this.panelTop.Controls.Add(this.buttonAssociateCustomer);
            this.panelTop.Controls.Add(this.buttonInsertTicket);
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
            // buttonInsertTicket
            // 
            this.buttonInsertTicket.FlatAppearance.BorderSize = 0;
            this.buttonInsertTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInsertTicket.Image = global::NEXUS.Properties.Resources.assept_document_icon_24px1;
            this.buttonInsertTicket.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonInsertTicket.Location = new System.Drawing.Point(0, 5);
            this.buttonInsertTicket.Margin = new System.Windows.Forms.Padding(0);
            this.buttonInsertTicket.Name = "buttonInsertTicket";
            this.buttonInsertTicket.Size = new System.Drawing.Size(85, 60);
            this.buttonInsertTicket.TabIndex = 12;
            this.buttonInsertTicket.Text = "Inserir";
            this.buttonInsertTicket.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonInsertTicket.UseVisualStyleBackColor = true;
            this.buttonInsertTicket.Click += new System.EventHandler(this.buttonInsertTicket_Click);
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
            // richTextBoxDescription
            // 
            this.richTextBoxDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxDescription.Location = new System.Drawing.Point(12, 211);
            this.richTextBoxDescription.Name = "richTextBoxDescription";
            this.richTextBoxDescription.Size = new System.Drawing.Size(1224, 213);
            this.richTextBoxDescription.TabIndex = 2;
            this.richTextBoxDescription.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Descrição";
            // 
            // labelAssociatedCustomer
            // 
            this.labelAssociatedCustomer.AutoSize = true;
            this.labelAssociatedCustomer.Location = new System.Drawing.Point(12, 106);
            this.labelAssociatedCustomer.Margin = new System.Windows.Forms.Padding(3);
            this.labelAssociatedCustomer.Name = "labelAssociatedCustomer";
            this.labelAssociatedCustomer.Size = new System.Drawing.Size(407, 25);
            this.labelAssociatedCustomer.TabIndex = 4;
            this.labelAssociatedCustomer.Text = "Cliente associado: Nenhum cliente associado";
            // 
            // comboBoxEquipment
            // 
            this.comboBoxEquipment.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxEquipment.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxEquipment.BackColor = System.Drawing.SystemColors.Control;
            this.comboBoxEquipment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxEquipment.Location = new System.Drawing.Point(498, 140);
            this.comboBoxEquipment.Margin = new System.Windows.Forms.Padding(0);
            this.comboBoxEquipment.Name = "comboBoxEquipment";
            this.comboBoxEquipment.Size = new System.Drawing.Size(205, 33);
            this.comboBoxEquipment.Sorted = true;
            this.comboBoxEquipment.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(296, 143);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(196, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tipo de equipamento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 143);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Marca";
            // 
            // comboBoxBrand
            // 
            this.comboBoxBrand.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxBrand.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxBrand.BackColor = System.Drawing.SystemColors.Control;
            this.comboBoxBrand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxBrand.Location = new System.Drawing.Point(85, 140);
            this.comboBoxBrand.Margin = new System.Windows.Forms.Padding(0);
            this.comboBoxBrand.Name = "comboBoxBrand";
            this.comboBoxBrand.Size = new System.Drawing.Size(205, 33);
            this.comboBoxBrand.Sorted = true;
            this.comboBoxBrand.TabIndex = 7;
            this.comboBoxBrand.SelectedIndexChanged += new System.EventHandler(this.comboBoxBrand_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(709, 143);
            this.label5.Margin = new System.Windows.Forms.Padding(0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Modelo";
            // 
            // comboBoxModel
            // 
            this.comboBoxModel.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxModel.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxModel.BackColor = System.Drawing.SystemColors.Control;
            this.comboBoxModel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxModel.Location = new System.Drawing.Point(792, 140);
            this.comboBoxModel.Margin = new System.Windows.Forms.Padding(0);
            this.comboBoxModel.Name = "comboBoxModel";
            this.comboBoxModel.Size = new System.Drawing.Size(205, 33);
            this.comboBoxModel.Sorted = true;
            this.comboBoxModel.TabIndex = 10;
            // 
            // RegisterNewTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.comboBoxModel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxBrand);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxEquipment);
            this.Controls.Add(this.labelAssociatedCustomer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBoxDescription);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.panelTop);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "RegisterNewTicket";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterNewTicket";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Button buttonInsertTicket;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.RichTextBox richTextBoxDescription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAssociateCustomer;
        private System.Windows.Forms.Label labelAssociatedCustomer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonRmoveCustomer;
        private System.Windows.Forms.ComboBox comboBoxEquipment;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxBrand;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxModel;
    }
}
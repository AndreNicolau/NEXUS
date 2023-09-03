namespace NEXUS.Forms.Customers
{
    partial class CustomerFile
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxPhoneNumber = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxTaxPayerNumber = new System.Windows.Forms.TextBox();
            this.buttonEditCustomerData = new System.Windows.Forms.Button();
            this.buttonCancelClose = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.labelCustomerId = new System.Windows.Forms.Label();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panelTop = new System.Windows.Forms.Panel();
            this.buttonSave = new System.Windows.Forms.Button();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(488, 191);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // textBoxName
            // 
            this.textBoxName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxName.Enabled = false;
            this.textBoxName.Location = new System.Drawing.Point(488, 227);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(304, 30);
            this.textBoxName.TabIndex = 1;
            this.textBoxName.Tag = "customerData";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(488, 345);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Email";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxEmail.Enabled = false;
            this.textBoxEmail.Location = new System.Drawing.Point(488, 381);
            this.textBoxEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(304, 30);
            this.textBoxEmail.TabIndex = 5;
            this.textBoxEmail.Tag = "customerData";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(488, 268);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Número telemóvel";
            // 
            // textBoxPhoneNumber
            // 
            this.textBoxPhoneNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxPhoneNumber.Enabled = false;
            this.textBoxPhoneNumber.Location = new System.Drawing.Point(488, 304);
            this.textBoxPhoneNumber.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            this.textBoxPhoneNumber.Size = new System.Drawing.Size(304, 30);
            this.textBoxPhoneNumber.TabIndex = 7;
            this.textBoxPhoneNumber.Tag = "customerData";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(488, 422);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(186, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Número contribuinte";
            // 
            // textBoxTaxPayerNumber
            // 
            this.textBoxTaxPayerNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxTaxPayerNumber.Enabled = false;
            this.textBoxTaxPayerNumber.Location = new System.Drawing.Point(488, 458);
            this.textBoxTaxPayerNumber.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxTaxPayerNumber.Name = "textBoxTaxPayerNumber";
            this.textBoxTaxPayerNumber.Size = new System.Drawing.Size(304, 30);
            this.textBoxTaxPayerNumber.TabIndex = 9;
            this.textBoxTaxPayerNumber.Tag = "customerData";
            // 
            // buttonEditCustomerData
            // 
            this.buttonEditCustomerData.FlatAppearance.BorderSize = 0;
            this.buttonEditCustomerData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEditCustomerData.Image = global::NEXUS.Properties.Resources.file_edit_icon_24px;
            this.buttonEditCustomerData.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonEditCustomerData.Location = new System.Drawing.Point(13, 5);
            this.buttonEditCustomerData.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonEditCustomerData.Name = "buttonEditCustomerData";
            this.buttonEditCustomerData.Size = new System.Drawing.Size(85, 60);
            this.buttonEditCustomerData.TabIndex = 10;
            this.buttonEditCustomerData.Text = "Editar";
            this.buttonEditCustomerData.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonEditCustomerData.UseVisualStyleBackColor = true;
            this.buttonEditCustomerData.Click += new System.EventHandler(this.buttonEditCustomerData_Click);
            // 
            // buttonCancelClose
            // 
            this.buttonCancelClose.FlatAppearance.BorderSize = 0;
            this.buttonCancelClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancelClose.Image = global::NEXUS.Properties.Resources.circle_close_icon_24px;
            this.buttonCancelClose.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonCancelClose.Location = new System.Drawing.Point(106, 5);
            this.buttonCancelClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonCancelClose.Name = "buttonCancelClose";
            this.buttonCancelClose.Size = new System.Drawing.Size(85, 60);
            this.buttonCancelClose.TabIndex = 11;
            this.buttonCancelClose.Text = "Fechar";
            this.buttonCancelClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonCancelClose.UseVisualStyleBackColor = true;
            this.buttonCancelClose.Click += new System.EventHandler(this.buttonCancelClose_Click);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(488, 155);
            this.label6.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(153, 25);
            this.label6.TabIndex = 14;
            this.label6.Text = "Numero cliente: ";
            // 
            // labelCustomerId
            // 
            this.labelCustomerId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelCustomerId.AutoSize = true;
            this.labelCustomerId.Location = new System.Drawing.Point(634, 155);
            this.labelCustomerId.Margin = new System.Windows.Forms.Padding(0);
            this.labelCustomerId.Name = "labelCustomerId";
            this.labelCustomerId.Size = new System.Drawing.Size(23, 25);
            this.labelCustomerId.TabIndex = 15;
            this.labelCustomerId.Text = "1";
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxAddress.Enabled = false;
            this.textBoxAddress.Location = new System.Drawing.Point(488, 535);
            this.textBoxAddress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(304, 30);
            this.textBoxAddress.TabIndex = 13;
            this.textBoxAddress.Tag = "customerData";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(488, 499);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "Morada";
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.SystemColors.Control;
            this.panelTop.Controls.Add(this.buttonSave);
            this.panelTop.Controls.Add(this.buttonEditCustomerData);
            this.panelTop.Controls.Add(this.buttonCancelClose);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1280, 70);
            this.panelTop.TabIndex = 18;
            // 
            // buttonSave
            // 
            this.buttonSave.Enabled = false;
            this.buttonSave.FlatAppearance.BorderSize = 0;
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.Image = global::NEXUS.Properties.Resources.disk_icon_24px;
            this.buttonSave.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonSave.Location = new System.Drawing.Point(199, 5);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(85, 60);
            this.buttonSave.TabIndex = 12;
            this.buttonSave.Text = "Salvar";
            this.buttonSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // CustomerFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelCustomerId);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxTaxPayerNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.textBoxPhoneNumber);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CustomerFile";
            this.Text = "CustomerFile";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelTop.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxPhoneNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxTaxPayerNumber;
        private System.Windows.Forms.Button buttonEditCustomerData;
        private System.Windows.Forms.Button buttonCancelClose;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelCustomerId;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Button buttonSave;
    }
}
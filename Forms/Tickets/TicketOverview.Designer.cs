namespace NEXUS.Forms.Tickets
{
    partial class TicketOverview
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelTicketNumber = new System.Windows.Forms.Label();
            this.labelOpenDate = new System.Windows.Forms.Label();
            this.labelCustomerId = new System.Windows.Forms.Label();
            this.labelEquipmentType = new System.Windows.Forms.Label();
            this.labelBrand = new System.Windows.Forms.Label();
            this.labelModel = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.buttonClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1262, 70);
            this.panel1.TabIndex = 0;
            // 
            // labelTicketNumber
            // 
            this.labelTicketNumber.AutoSize = true;
            this.labelTicketNumber.Location = new System.Drawing.Point(12, 76);
            this.labelTicketNumber.Margin = new System.Windows.Forms.Padding(3);
            this.labelTicketNumber.Name = "labelTicketNumber";
            this.labelTicketNumber.Size = new System.Drawing.Size(180, 25);
            this.labelTicketNumber.TabIndex = 1;
            this.labelTicketNumber.Text = "Número do ticket: 0";
            // 
            // labelOpenDate
            // 
            this.labelOpenDate.AutoSize = true;
            this.labelOpenDate.Location = new System.Drawing.Point(198, 76);
            this.labelOpenDate.Margin = new System.Windows.Forms.Padding(3);
            this.labelOpenDate.Name = "labelOpenDate";
            this.labelOpenDate.Size = new System.Drawing.Size(268, 25);
            this.labelOpenDate.TabIndex = 2;
            this.labelOpenDate.Text = "Data de abertura: 2023/12/31";
            // 
            // labelCustomerId
            // 
            this.labelCustomerId.AutoSize = true;
            this.labelCustomerId.Location = new System.Drawing.Point(472, 76);
            this.labelCustomerId.Margin = new System.Windows.Forms.Padding(3);
            this.labelCustomerId.Name = "labelCustomerId";
            this.labelCustomerId.Size = new System.Drawing.Size(189, 25);
            this.labelCustomerId.TabIndex = 3;
            this.labelCustomerId.Text = "Cliente associado: 1";
            // 
            // labelEquipmentType
            // 
            this.labelEquipmentType.AutoSize = true;
            this.labelEquipmentType.Location = new System.Drawing.Point(342, 107);
            this.labelEquipmentType.Margin = new System.Windows.Forms.Padding(3);
            this.labelEquipmentType.Name = "labelEquipmentType";
            this.labelEquipmentType.Size = new System.Drawing.Size(266, 25);
            this.labelEquipmentType.TabIndex = 4;
            this.labelEquipmentType.Text = "Tipo de equipamento: Portátil";
            // 
            // labelBrand
            // 
            this.labelBrand.AutoSize = true;
            this.labelBrand.Location = new System.Drawing.Point(12, 107);
            this.labelBrand.Margin = new System.Windows.Forms.Padding(3);
            this.labelBrand.Name = "labelBrand";
            this.labelBrand.Size = new System.Drawing.Size(143, 25);
            this.labelBrand.TabIndex = 5;
            this.labelBrand.Text = "Marca: Lenovo";
            // 
            // labelModel
            // 
            this.labelModel.AutoSize = true;
            this.labelModel.Location = new System.Drawing.Point(161, 107);
            this.labelModel.Margin = new System.Windows.Forms.Padding(3);
            this.labelModel.Name = "labelModel";
            this.labelModel.Size = new System.Drawing.Size(175, 25);
            this.labelModel.TabIndex = 6;
            this.labelModel.Text = "Modelo: Ideapad 5";
            // 
            // buttonClose
            // 
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Image = global::NEXUS.Properties.Resources.circle_close_icon_24px;
            this.buttonClose.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonClose.Location = new System.Drawing.Point(0, 5);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(0);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(100, 60);
            this.buttonClose.TabIndex = 14;
            this.buttonClose.Text = "Cancelar";
            this.buttonClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // TicketOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.labelModel);
            this.Controls.Add(this.labelBrand);
            this.Controls.Add(this.labelEquipmentType);
            this.Controls.Add(this.labelCustomerId);
            this.Controls.Add(this.labelOpenDate);
            this.Controls.Add(this.labelTicketNumber);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "TicketOverview";
            this.Text = "TicketOverview";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelTicketNumber;
        private System.Windows.Forms.Label labelOpenDate;
        private System.Windows.Forms.Label labelCustomerId;
        private System.Windows.Forms.Label labelEquipmentType;
        private System.Windows.Forms.Label labelBrand;
        private System.Windows.Forms.Label labelModel;
        private System.Windows.Forms.Button buttonClose;
    }
}
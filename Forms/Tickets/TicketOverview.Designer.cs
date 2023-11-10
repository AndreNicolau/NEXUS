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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonClose = new System.Windows.Forms.Button();
            this.labelTicketNumber = new System.Windows.Forms.Label();
            this.labelOpenDate = new System.Windows.Forms.Label();
            this.labelCustomerId = new System.Windows.Forms.Label();
            this.labelEquipmentType = new System.Windows.Forms.Label();
            this.labelBrand = new System.Windows.Forms.Label();
            this.labelModel = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewActions = new System.Windows.Forms.DataGridView();
            this.richTextBoxActions = new System.Windows.Forms.RichTextBox();
            this.buttonAddAction = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewActions)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.buttonAddAction);
            this.panel1.Controls.Add(this.buttonClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1262, 70);
            this.panel1.TabIndex = 0;
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
            // labelTicketNumber
            // 
            this.labelTicketNumber.AutoSize = true;
            this.labelTicketNumber.Location = new System.Drawing.Point(173, 3);
            this.labelTicketNumber.Margin = new System.Windows.Forms.Padding(3);
            this.labelTicketNumber.Name = "labelTicketNumber";
            this.labelTicketNumber.Size = new System.Drawing.Size(23, 25);
            this.labelTicketNumber.TabIndex = 1;
            this.labelTicketNumber.Text = "0";
            // 
            // labelOpenDate
            // 
            this.labelOpenDate.AutoSize = true;
            this.labelOpenDate.Location = new System.Drawing.Point(202, 3);
            this.labelOpenDate.Margin = new System.Windows.Forms.Padding(3);
            this.labelOpenDate.Name = "labelOpenDate";
            this.labelOpenDate.Size = new System.Drawing.Size(268, 25);
            this.labelOpenDate.TabIndex = 2;
            this.labelOpenDate.Text = "Data de abertura: 2023/12/31";
            // 
            // labelCustomerId
            // 
            this.labelCustomerId.AutoSize = true;
            this.labelCustomerId.Location = new System.Drawing.Point(476, 3);
            this.labelCustomerId.Margin = new System.Windows.Forms.Padding(3);
            this.labelCustomerId.Name = "labelCustomerId";
            this.labelCustomerId.Size = new System.Drawing.Size(189, 25);
            this.labelCustomerId.TabIndex = 3;
            this.labelCustomerId.Text = "Cliente associado: 1";
            // 
            // labelEquipmentType
            // 
            this.labelEquipmentType.AutoSize = true;
            this.labelEquipmentType.Location = new System.Drawing.Point(3, 34);
            this.labelEquipmentType.Margin = new System.Windows.Forms.Padding(3);
            this.labelEquipmentType.Name = "labelEquipmentType";
            this.labelEquipmentType.Size = new System.Drawing.Size(266, 25);
            this.labelEquipmentType.TabIndex = 4;
            this.labelEquipmentType.Text = "Tipo de equipamento: Portátil";
            // 
            // labelBrand
            // 
            this.labelBrand.AutoSize = true;
            this.labelBrand.Location = new System.Drawing.Point(671, 3);
            this.labelBrand.Margin = new System.Windows.Forms.Padding(3);
            this.labelBrand.Name = "labelBrand";
            this.labelBrand.Size = new System.Drawing.Size(143, 25);
            this.labelBrand.TabIndex = 5;
            this.labelBrand.Text = "Marca: Lenovo";
            // 
            // labelModel
            // 
            this.labelModel.AutoSize = true;
            this.labelModel.Location = new System.Drawing.Point(820, 3);
            this.labelModel.Margin = new System.Windows.Forms.Padding(3);
            this.labelModel.Name = "labelModel";
            this.labelModel.Size = new System.Drawing.Size(175, 25);
            this.labelModel.TabIndex = 6;
            this.labelModel.Text = "Modelo: Ideapad 5";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.labelTicketNumber);
            this.flowLayoutPanel1.Controls.Add(this.labelOpenDate);
            this.flowLayoutPanel1.Controls.Add(this.labelCustomerId);
            this.flowLayoutPanel1.Controls.Add(this.labelBrand);
            this.flowLayoutPanel1.Controls.Add(this.labelModel);
            this.flowLayoutPanel1.Controls.Add(this.labelEquipmentType);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 76);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1238, 94);
            this.flowLayoutPanel1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Número do ticket:";
            // 
            // dataGridViewActions
            // 
            this.dataGridViewActions.AllowUserToAddRows = false;
            this.dataGridViewActions.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Black;
            this.dataGridViewActions.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewActions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewActions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewActions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewActions.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewActions.Location = new System.Drawing.Point(12, 176);
            this.dataGridViewActions.Name = "dataGridViewActions";
            this.dataGridViewActions.ReadOnly = true;
            this.dataGridViewActions.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewActions.RowHeadersVisible = false;
            this.dataGridViewActions.RowHeadersWidth = 51;
            this.dataGridViewActions.RowTemplate.Height = 24;
            this.dataGridViewActions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewActions.Size = new System.Drawing.Size(1238, 178);
            this.dataGridViewActions.TabIndex = 8;
            this.dataGridViewActions.SelectionChanged += new System.EventHandler(this.dataGridViewActions_SelectionChanged);
            // 
            // richTextBoxActions
            // 
            this.richTextBoxActions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxActions.Location = new System.Drawing.Point(12, 360);
            this.richTextBoxActions.Name = "richTextBoxActions";
            this.richTextBoxActions.Size = new System.Drawing.Size(1238, 230);
            this.richTextBoxActions.TabIndex = 9;
            this.richTextBoxActions.Text = "";
            // 
            // buttonAddAction
            // 
            this.buttonAddAction.FlatAppearance.BorderSize = 0;
            this.buttonAddAction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddAction.Image = global::NEXUS.Properties.Resources.add_icon_24px;
            this.buttonAddAction.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonAddAction.Location = new System.Drawing.Point(100, 5);
            this.buttonAddAction.Margin = new System.Windows.Forms.Padding(0);
            this.buttonAddAction.Name = "buttonAddAction";
            this.buttonAddAction.Size = new System.Drawing.Size(151, 60);
            this.buttonAddAction.TabIndex = 15;
            this.buttonAddAction.Text = "Adicionar ação";
            this.buttonAddAction.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonAddAction.UseVisualStyleBackColor = true;
            this.buttonAddAction.Click += new System.EventHandler(this.buttonAddAction_Click);
            // 
            // TicketOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.richTextBoxActions);
            this.Controls.Add(this.dataGridViewActions);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "TicketOverview";
            this.Text = "TicketOverview";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewActions)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.DataGridView dataGridViewActions;
        private System.Windows.Forms.RichTextBox richTextBoxActions;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAddAction;
    }
}
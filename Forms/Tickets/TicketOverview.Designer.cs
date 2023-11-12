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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonAddAction = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.labelTicketNumber = new System.Windows.Forms.Label();
            this.labelOpenDate = new System.Windows.Forms.Label();
            this.labelCustomerId = new System.Windows.Forms.Label();
            this.labelEquipmentType = new System.Windows.Forms.Label();
            this.labelBrand = new System.Windows.Forms.Label();
            this.labelModel = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.dataGridViewActions = new System.Windows.Forms.DataGridView();
            this.richTextBoxActions = new System.Windows.Forms.RichTextBox();
            this.buttonInsertAction = new System.Windows.Forms.Button();
            this.labelSerialNumber = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewActions)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.buttonAddAction);
            this.panel1.Controls.Add(this.buttonClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1262, 70);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::NEXUS.Properties.Resources.clear_icon_24px;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(251, 5);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 60);
            this.button1.TabIndex = 16;
            this.button1.Text = "Fechar ticket";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.labelTicketNumber.Location = new System.Drawing.Point(3, 3);
            this.labelTicketNumber.Margin = new System.Windows.Forms.Padding(3);
            this.labelTicketNumber.Name = "labelTicketNumber";
            this.labelTicketNumber.Size = new System.Drawing.Size(180, 25);
            this.labelTicketNumber.TabIndex = 1;
            this.labelTicketNumber.Text = "Número do ticket: 0";
            // 
            // labelOpenDate
            // 
            this.labelOpenDate.AutoSize = true;
            this.labelOpenDate.Location = new System.Drawing.Point(189, 3);
            this.labelOpenDate.Margin = new System.Windows.Forms.Padding(3);
            this.labelOpenDate.Name = "labelOpenDate";
            this.labelOpenDate.Size = new System.Drawing.Size(268, 25);
            this.labelOpenDate.TabIndex = 2;
            this.labelOpenDate.Text = "Data de abertura: 2023/12/31";
            // 
            // labelCustomerId
            // 
            this.labelCustomerId.AutoSize = true;
            this.labelCustomerId.Location = new System.Drawing.Point(463, 3);
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
            this.labelBrand.Location = new System.Drawing.Point(658, 3);
            this.labelBrand.Margin = new System.Windows.Forms.Padding(3);
            this.labelBrand.Name = "labelBrand";
            this.labelBrand.Size = new System.Drawing.Size(143, 25);
            this.labelBrand.TabIndex = 5;
            this.labelBrand.Text = "Marca: Lenovo";
            // 
            // labelModel
            // 
            this.labelModel.AutoSize = true;
            this.labelModel.Location = new System.Drawing.Point(807, 3);
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
            this.flowLayoutPanel1.Controls.Add(this.labelTicketNumber);
            this.flowLayoutPanel1.Controls.Add(this.labelOpenDate);
            this.flowLayoutPanel1.Controls.Add(this.labelCustomerId);
            this.flowLayoutPanel1.Controls.Add(this.labelBrand);
            this.flowLayoutPanel1.Controls.Add(this.labelModel);
            this.flowLayoutPanel1.Controls.Add(this.labelEquipmentType);
            this.flowLayoutPanel1.Controls.Add(this.labelSerialNumber);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 76);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1238, 70);
            this.flowLayoutPanel1.TabIndex = 7;
            // 
            // dataGridViewActions
            // 
            this.dataGridViewActions.AllowUserToAddRows = false;
            this.dataGridViewActions.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black;
            this.dataGridViewActions.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewActions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewActions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewActions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewActions.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewActions.Location = new System.Drawing.Point(12, 152);
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
            this.richTextBoxActions.Location = new System.Drawing.Point(12, 336);
            this.richTextBoxActions.Name = "richTextBoxActions";
            this.richTextBoxActions.ReadOnly = true;
            this.richTextBoxActions.Size = new System.Drawing.Size(1238, 230);
            this.richTextBoxActions.TabIndex = 9;
            this.richTextBoxActions.Text = "";
            // 
            // buttonInsertAction
            // 
            this.buttonInsertAction.AutoSize = true;
            this.buttonInsertAction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInsertAction.Location = new System.Drawing.Point(12, 572);
            this.buttonInsertAction.Name = "buttonInsertAction";
            this.buttonInsertAction.Size = new System.Drawing.Size(87, 37);
            this.buttonInsertAction.TabIndex = 10;
            this.buttonInsertAction.Text = "Inserir";
            this.buttonInsertAction.UseVisualStyleBackColor = true;
            this.buttonInsertAction.Visible = false;
            this.buttonInsertAction.Click += new System.EventHandler(this.buttonInsertAction_Click);
            // 
            // labelSerialNumber
            // 
            this.labelSerialNumber.AutoSize = true;
            this.labelSerialNumber.Location = new System.Drawing.Point(275, 34);
            this.labelSerialNumber.Margin = new System.Windows.Forms.Padding(3);
            this.labelSerialNumber.Name = "labelSerialNumber";
            this.labelSerialNumber.Size = new System.Drawing.Size(177, 25);
            this.labelSerialNumber.TabIndex = 7;
            this.labelSerialNumber.Text = "Número de série: 0";
            // 
            // TicketOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.buttonInsertAction);
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
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.DataGridView dataGridViewActions;
        private System.Windows.Forms.RichTextBox richTextBoxActions;
        private System.Windows.Forms.Button buttonAddAction;
        private System.Windows.Forms.Button buttonInsertAction;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelSerialNumber;
    }
}
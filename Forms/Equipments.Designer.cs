namespace NEXUS.Forms
{
    partial class Equipments
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxModel = new System.Windows.Forms.TextBox();
            this.comboBoxEquipmentType = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonRemoveEquipment = new System.Windows.Forms.Button();
            this.buttonAddEquipment = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridViewModels = new System.Windows.Forms.DataGridView();
            this.comboBoxBrand = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewModels)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Marca";
            // 
            // textBoxModel
            // 
            this.textBoxModel.Location = new System.Drawing.Point(48, 140);
            this.textBoxModel.Name = "textBoxModel";
            this.textBoxModel.Size = new System.Drawing.Size(191, 30);
            this.textBoxModel.TabIndex = 1;
            // 
            // comboBoxEquipmentType
            // 
            this.comboBoxEquipmentType.FormattingEnabled = true;
            this.comboBoxEquipmentType.Location = new System.Drawing.Point(48, 221);
            this.comboBoxEquipmentType.Name = "comboBoxEquipmentType";
            this.comboBoxEquipmentType.Size = new System.Drawing.Size(191, 33);
            this.comboBoxEquipmentType.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.buttonCancel);
            this.panel1.Controls.Add(this.buttonRemoveEquipment);
            this.panel1.Controls.Add(this.buttonAddEquipment);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1280, 70);
            this.panel1.TabIndex = 3;
            // 
            // buttonRemoveEquipment
            // 
            this.buttonRemoveEquipment.FlatAppearance.BorderSize = 0;
            this.buttonRemoveEquipment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRemoveEquipment.Image = global::NEXUS.Properties.Resources.bin_icon_24px;
            this.buttonRemoveEquipment.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonRemoveEquipment.Location = new System.Drawing.Point(115, 7);
            this.buttonRemoveEquipment.Margin = new System.Windows.Forms.Padding(0);
            this.buttonRemoveEquipment.Name = "buttonRemoveEquipment";
            this.buttonRemoveEquipment.Size = new System.Drawing.Size(106, 60);
            this.buttonRemoveEquipment.TabIndex = 2;
            this.buttonRemoveEquipment.Text = "Remover";
            this.buttonRemoveEquipment.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonRemoveEquipment.UseVisualStyleBackColor = true;
            this.buttonRemoveEquipment.Click += new System.EventHandler(this.buttonRemoveEquipment_Click);
            // 
            // buttonAddEquipment
            // 
            this.buttonAddEquipment.FlatAppearance.BorderSize = 0;
            this.buttonAddEquipment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddEquipment.Image = global::NEXUS.Properties.Resources.add_icon_24px;
            this.buttonAddEquipment.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonAddEquipment.Location = new System.Drawing.Point(9, 9);
            this.buttonAddEquipment.Margin = new System.Windows.Forms.Padding(0);
            this.buttonAddEquipment.Name = "buttonAddEquipment";
            this.buttonAddEquipment.Size = new System.Drawing.Size(106, 60);
            this.buttonAddEquipment.TabIndex = 1;
            this.buttonAddEquipment.Text = "Adicionar";
            this.buttonAddEquipment.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonAddEquipment.UseVisualStyleBackColor = true;
            this.buttonAddEquipment.Click += new System.EventHandler(this.buttonAddEquipment_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonInsert);
            this.panel2.Controls.Add(this.dataGridViewModels);
            this.panel2.Controls.Add(this.comboBoxBrand);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.textBoxModel);
            this.panel2.Controls.Add(this.comboBoxEquipmentType);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 70);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1280, 650);
            this.panel2.TabIndex = 4;
            // 
            // dataGridViewModels
            // 
            this.dataGridViewModels.AllowUserToAddRows = false;
            this.dataGridViewModels.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black;
            this.dataGridViewModels.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewModels.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewModels.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewModels.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewModels.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewModels.Dock = System.Windows.Forms.DockStyle.Right;
            this.dataGridViewModels.Location = new System.Drawing.Point(498, 0);
            this.dataGridViewModels.Name = "dataGridViewModels";
            this.dataGridViewModels.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewModels.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewModels.RowHeadersVisible = false;
            this.dataGridViewModels.RowHeadersWidth = 51;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Black;
            this.dataGridViewModels.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewModels.RowTemplate.Height = 24;
            this.dataGridViewModels.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewModels.Size = new System.Drawing.Size(782, 650);
            this.dataGridViewModels.TabIndex = 6;
            // 
            // comboBoxBrand
            // 
            this.comboBoxBrand.FormattingEnabled = true;
            this.comboBoxBrand.Location = new System.Drawing.Point(48, 56);
            this.comboBoxBrand.Name = "comboBoxBrand";
            this.comboBoxBrand.Size = new System.Drawing.Size(191, 33);
            this.comboBoxBrand.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(196, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tipo de equipamento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Modelo";
            // 
            // buttonCancel
            // 
            this.buttonCancel.FlatAppearance.BorderSize = 0;
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.Image = global::NEXUS.Properties.Resources.circle_close_icon_24px;
            this.buttonCancel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonCancel.Location = new System.Drawing.Point(221, 7);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(0);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(106, 60);
            this.buttonCancel.TabIndex = 3;
            this.buttonCancel.Text = "Cancelar";
            this.buttonCancel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonInsert
            // 
            this.buttonInsert.BackColor = System.Drawing.Color.White;
            this.buttonInsert.FlatAppearance.BorderSize = 0;
            this.buttonInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInsert.Location = new System.Drawing.Point(48, 260);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(191, 34);
            this.buttonInsert.TabIndex = 7;
            this.buttonInsert.Text = "Inserir";
            this.buttonInsert.UseVisualStyleBackColor = false;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // Equipments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Equipments";
            this.Text = "Equipments";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewModels)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxModel;
        private System.Windows.Forms.ComboBox comboBoxEquipmentType;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridViewModels;
        private System.Windows.Forms.ComboBox comboBoxBrand;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonAddEquipment;
        private System.Windows.Forms.Button buttonRemoveEquipment;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonInsert;
    }
}
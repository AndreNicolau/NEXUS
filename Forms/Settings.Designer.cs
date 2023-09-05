namespace NEXUS
{
    partial class Settings
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
            this.buttonSave = new System.Windows.Forms.Button();
            this.textBoxServerName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxDatabaseName = new System.Windows.Forms.TextBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(359, 176);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Servidor";
            // 
            // buttonSave
            // 
            this.buttonSave.FlatAppearance.BorderSize = 0;
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.Image = global::NEXUS.Properties.Resources.disk_icon_24px;
            this.buttonSave.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonSave.Location = new System.Drawing.Point(13, 5);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(80, 60);
            this.buttonSave.TabIndex = 1;
            this.buttonSave.Text = "Salvar";
            this.buttonSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // textBoxServerName
            // 
            this.textBoxServerName.Location = new System.Drawing.Point(359, 206);
            this.textBoxServerName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxServerName.Name = "textBoxServerName";
            this.textBoxServerName.Size = new System.Drawing.Size(215, 30);
            this.textBoxServerName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(359, 241);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Base de dados";
            // 
            // textBoxDatabaseName
            // 
            this.textBoxDatabaseName.Location = new System.Drawing.Point(359, 271);
            this.textBoxDatabaseName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxDatabaseName.Name = "textBoxDatabaseName";
            this.textBoxDatabaseName.Size = new System.Drawing.Size(215, 30);
            this.textBoxDatabaseName.TabIndex = 4;
            // 
            // buttonCancel
            // 
            this.buttonCancel.FlatAppearance.BorderSize = 0;
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.Image = global::NEXUS.Properties.Resources.circle_close_icon_24px;
            this.buttonCancel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonCancel.Location = new System.Drawing.Point(101, 5);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(100, 60);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "Cancelar";
            this.buttonCancel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonSave);
            this.panel1.Controls.Add(this.buttonCancel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(932, 70);
            this.panel1.TabIndex = 6;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(359, 320);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(340, 112);
            this.richTextBox1.TabIndex = 7;
            this.richTextBox1.Text = "";
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 476);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBoxDatabaseName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxServerName);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configurações";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Settings_FormClosed);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TextBox textBoxServerName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxDatabaseName;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}
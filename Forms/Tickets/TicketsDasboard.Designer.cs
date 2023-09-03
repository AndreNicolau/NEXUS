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
            this.topPanel = new System.Windows.Forms.Panel();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.radioButtonOpened = new System.Windows.Forms.RadioButton();
            this.topPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.White;
            this.topPanel.Controls.Add(this.radioButtonOpened);
            this.topPanel.Controls.Add(this.button1);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1200, 70);
            this.topPanel.TabIndex = 0;
            // 
            // mainPanel
            // 
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 70);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1200, 633);
            this.mainPanel.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::NEXUS.Properties.Resources.add_icon_24px;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(0, 5);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 60);
            this.button1.TabIndex = 0;
            this.button1.Text = "Novo";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // radioButtonOpened
            // 
            this.radioButtonOpened.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonOpened.FlatAppearance.BorderSize = 0;
            this.radioButtonOpened.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButtonOpened.Image = global::NEXUS.Properties.Resources.document_icon_24px;
            this.radioButtonOpened.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.radioButtonOpened.Location = new System.Drawing.Point(78, 5);
            this.radioButtonOpened.Name = "radioButtonOpened";
            this.radioButtonOpened.Size = new System.Drawing.Size(95, 60);
            this.radioButtonOpened.TabIndex = 1;
            this.radioButtonOpened.TabStop = true;
            this.radioButtonOpened.Text = "Abertos";
            this.radioButtonOpened.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.radioButtonOpened.UseVisualStyleBackColor = true;
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.RadioButton radioButtonOpened;
    }
}
namespace CSP_Analyze
{
    partial class Form1
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
            System.Windows.Forms.Label label1;
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.statusTabPage = new System.Windows.Forms.TabPage();
            this.importButton = new System.Windows.Forms.Button();
            this.queryTabPage = new System.Windows.Forms.TabPage();
            this.telemetryRichTextBox = new System.Windows.Forms.RichTextBox();
            label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.statusTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.Black;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(8, 12);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(155, 24);
            label1.TabIndex = 1;
            label1.Text = "QUICK ACTIONS";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.statusTabPage);
            this.tabControl1.Controls.Add(this.queryTabPage);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 449);
            this.tabControl1.TabIndex = 0;
            // 
            // statusTabPage
            // 
            this.statusTabPage.Controls.Add(this.telemetryRichTextBox);
            this.statusTabPage.Controls.Add(this.importButton);
            this.statusTabPage.Controls.Add(label1);
            this.statusTabPage.Location = new System.Drawing.Point(4, 25);
            this.statusTabPage.Name = "statusTabPage";
            this.statusTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.statusTabPage.Size = new System.Drawing.Size(792, 420);
            this.statusTabPage.TabIndex = 0;
            this.statusTabPage.Text = "Status";
            this.statusTabPage.UseVisualStyleBackColor = true;
            // 
            // importButton
            // 
            this.importButton.Location = new System.Drawing.Point(12, 50);
            this.importButton.Name = "importButton";
            this.importButton.Size = new System.Drawing.Size(151, 23);
            this.importButton.TabIndex = 2;
            this.importButton.Text = "Import";
            this.importButton.UseVisualStyleBackColor = true;
            this.importButton.Click += new System.EventHandler(this.importButton_Click);
            // 
            // queryTabPage
            // 
            this.queryTabPage.Location = new System.Drawing.Point(4, 25);
            this.queryTabPage.Name = "queryTabPage";
            this.queryTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.queryTabPage.Size = new System.Drawing.Size(792, 420);
            this.queryTabPage.TabIndex = 1;
            this.queryTabPage.Text = "Query";
            this.queryTabPage.UseVisualStyleBackColor = true;
            // 
            // telemetryRichTextBox
            // 
            this.telemetryRichTextBox.Location = new System.Drawing.Point(228, 50);
            this.telemetryRichTextBox.Name = "telemetryRichTextBox";
            this.telemetryRichTextBox.Size = new System.Drawing.Size(538, 295);
            this.telemetryRichTextBox.TabIndex = 3;
            this.telemetryRichTextBox.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.statusTabPage.ResumeLayout(false);
            this.statusTabPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage statusTabPage;
        private System.Windows.Forms.TabPage queryTabPage;
        private System.Windows.Forms.Button importButton;
        private System.Windows.Forms.RichTextBox telemetryRichTextBox;
    }
}


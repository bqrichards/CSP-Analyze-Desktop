namespace CSP_Analyze
{
    partial class NewQueryForm
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
            this.teamNumberTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.resultsRichTextBox = new System.Windows.Forms.RichTextBox();
            this.queryButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // teamNumberTextBox
            // 
            this.teamNumberTextBox.Location = new System.Drawing.Point(10, 29);
            this.teamNumberTextBox.Name = "teamNumberTextBox";
            this.teamNumberTextBox.Size = new System.Drawing.Size(100, 22);
            this.teamNumberTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Team Number";
            // 
            // resultsRichTextBox
            // 
            this.resultsRichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resultsRichTextBox.Location = new System.Drawing.Point(116, 12);
            this.resultsRichTextBox.Name = "resultsRichTextBox";
            this.resultsRichTextBox.Size = new System.Drawing.Size(672, 426);
            this.resultsRichTextBox.TabIndex = 2;
            this.resultsRichTextBox.Text = "";
            // 
            // queryButton
            // 
            this.queryButton.Location = new System.Drawing.Point(10, 57);
            this.queryButton.Name = "queryButton";
            this.queryButton.Size = new System.Drawing.Size(100, 23);
            this.queryButton.TabIndex = 3;
            this.queryButton.Text = "Pull";
            this.queryButton.UseVisualStyleBackColor = true;
            this.queryButton.Click += new System.EventHandler(this.QueryButton_Click);
            // 
            // NewQueryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.queryButton);
            this.Controls.Add(this.resultsRichTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.teamNumberTextBox);
            this.Name = "NewQueryForm";
            this.Text = "NewQueryForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox teamNumberTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox resultsRichTextBox;
        private System.Windows.Forms.Button queryButton;
    }
}
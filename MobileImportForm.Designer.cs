namespace CSP_Analyze
{
    partial class MobileImportForm
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
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            this.label1 = new System.Windows.Forms.Label();
            this.matchNumberTextBox = new System.Windows.Forms.TextBox();
            this.mobileImportTelemetry = new System.Windows.Forms.RichTextBox();
            this.pullButton = new System.Windows.Forms.Button();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.Color.Black;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.ForeColor = System.Drawing.Color.White;
            label2.Location = new System.Drawing.Point(350, 10);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(159, 29);
            label2.TabIndex = 5;
            label2.Text = "TELEMETRY";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = System.Drawing.Color.Black;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.ForeColor = System.Drawing.Color.White;
            label3.Location = new System.Drawing.Point(13, 10);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(79, 29);
            label3.TabIndex = 6;
            label3.Text = "SCAN";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Match Number:";
            // 
            // matchNumberTextBox
            // 
            this.matchNumberTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.matchNumberTextBox.Location = new System.Drawing.Point(165, 56);
            this.matchNumberTextBox.Name = "matchNumberTextBox";
            this.matchNumberTextBox.Size = new System.Drawing.Size(106, 30);
            this.matchNumberTextBox.TabIndex = 1;
            this.matchNumberTextBox.TextChanged += new System.EventHandler(this.MatchNumberTextBox_TextChanged);
            // 
            // mobileImportTelemetry
            // 
            this.mobileImportTelemetry.Location = new System.Drawing.Point(355, 42);
            this.mobileImportTelemetry.Name = "mobileImportTelemetry";
            this.mobileImportTelemetry.Size = new System.Drawing.Size(433, 396);
            this.mobileImportTelemetry.TabIndex = 2;
            this.mobileImportTelemetry.Text = "";
            // 
            // pullButton
            // 
            this.pullButton.Enabled = false;
            this.pullButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pullButton.Location = new System.Drawing.Point(18, 110);
            this.pullButton.Name = "pullButton";
            this.pullButton.Size = new System.Drawing.Size(253, 34);
            this.pullButton.TabIndex = 7;
            this.pullButton.Text = "Pull";
            this.pullButton.UseVisualStyleBackColor = true;
            this.pullButton.Click += new System.EventHandler(this.PullButton_Click);
            // 
            // MobileImportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pullButton);
            this.Controls.Add(label3);
            this.Controls.Add(label2);
            this.Controls.Add(this.mobileImportTelemetry);
            this.Controls.Add(this.matchNumberTextBox);
            this.Controls.Add(this.label1);
            this.Name = "MobileImportForm";
            this.Text = "Mobile Import";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox matchNumberTextBox;
        private System.Windows.Forms.RichTextBox mobileImportTelemetry;
        private System.Windows.Forms.Button pullButton;
    }
}
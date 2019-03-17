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
            System.Windows.Forms.RichTextBox instructionsRichTextBox;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.statusTabPage = new System.Windows.Forms.TabPage();
            this.pushDatabaseButton = new System.Windows.Forms.Button();
            this.numberOfLocalChangesLabel = new System.Windows.Forms.Label();
            this.pullDatabaseButton = new System.Windows.Forms.Button();
            this.lastUpdatedLabel = new System.Windows.Forms.Label();
            this.telemetryRichTextBox = new System.Windows.Forms.RichTextBox();
            this.importButton = new System.Windows.Forms.Button();
            this.queryTabPage = new System.Windows.Forms.TabPage();
            this.saveAsQueryButton = new System.Windows.Forms.Button();
            this.runQueryButton = new System.Windows.Forms.Button();
            this.queryRichTextBox = new System.Windows.Forms.RichTextBox();
            this.saveQueryButton = new System.Windows.Forms.Button();
            this.loadQueryButton = new System.Windows.Forms.Button();
            this.newQueryButton = new System.Windows.Forms.Button();
            this.queryHeaderLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            instructionsRichTextBox = new System.Windows.Forms.RichTextBox();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.statusTabPage.SuspendLayout();
            this.queryTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.Black;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(13, 23);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(93, 24);
            label1.TabIndex = 1;
            label1.Text = "ACTIONS";
            // 
            // instructionsRichTextBox
            // 
            instructionsRichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            instructionsRichTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            instructionsRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            instructionsRichTextBox.Location = new System.Drawing.Point(196, 30);
            instructionsRichTextBox.Name = "instructionsRichTextBox";
            instructionsRichTextBox.ReadOnly = true;
            instructionsRichTextBox.Size = new System.Drawing.Size(401, 96);
            instructionsRichTextBox.TabIndex = 6;
            instructionsRichTextBox.Text = "This query is a specialized version of a SQL query. On each line, specify a colum" +
    "n name, operator, and value. For example, auto_flBaseline = true";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.Color.Black;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.ForeColor = System.Drawing.Color.White;
            label2.Location = new System.Drawing.Point(230, 23);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(124, 24);
            label2.TabIndex = 4;
            label2.Text = "TELEMETRY";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = System.Drawing.Color.Black;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.ForeColor = System.Drawing.Color.White;
            label3.Location = new System.Drawing.Point(13, 162);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(111, 24);
            label3.TabIndex = 5;
            label3.Text = "DATABASE";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.queryTabPage);
            this.tabControl1.Controls.Add(this.statusTabPage);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 449);
            this.tabControl1.TabIndex = 0;
            // 
            // statusTabPage
            // 
            this.statusTabPage.Controls.Add(this.pushDatabaseButton);
            this.statusTabPage.Controls.Add(this.numberOfLocalChangesLabel);
            this.statusTabPage.Controls.Add(this.pullDatabaseButton);
            this.statusTabPage.Controls.Add(this.lastUpdatedLabel);
            this.statusTabPage.Controls.Add(label3);
            this.statusTabPage.Controls.Add(label2);
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
            // pushDatabaseButton
            // 
            this.pushDatabaseButton.Location = new System.Drawing.Point(12, 297);
            this.pushDatabaseButton.Name = "pushDatabaseButton";
            this.pushDatabaseButton.Size = new System.Drawing.Size(151, 23);
            this.pushDatabaseButton.TabIndex = 9;
            this.pushDatabaseButton.Text = "Push";
            this.pushDatabaseButton.UseVisualStyleBackColor = true;
            this.pushDatabaseButton.Click += new System.EventHandler(this.PushDatabaseButton_Click);
            // 
            // numberOfLocalChangesLabel
            // 
            this.numberOfLocalChangesLabel.AutoSize = true;
            this.numberOfLocalChangesLabel.Location = new System.Drawing.Point(12, 277);
            this.numberOfLocalChangesLabel.Name = "numberOfLocalChangesLabel";
            this.numberOfLocalChangesLabel.Size = new System.Drawing.Size(169, 16);
            this.numberOfLocalChangesLabel.TabIndex = 8;
            this.numberOfLocalChangesLabel.Text = "Number of Local Changes: ";
            // 
            // pullDatabaseButton
            // 
            this.pullDatabaseButton.Location = new System.Drawing.Point(12, 210);
            this.pullDatabaseButton.Name = "pullDatabaseButton";
            this.pullDatabaseButton.Size = new System.Drawing.Size(151, 23);
            this.pullDatabaseButton.TabIndex = 7;
            this.pullDatabaseButton.Text = "Pull";
            this.pullDatabaseButton.UseVisualStyleBackColor = true;
            this.pullDatabaseButton.Click += new System.EventHandler(this.PullDatabaseButton_Click);
            // 
            // lastUpdatedLabel
            // 
            this.lastUpdatedLabel.AutoSize = true;
            this.lastUpdatedLabel.Location = new System.Drawing.Point(17, 190);
            this.lastUpdatedLabel.Name = "lastUpdatedLabel";
            this.lastUpdatedLabel.Size = new System.Drawing.Size(95, 16);
            this.lastUpdatedLabel.TabIndex = 6;
            this.lastUpdatedLabel.Text = "Last Updated: ";
            // 
            // telemetryRichTextBox
            // 
            this.telemetryRichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.telemetryRichTextBox.Location = new System.Drawing.Point(228, 50);
            this.telemetryRichTextBox.Name = "telemetryRichTextBox";
            this.telemetryRichTextBox.Size = new System.Drawing.Size(538, 295);
            this.telemetryRichTextBox.TabIndex = 3;
            this.telemetryRichTextBox.Text = "";
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
            this.queryTabPage.Controls.Add(this.saveAsQueryButton);
            this.queryTabPage.Controls.Add(instructionsRichTextBox);
            this.queryTabPage.Controls.Add(this.runQueryButton);
            this.queryTabPage.Controls.Add(this.queryRichTextBox);
            this.queryTabPage.Controls.Add(this.saveQueryButton);
            this.queryTabPage.Controls.Add(this.loadQueryButton);
            this.queryTabPage.Controls.Add(this.newQueryButton);
            this.queryTabPage.Controls.Add(this.queryHeaderLabel);
            this.queryTabPage.Location = new System.Drawing.Point(4, 25);
            this.queryTabPage.Name = "queryTabPage";
            this.queryTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.queryTabPage.Size = new System.Drawing.Size(792, 420);
            this.queryTabPage.TabIndex = 1;
            this.queryTabPage.Text = "Query";
            this.queryTabPage.UseVisualStyleBackColor = true;
            // 
            // saveAsQueryButton
            // 
            this.saveAsQueryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveAsQueryButton.Location = new System.Drawing.Point(100, 65);
            this.saveAsQueryButton.Name = "saveAsQueryButton";
            this.saveAsQueryButton.Size = new System.Drawing.Size(90, 29);
            this.saveAsQueryButton.TabIndex = 7;
            this.saveAsQueryButton.Text = "Save As...";
            this.saveAsQueryButton.UseVisualStyleBackColor = true;
            this.saveAsQueryButton.Click += new System.EventHandler(this.SaveAsQueryButton_Click);
            // 
            // runQueryButton
            // 
            this.runQueryButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.runQueryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.runQueryButton.Location = new System.Drawing.Point(603, 100);
            this.runQueryButton.Name = "runQueryButton";
            this.runQueryButton.Size = new System.Drawing.Size(181, 29);
            this.runQueryButton.TabIndex = 5;
            this.runQueryButton.Text = "Run Query";
            this.runQueryButton.UseVisualStyleBackColor = true;
            this.runQueryButton.Click += new System.EventHandler(this.RunQueryButton_Click);
            // 
            // queryRichTextBox
            // 
            this.queryRichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.queryRichTextBox.Location = new System.Drawing.Point(9, 136);
            this.queryRichTextBox.Name = "queryRichTextBox";
            this.queryRichTextBox.Size = new System.Drawing.Size(775, 278);
            this.queryRichTextBox.TabIndex = 4;
            this.queryRichTextBox.Text = "";
            // 
            // saveQueryButton
            // 
            this.saveQueryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveQueryButton.Location = new System.Drawing.Point(8, 65);
            this.saveQueryButton.Name = "saveQueryButton";
            this.saveQueryButton.Size = new System.Drawing.Size(86, 29);
            this.saveQueryButton.TabIndex = 3;
            this.saveQueryButton.Text = "Save";
            this.saveQueryButton.UseVisualStyleBackColor = true;
            this.saveQueryButton.Click += new System.EventHandler(this.SaveQueryButton_Click);
            // 
            // loadQueryButton
            // 
            this.loadQueryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadQueryButton.Location = new System.Drawing.Point(8, 100);
            this.loadQueryButton.Name = "loadQueryButton";
            this.loadQueryButton.Size = new System.Drawing.Size(181, 29);
            this.loadQueryButton.TabIndex = 2;
            this.loadQueryButton.Text = "Load";
            this.loadQueryButton.UseVisualStyleBackColor = true;
            this.loadQueryButton.Click += new System.EventHandler(this.LoadQueryButton_Click);
            // 
            // newQueryButton
            // 
            this.newQueryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newQueryButton.Location = new System.Drawing.Point(8, 30);
            this.newQueryButton.Name = "newQueryButton";
            this.newQueryButton.Size = new System.Drawing.Size(181, 29);
            this.newQueryButton.TabIndex = 1;
            this.newQueryButton.Text = "New";
            this.newQueryButton.UseVisualStyleBackColor = true;
            this.newQueryButton.Click += new System.EventHandler(this.NewQueryButton_Click);
            // 
            // queryHeaderLabel
            // 
            this.queryHeaderLabel.AutoSize = true;
            this.queryHeaderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.queryHeaderLabel.Location = new System.Drawing.Point(3, 3);
            this.queryHeaderLabel.Name = "queryHeaderLabel";
            this.queryHeaderLabel.Size = new System.Drawing.Size(186, 24);
            this.queryHeaderLabel.TabIndex = 0;
            this.queryHeaderLabel.Text = "Current Query: None";
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
            this.queryTabPage.ResumeLayout(false);
            this.queryTabPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage statusTabPage;
        private System.Windows.Forms.TabPage queryTabPage;
        private System.Windows.Forms.Button importButton;
        private System.Windows.Forms.RichTextBox telemetryRichTextBox;
        private System.Windows.Forms.Button loadQueryButton;
        private System.Windows.Forms.Button newQueryButton;
        private System.Windows.Forms.Label queryHeaderLabel;
        private System.Windows.Forms.Button saveQueryButton;
        private System.Windows.Forms.Button runQueryButton;
        private System.Windows.Forms.RichTextBox queryRichTextBox;
        private System.Windows.Forms.Button saveAsQueryButton;
        private System.Windows.Forms.Label lastUpdatedLabel;
        private System.Windows.Forms.Button pullDatabaseButton;
        private System.Windows.Forms.Label numberOfLocalChangesLabel;
        private System.Windows.Forms.Button pushDatabaseButton;
    }
}


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
            this.viewTopTeamsButton = new System.Windows.Forms.Button();
            this.clearTelemetryButton = new System.Windows.Forms.Button();
            this.mobileImportButton = new System.Windows.Forms.Button();
            this.pushDatabaseButton = new System.Windows.Forms.Button();
            this.pullDatabaseButton = new System.Windows.Forms.Button();
            this.telemetryRichTextBox = new System.Windows.Forms.RichTextBox();
            this.importButton = new System.Windows.Forms.Button();
            this.queryTabPage = new System.Windows.Forms.TabPage();
            this.openNewExperimentalQueryButton = new System.Windows.Forms.Button();
            this.tableComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
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
            label1.Location = new System.Drawing.Point(17, 28);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(120, 29);
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
            instructionsRichTextBox.Location = new System.Drawing.Point(261, 37);
            instructionsRichTextBox.Margin = new System.Windows.Forms.Padding(4);
            instructionsRichTextBox.Name = "instructionsRichTextBox";
            instructionsRichTextBox.ReadOnly = true;
            instructionsRichTextBox.Size = new System.Drawing.Size(535, 118);
            instructionsRichTextBox.TabIndex = 6;
            instructionsRichTextBox.Text = "This query is a specialized version of a SQL query. On each line, specify a colum" +
    "n name, operator, and value. For example, auto_flBaseline = true AND auto_flFoul" +
    " = false";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.Color.Black;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.ForeColor = System.Drawing.Color.White;
            label2.Location = new System.Drawing.Point(307, 28);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(159, 29);
            label2.TabIndex = 4;
            label2.Text = "TELEMETRY";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = System.Drawing.Color.Black;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.ForeColor = System.Drawing.Color.White;
            label3.Location = new System.Drawing.Point(17, 199);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(139, 29);
            label3.TabIndex = 5;
            label3.Text = "DATABASE";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.statusTabPage);
            this.tabControl1.Controls.Add(this.queryTabPage);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1067, 553);
            this.tabControl1.TabIndex = 0;
            // 
            // statusTabPage
            // 
            this.statusTabPage.Controls.Add(this.viewTopTeamsButton);
            this.statusTabPage.Controls.Add(this.clearTelemetryButton);
            this.statusTabPage.Controls.Add(this.mobileImportButton);
            this.statusTabPage.Controls.Add(this.pushDatabaseButton);
            this.statusTabPage.Controls.Add(this.pullDatabaseButton);
            this.statusTabPage.Controls.Add(label3);
            this.statusTabPage.Controls.Add(label2);
            this.statusTabPage.Controls.Add(this.telemetryRichTextBox);
            this.statusTabPage.Controls.Add(this.importButton);
            this.statusTabPage.Controls.Add(label1);
            this.statusTabPage.Location = new System.Drawing.Point(4, 29);
            this.statusTabPage.Margin = new System.Windows.Forms.Padding(4);
            this.statusTabPage.Name = "statusTabPage";
            this.statusTabPage.Padding = new System.Windows.Forms.Padding(4);
            this.statusTabPage.Size = new System.Drawing.Size(1059, 520);
            this.statusTabPage.TabIndex = 0;
            this.statusTabPage.Text = "Status";
            this.statusTabPage.UseVisualStyleBackColor = true;
            // 
            // viewTopTeamsButton
            // 
            this.viewTopTeamsButton.Location = new System.Drawing.Point(16, 304);
            this.viewTopTeamsButton.Name = "viewTopTeamsButton";
            this.viewTopTeamsButton.Size = new System.Drawing.Size(201, 29);
            this.viewTopTeamsButton.TabIndex = 12;
            this.viewTopTeamsButton.Text = "View Top Teams";
            this.viewTopTeamsButton.UseVisualStyleBackColor = true;
            this.viewTopTeamsButton.Click += new System.EventHandler(this.ViewTopTeamsButton_Click);
            // 
            // clearTelemetryButton
            // 
            this.clearTelemetryButton.Location = new System.Drawing.Point(899, 26);
            this.clearTelemetryButton.Name = "clearTelemetryButton";
            this.clearTelemetryButton.Size = new System.Drawing.Size(121, 29);
            this.clearTelemetryButton.TabIndex = 11;
            this.clearTelemetryButton.Text = "Clear";
            this.clearTelemetryButton.UseVisualStyleBackColor = true;
            this.clearTelemetryButton.Click += new System.EventHandler(this.ClearTelemetryButton_Click);
            // 
            // mobileImportButton
            // 
            this.mobileImportButton.Location = new System.Drawing.Point(16, 98);
            this.mobileImportButton.Margin = new System.Windows.Forms.Padding(4);
            this.mobileImportButton.Name = "mobileImportButton";
            this.mobileImportButton.Size = new System.Drawing.Size(201, 28);
            this.mobileImportButton.TabIndex = 10;
            this.mobileImportButton.Text = "Mobile Import";
            this.mobileImportButton.UseVisualStyleBackColor = true;
            this.mobileImportButton.Click += new System.EventHandler(this.MobileImportButton_Click);
            // 
            // pushDatabaseButton
            // 
            this.pushDatabaseButton.Location = new System.Drawing.Point(16, 268);
            this.pushDatabaseButton.Margin = new System.Windows.Forms.Padding(4);
            this.pushDatabaseButton.Name = "pushDatabaseButton";
            this.pushDatabaseButton.Size = new System.Drawing.Size(201, 28);
            this.pushDatabaseButton.TabIndex = 9;
            this.pushDatabaseButton.Text = "Push";
            this.pushDatabaseButton.UseVisualStyleBackColor = true;
            this.pushDatabaseButton.Click += new System.EventHandler(this.PushDatabaseButton_Click);
            // 
            // pullDatabaseButton
            // 
            this.pullDatabaseButton.Location = new System.Drawing.Point(16, 232);
            this.pullDatabaseButton.Margin = new System.Windows.Forms.Padding(4);
            this.pullDatabaseButton.Name = "pullDatabaseButton";
            this.pullDatabaseButton.Size = new System.Drawing.Size(201, 28);
            this.pullDatabaseButton.TabIndex = 7;
            this.pullDatabaseButton.Text = "Pull";
            this.pullDatabaseButton.UseVisualStyleBackColor = true;
            this.pullDatabaseButton.Click += new System.EventHandler(this.PullDatabaseButton_Click);
            // 
            // telemetryRichTextBox
            // 
            this.telemetryRichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.telemetryRichTextBox.Location = new System.Drawing.Point(304, 62);
            this.telemetryRichTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.telemetryRichTextBox.Name = "telemetryRichTextBox";
            this.telemetryRichTextBox.Size = new System.Drawing.Size(736, 450);
            this.telemetryRichTextBox.TabIndex = 3;
            this.telemetryRichTextBox.Text = "";
            // 
            // importButton
            // 
            this.importButton.Location = new System.Drawing.Point(16, 62);
            this.importButton.Margin = new System.Windows.Forms.Padding(4);
            this.importButton.Name = "importButton";
            this.importButton.Size = new System.Drawing.Size(201, 28);
            this.importButton.TabIndex = 2;
            this.importButton.Text = "Import";
            this.importButton.UseVisualStyleBackColor = true;
            this.importButton.Click += new System.EventHandler(this.importButton_Click);
            // 
            // queryTabPage
            // 
            this.queryTabPage.Controls.Add(this.openNewExperimentalQueryButton);
            this.queryTabPage.Controls.Add(this.tableComboBox);
            this.queryTabPage.Controls.Add(this.label4);
            this.queryTabPage.Controls.Add(this.saveAsQueryButton);
            this.queryTabPage.Controls.Add(instructionsRichTextBox);
            this.queryTabPage.Controls.Add(this.runQueryButton);
            this.queryTabPage.Controls.Add(this.queryRichTextBox);
            this.queryTabPage.Controls.Add(this.saveQueryButton);
            this.queryTabPage.Controls.Add(this.loadQueryButton);
            this.queryTabPage.Controls.Add(this.newQueryButton);
            this.queryTabPage.Controls.Add(this.queryHeaderLabel);
            this.queryTabPage.Location = new System.Drawing.Point(4, 29);
            this.queryTabPage.Margin = new System.Windows.Forms.Padding(4);
            this.queryTabPage.Name = "queryTabPage";
            this.queryTabPage.Padding = new System.Windows.Forms.Padding(4);
            this.queryTabPage.Size = new System.Drawing.Size(1059, 520);
            this.queryTabPage.TabIndex = 1;
            this.queryTabPage.Text = "Query";
            this.queryTabPage.UseVisualStyleBackColor = true;
            // 
            // openNewExperimentalQueryButton
            // 
            this.openNewExperimentalQueryButton.Location = new System.Drawing.Point(898, 68);
            this.openNewExperimentalQueryButton.Name = "openNewExperimentalQueryButton";
            this.openNewExperimentalQueryButton.Size = new System.Drawing.Size(146, 28);
            this.openNewExperimentalQueryButton.TabIndex = 10;
            this.openNewExperimentalQueryButton.Text = "experimental";
            this.openNewExperimentalQueryButton.UseVisualStyleBackColor = true;
            this.openNewExperimentalQueryButton.Click += new System.EventHandler(this.OpenNewExperimentalQueryButton_Click);
            // 
            // tableComboBox
            // 
            this.tableComboBox.FormattingEnabled = true;
            this.tableComboBox.Items.AddRange(new object[] {
            "Match",
            "Pit"});
            this.tableComboBox.Location = new System.Drawing.Point(878, 34);
            this.tableComboBox.Name = "tableComboBox";
            this.tableComboBox.Size = new System.Drawing.Size(166, 28);
            this.tableComboBox.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(804, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Table:";
            // 
            // saveAsQueryButton
            // 
            this.saveAsQueryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveAsQueryButton.Location = new System.Drawing.Point(133, 80);
            this.saveAsQueryButton.Margin = new System.Windows.Forms.Padding(4);
            this.saveAsQueryButton.Name = "saveAsQueryButton";
            this.saveAsQueryButton.Size = new System.Drawing.Size(120, 36);
            this.saveAsQueryButton.TabIndex = 7;
            this.saveAsQueryButton.Text = "Save As...";
            this.saveAsQueryButton.UseVisualStyleBackColor = true;
            this.saveAsQueryButton.Click += new System.EventHandler(this.SaveAsQueryButton_Click);
            // 
            // runQueryButton
            // 
            this.runQueryButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.runQueryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.runQueryButton.Location = new System.Drawing.Point(804, 123);
            this.runQueryButton.Margin = new System.Windows.Forms.Padding(4);
            this.runQueryButton.Name = "runQueryButton";
            this.runQueryButton.Size = new System.Drawing.Size(241, 36);
            this.runQueryButton.TabIndex = 5;
            this.runQueryButton.Text = "Run Query";
            this.runQueryButton.UseVisualStyleBackColor = true;
            this.runQueryButton.Click += new System.EventHandler(this.RunQueryButton_Click);
            // 
            // queryRichTextBox
            // 
            this.queryRichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.queryRichTextBox.BackColor = System.Drawing.Color.White;
            this.queryRichTextBox.Location = new System.Drawing.Point(12, 167);
            this.queryRichTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.queryRichTextBox.Name = "queryRichTextBox";
            this.queryRichTextBox.Size = new System.Drawing.Size(1032, 341);
            this.queryRichTextBox.TabIndex = 4;
            this.queryRichTextBox.Text = "";
            // 
            // saveQueryButton
            // 
            this.saveQueryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveQueryButton.Location = new System.Drawing.Point(11, 80);
            this.saveQueryButton.Margin = new System.Windows.Forms.Padding(4);
            this.saveQueryButton.Name = "saveQueryButton";
            this.saveQueryButton.Size = new System.Drawing.Size(115, 36);
            this.saveQueryButton.TabIndex = 3;
            this.saveQueryButton.Text = "Save";
            this.saveQueryButton.UseVisualStyleBackColor = true;
            this.saveQueryButton.Click += new System.EventHandler(this.SaveQueryButton_Click);
            // 
            // loadQueryButton
            // 
            this.loadQueryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadQueryButton.Location = new System.Drawing.Point(11, 123);
            this.loadQueryButton.Margin = new System.Windows.Forms.Padding(4);
            this.loadQueryButton.Name = "loadQueryButton";
            this.loadQueryButton.Size = new System.Drawing.Size(241, 36);
            this.loadQueryButton.TabIndex = 2;
            this.loadQueryButton.Text = "Load";
            this.loadQueryButton.UseVisualStyleBackColor = true;
            this.loadQueryButton.Click += new System.EventHandler(this.LoadQueryButton_Click);
            // 
            // newQueryButton
            // 
            this.newQueryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newQueryButton.Location = new System.Drawing.Point(11, 37);
            this.newQueryButton.Margin = new System.Windows.Forms.Padding(4);
            this.newQueryButton.Name = "newQueryButton";
            this.newQueryButton.Size = new System.Drawing.Size(241, 36);
            this.newQueryButton.TabIndex = 1;
            this.newQueryButton.Text = "New";
            this.newQueryButton.UseVisualStyleBackColor = true;
            this.newQueryButton.Click += new System.EventHandler(this.NewQueryButton_Click);
            // 
            // queryHeaderLabel
            // 
            this.queryHeaderLabel.AutoSize = true;
            this.queryHeaderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.queryHeaderLabel.Location = new System.Drawing.Point(4, 4);
            this.queryHeaderLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.queryHeaderLabel.Name = "queryHeaderLabel";
            this.queryHeaderLabel.Size = new System.Drawing.Size(234, 29);
            this.queryHeaderLabel.TabIndex = 0;
            this.queryHeaderLabel.Text = "Current Query: None";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "CSP Analyze";
            this.Load += new System.EventHandler(this.Form1_Load);
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
        private System.Windows.Forms.Button pullDatabaseButton;
        private System.Windows.Forms.Button pushDatabaseButton;
        private System.Windows.Forms.Button mobileImportButton;
        private System.Windows.Forms.ComboBox tableComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button clearTelemetryButton;
        private System.Windows.Forms.Button openNewExperimentalQueryButton;
        private System.Windows.Forms.Button viewTopTeamsButton;
    }
}


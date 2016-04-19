namespace Ignite_Compiler
{
    partial class LexicalAnalyser
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
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.compileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lexicalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutIgniteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.developersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.feedbackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.technicalSupportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backToMainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lexicalHeading = new System.Windows.Forms.Label();
            this.generateTokensButton = new System.Windows.Forms.Button();
            this.outputRichTextBox = new System.Windows.Forms.RichTextBox();
            this.inputRichTextBox = new System.Windows.Forms.RichTextBox();
            this.orangeSidebar = new System.Windows.Forms.PictureBox();
            this.MenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orangeSidebar)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuStrip
            // 
            this.MenuStrip.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MenuStrip.AutoSize = false;
            this.MenuStrip.BackColor = System.Drawing.Color.OrangeRed;
            this.MenuStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.MenuStrip.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuStrip.GripMargin = new System.Windows.Forms.Padding(2);
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.compileToolStripMenuItem,
            this.lexicalToolStripMenuItem,
            this.ToolStripMenuItem,
            this.newsToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.backToMainToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.MenuStrip.Location = new System.Drawing.Point(39, -1);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.MenuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.MenuStrip.Size = new System.Drawing.Size(1044, 37);
            this.MenuStrip.TabIndex = 190;
            // 
            // compileToolStripMenuItem
            // 
            this.compileToolStripMenuItem.Name = "compileToolStripMenuItem";
            this.compileToolStripMenuItem.Size = new System.Drawing.Size(161, 33);
            this.compileToolStripMenuItem.Text = "     Compile       ";
            this.compileToolStripMenuItem.Click += new System.EventHandler(this.compileToolStripMenuItem_Click);
            // 
            // lexicalToolStripMenuItem
            // 
            this.lexicalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.lexicalToolStripMenuItem.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lexicalToolStripMenuItem.Name = "lexicalToolStripMenuItem";
            this.lexicalToolStripMenuItem.Size = new System.Drawing.Size(146, 33);
            this.lexicalToolStripMenuItem.Text = "    Lexical       ";
            this.lexicalToolStripMenuItem.Click += new System.EventHandler(this.lexicalToolStripMenuItem_Click);
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Font = new System.Drawing.Font("Georgia", 12F);
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Font = new System.Drawing.Font("Georgia", 12F);
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Font = new System.Drawing.Font("Georgia", 12F);
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // ToolStripMenuItem
            // 
            this.ToolStripMenuItem.Name = "ToolStripMenuItem";
            this.ToolStripMenuItem.Size = new System.Drawing.Size(157, 33);
            this.ToolStripMenuItem.Text = "    Example      ";
            // 
            // newsToolStripMenuItem
            // 
            this.newsToolStripMenuItem.Name = "newsToolStripMenuItem";
            this.newsToolStripMenuItem.Size = new System.Drawing.Size(124, 33);
            this.newsToolStripMenuItem.Text = "    News      ";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutIgniteToolStripMenuItem,
            this.developersToolStripMenuItem,
            this.feedbackToolStripMenuItem,
            this.technicalSupportToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(119, 33);
            this.helpToolStripMenuItem.Text = "    Help      ";
            // 
            // aboutIgniteToolStripMenuItem
            // 
            this.aboutIgniteToolStripMenuItem.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutIgniteToolStripMenuItem.Name = "aboutIgniteToolStripMenuItem";
            this.aboutIgniteToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.aboutIgniteToolStripMenuItem.Text = "About Ignite";
            this.aboutIgniteToolStripMenuItem.Click += new System.EventHandler(this.aboutIgniteToolStripMenuItem_Click);
            // 
            // developersToolStripMenuItem
            // 
            this.developersToolStripMenuItem.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.developersToolStripMenuItem.Name = "developersToolStripMenuItem";
            this.developersToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.developersToolStripMenuItem.Text = "Developers";
            this.developersToolStripMenuItem.Click += new System.EventHandler(this.developersToolStripMenuItem_Click);
            // 
            // feedbackToolStripMenuItem
            // 
            this.feedbackToolStripMenuItem.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.feedbackToolStripMenuItem.Name = "feedbackToolStripMenuItem";
            this.feedbackToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.feedbackToolStripMenuItem.Text = "Feedback";
            // 
            // technicalSupportToolStripMenuItem
            // 
            this.technicalSupportToolStripMenuItem.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.technicalSupportToolStripMenuItem.Name = "technicalSupportToolStripMenuItem";
            this.technicalSupportToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.technicalSupportToolStripMenuItem.Text = "Technical Support";
            // 
            // backToMainToolStripMenuItem
            // 
            this.backToMainToolStripMenuItem.Name = "backToMainToolStripMenuItem";
            this.backToMainToolStripMenuItem.Size = new System.Drawing.Size(196, 33);
            this.backToMainToolStripMenuItem.Text = "    Back to Main      ";
            this.backToMainToolStripMenuItem.Click += new System.EventHandler(this.backToMainToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(117, 33);
            this.exitToolStripMenuItem.Text = "     Exit      ";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // lexicalHeading
            // 
            this.lexicalHeading.AutoSize = true;
            this.lexicalHeading.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, System.Drawing.FontStyle.Italic);
            this.lexicalHeading.Location = new System.Drawing.Point(41, 46);
            this.lexicalHeading.Name = "lexicalHeading";
            this.lexicalHeading.Size = new System.Drawing.Size(241, 45);
            this.lexicalHeading.TabIndex = 191;
            this.lexicalHeading.Text = "Lexical Analyser";
            // 
            // generateTokensButton
            // 
            this.generateTokensButton.BackColor = System.Drawing.Color.OrangeRed;
            this.generateTokensButton.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateTokensButton.Location = new System.Drawing.Point(897, 625);
            this.generateTokensButton.Name = "generateTokensButton";
            this.generateTokensButton.Size = new System.Drawing.Size(164, 48);
            this.generateTokensButton.TabIndex = 1;
            this.generateTokensButton.Text = "Generate Tokens";
            this.generateTokensButton.UseVisualStyleBackColor = false;
            this.generateTokensButton.Click += new System.EventHandler(this.generateTokensButton_Click);
            // 
            // outputRichTextBox
            // 
            this.outputRichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.outputRichTextBox.Location = new System.Drawing.Point(562, 111);
            this.outputRichTextBox.Name = "outputRichTextBox";
            this.outputRichTextBox.ReadOnly = true;
            this.outputRichTextBox.Size = new System.Drawing.Size(500, 498);
            this.outputRichTextBox.TabIndex = 198;
            this.outputRichTextBox.TabStop = false;
            this.outputRichTextBox.Text = "";
            // 
            // inputRichTextBox
            // 
            this.inputRichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputRichTextBox.Location = new System.Drawing.Point(49, 111);
            this.inputRichTextBox.Name = "inputRichTextBox";
            this.inputRichTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.inputRichTextBox.Size = new System.Drawing.Size(500, 498);
            this.inputRichTextBox.TabIndex = 0;
            this.inputRichTextBox.Text = "";
            // 
            // orangeSidebar
            // 
            this.orangeSidebar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.orangeSidebar.Image = global::Ignite_Compiler.Properties.Resources.OrangeSideBar;
            this.orangeSidebar.Location = new System.Drawing.Point(-12, -38);
            this.orangeSidebar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.orangeSidebar.Name = "orangeSidebar";
            this.orangeSidebar.Size = new System.Drawing.Size(51, 733);
            this.orangeSidebar.TabIndex = 189;
            this.orangeSidebar.TabStop = false;
            // 
            // LexicalAnalyser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1073, 685);
            this.Controls.Add(this.generateTokensButton);
            this.Controls.Add(this.outputRichTextBox);
            this.Controls.Add(this.inputRichTextBox);
            this.Controls.Add(this.lexicalHeading);
            this.Controls.Add(this.MenuStrip);
            this.Controls.Add(this.orangeSidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "LexicalAnalyser";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ignite Compiler";
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orangeSidebar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox orangeSidebar;
        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem compileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lexicalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutIgniteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem developersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem feedbackToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem technicalSupportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label lexicalHeading;
        private System.Windows.Forms.ToolStripMenuItem backToMainToolStripMenuItem;
        private System.Windows.Forms.Button generateTokensButton;
        private System.Windows.Forms.RichTextBox outputRichTextBox;
        private System.Windows.Forms.RichTextBox inputRichTextBox;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
    }
}


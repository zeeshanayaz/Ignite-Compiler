namespace Ignite_Compiler
{
    partial class ignite
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
            this.compileButton = new System.Windows.Forms.Button();
            this.lexicalButton = new System.Windows.Forms.Button();
            this.developerInfoButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.logoIgnitePictureBox = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.logoIgnitePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // compileButton
            // 
            this.compileButton.BackColor = System.Drawing.Color.OrangeRed;
            this.compileButton.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.compileButton.Location = new System.Drawing.Point(126, 218);
            this.compileButton.Name = "compileButton";
            this.compileButton.Size = new System.Drawing.Size(164, 48);
            this.compileButton.TabIndex = 0;
            this.compileButton.Text = "Compile";
            this.compileButton.UseVisualStyleBackColor = false;
            this.compileButton.Click += new System.EventHandler(this.compileButton_Click);
            // 
            // lexicalButton
            // 
            this.lexicalButton.BackColor = System.Drawing.Color.OrangeRed;
            this.lexicalButton.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lexicalButton.Location = new System.Drawing.Point(126, 282);
            this.lexicalButton.Name = "lexicalButton";
            this.lexicalButton.Size = new System.Drawing.Size(164, 48);
            this.lexicalButton.TabIndex = 1;
            this.lexicalButton.Text = "Lexical Tokens";
            this.lexicalButton.UseVisualStyleBackColor = false;
            this.lexicalButton.Click += new System.EventHandler(this.lexicalButton_Click);
            // 
            // developerInfoButton
            // 
            this.developerInfoButton.BackColor = System.Drawing.Color.OrangeRed;
            this.developerInfoButton.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.developerInfoButton.Location = new System.Drawing.Point(126, 346);
            this.developerInfoButton.Name = "developerInfoButton";
            this.developerInfoButton.Size = new System.Drawing.Size(164, 48);
            this.developerInfoButton.TabIndex = 2;
            this.developerInfoButton.Text = "About Developers";
            this.developerInfoButton.UseVisualStyleBackColor = false;
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.OrangeRed;
            this.exitButton.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(145, 411);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(126, 39);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // logoIgnitePictureBox
            // 
            this.logoIgnitePictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.logoIgnitePictureBox.Image = global::Ignite_Compiler.Properties.Resources.ignite_logo;
            this.logoIgnitePictureBox.Location = new System.Drawing.Point(75, 40);
            this.logoIgnitePictureBox.Name = "logoIgnitePictureBox";
            this.logoIgnitePictureBox.Size = new System.Drawing.Size(279, 136);
            this.logoIgnitePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoIgnitePictureBox.TabIndex = 193;
            this.logoIgnitePictureBox.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox2.Image = global::Ignite_Compiler.Properties.Resources.OrangeSideBar;
            this.pictureBox2.Location = new System.Drawing.Point(-8, -16);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(51, 552);
            this.pictureBox2.TabIndex = 192;
            this.pictureBox2.TabStop = false;
            // 
            // ignite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(419, 512);
            this.Controls.Add(this.logoIgnitePictureBox);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.developerInfoButton);
            this.Controls.Add(this.lexicalButton);
            this.Controls.Add(this.compileButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ignite";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ignite";
            ((System.ComponentModel.ISupportInitialize)(this.logoIgnitePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button compileButton;
        private System.Windows.Forms.Button lexicalButton;
        private System.Windows.Forms.Button developerInfoButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox logoIgnitePictureBox;
    }
}
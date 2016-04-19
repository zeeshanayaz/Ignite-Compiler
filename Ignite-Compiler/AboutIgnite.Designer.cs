namespace Ignite_Compiler
{
    partial class AboutIgnite
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
            this.AboutIgniteLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.logoIgnitePictureBox = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.CloseButton = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.logoIgnitePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).BeginInit();
            this.SuspendLayout();
            // 
            // AboutIgniteLabel
            // 
            this.AboutIgniteLabel.AutoSize = true;
            this.AboutIgniteLabel.Font = new System.Drawing.Font("Monotype Corsiva", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AboutIgniteLabel.Location = new System.Drawing.Point(122, 128);
            this.AboutIgniteLabel.Name = "AboutIgniteLabel";
            this.AboutIgniteLabel.Size = new System.Drawing.Size(294, 43);
            this.AboutIgniteLabel.TabIndex = 195;
            this.AboutIgniteLabel.Text = "About Ignite Compiler";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Orange;
            this.label1.Location = new System.Drawing.Point(44, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(475, 22);
            this.label1.TabIndex = 196;
            this.label1.Text = "We are expert,we know our job and we know what the people want!";
            // 
            // logoIgnitePictureBox
            // 
            this.logoIgnitePictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.logoIgnitePictureBox.Image = global::Ignite_Compiler.Properties.Resources.ignite_logo;
            this.logoIgnitePictureBox.Location = new System.Drawing.Point(129, -11);
            this.logoIgnitePictureBox.Name = "logoIgnitePictureBox";
            this.logoIgnitePictureBox.Size = new System.Drawing.Size(279, 136);
            this.logoIgnitePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoIgnitePictureBox.TabIndex = 194;
            this.logoIgnitePictureBox.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox2.Image = global::Ignite_Compiler.Properties.Resources.OrangeSideBar;
            this.pictureBox2.Location = new System.Drawing.Point(-7, -46);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(51, 552);
            this.pictureBox2.TabIndex = 193;
            this.pictureBox2.TabStop = false;
            // 
            // CloseButton
            // 
            this.CloseButton.Image = global::Ignite_Compiler.Properties.Resources.no;
            this.CloseButton.Location = new System.Drawing.Point(502, 7);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(17, 20);
            this.CloseButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CloseButton.TabIndex = 162;
            this.CloseButton.TabStop = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // AboutIgnite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(527, 448);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AboutIgniteLabel);
            this.Controls.Add(this.logoIgnitePictureBox);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.CloseButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AboutIgnite";
            this.ShowIcon = false;
            this.Text = "About Ignite";
            ((System.ComponentModel.ISupportInitialize)(this.logoIgnitePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox CloseButton;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox logoIgnitePictureBox;
        private System.Windows.Forms.Label AboutIgniteLabel;
        private System.Windows.Forms.Label label1;
    }
}
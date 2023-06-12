namespace CampusCashBank
{
    partial class SettingsForm
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
            pictureBox = new PictureBox();
            BtnUploadPicture = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // pictureBox
            // 
            pictureBox.Location = new Point(23, 22);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(373, 416);
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.TabIndex = 0;
            pictureBox.TabStop = false;
            // 
            // BtnUploadPicture
            // 
            BtnUploadPicture.Location = new Point(434, 151);
            BtnUploadPicture.Name = "BtnUploadPicture";
            BtnUploadPicture.Size = new Size(133, 29);
            BtnUploadPicture.TabIndex = 1;
            BtnUploadPicture.Text = "Upload";
            BtnUploadPicture.UseVisualStyleBackColor = true;
            BtnUploadPicture.Click += BtnUploadPicture_Click;
            // 
            // button1
            // 
            button1.Location = new Point(434, 203);
            button1.Name = "button1";
            button1.Size = new Size(133, 29);
            button1.TabIndex = 2;
            button1.Text = "Save changes";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // SettingsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(BtnUploadPicture);
            Controls.Add(pictureBox);
            Name = "SettingsForm";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox;
        private Button BtnUploadPicture;
        private Button button1;
    }
}
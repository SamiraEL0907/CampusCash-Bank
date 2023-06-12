using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CampusCashBank
{
    public partial class SettingsForm : Form
    {
        private int userId;

        public SettingsForm(int userId)
        {
            InitializeComponent();

            this.userId = userId;
        }

        private void BtnUploadPicture_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files(*.jpeg;*.bmp;*.png;*.jpg)|*.jpeg;*.bmp;*.png;*.jpg";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Display the picture in the PictureBox.
                    pictureBox.Image = new Bitmap(openFileDialog.FileName);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Convert the image in the PictureBox to a Base64 string.
            string base64Image = ConvertImageToBase64(pictureBox.Image);

            // Save the Base64 string to the database.
            Users user = new Users();
            bool success = user.UpdateUserPicture(userId, base64Image);

            if (success)
            {
                MessageBox.Show("Profile picture updated successfully.");
            }
            else
            {
                MessageBox.Show("There was an error updating the profile picture. Please try again.");
            }

            // Close the SettingsForm and go back to the AccountsForm.
            this.Close();
        }

        private string ConvertImageToBase64(Image image)
        {
            // Determine the scaling factor
            float scale = Math.Min((float)100 / image.Width, (float)100 / image.Height);

            // Create a new bitmap of the right size
            int newWidth = (int)Math.Round(image.Width * scale);
            int newHeight = (int)Math.Round(image.Height * scale);
            Bitmap bmp = new Bitmap(newWidth, newHeight);

            // Draw the original image in the bitmap
            Graphics g = Graphics.FromImage(bmp);
            g.DrawImage(image, 0, 0, newWidth, newHeight);

            // Convert the resized image to a base64 string
            using (MemoryStream ms = new MemoryStream())
            {
                bmp.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                byte[] byteImage = ms.ToArray();
                return Convert.ToBase64String(byteImage);
            }
        }

        private Image ConvertBase64ToImage(string base64String)
        {
            byte[] imageBytes = Convert.FromBase64String(base64String);
            using (MemoryStream ms = new MemoryStream(imageBytes))
            {
                return Image.FromStream(ms);
            }
        }


        private void SettingsForm_Load(object sender, EventArgs e)
        {
            // Create a new Users instance.
            Users users = new Users();

            // Retrieve the profile picture.
            string base64Image = users.GetUserProfilePicture(userId);

            if (!string.IsNullOrEmpty(base64Image))
            {
                // Convert the Base64 string to an Image and display it in the PictureBox.
                pictureBox.Image = ConvertBase64ToImage(base64Image);
            }
        }




    }
}

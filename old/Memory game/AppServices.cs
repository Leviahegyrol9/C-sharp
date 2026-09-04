using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memory_game
{
    public class Image
    {
        public string Name { get; set; }
        public string Path { get; set; }
        public Image()
        {
            
        }
    }
    public class AppServices
    {
        public static void FillPictureBoxes(Panel panel)
        {
            for (int i = 0; i < panel.Controls.Count; i++)
            {
                PictureBox pb = panel.Controls[i] as PictureBox;

                if (i >= Form2.images.Count)
                {
                    pb.ImageLocation = Form2.images[i - Form2.images.Count].Path;
                }
                else
                {
                    pb.ImageLocation = Form2.images[i].Path;
                }
            }
        }
        public static void MixBtn(Panel panel, Button button)
        {
            Random rnd = new Random();

            List<PictureBox> pictureBoxes = panel.Controls.OfType<PictureBox>().ToList();
            List<Point> positions = pictureBoxes.Select(pb => pb.Location).ToList();

            for (int i = positions.Count - 1; i > 0; i--)
            {
                int j = rnd.Next(i + 1);
                Point temp = positions[i];

                positions[i] = positions[j];
                positions[j] = temp;
            }

            foreach (PictureBox pb in pictureBoxes)
            {
                pb.Location = positions[pictureBoxes.IndexOf(pb)];

                if (pb.Tag == null) pb.Tag = pb.ImageLocation;

                pb.ImageLocation = null;
                pb.BackColor = Color.Black;
            }

            button.Visible = false;
        }

        public static int point = 0;
        public async static void ClickImage(Panel panel, Button button, Label label, object sender)
        {
            List<PictureBox> clickedImages = panel.Controls.OfType<PictureBox>().Where(pb => pb.BorderStyle == BorderStyle.Fixed3D).ToList();

            if (clickedImages.Count < 2)
            {
                PictureBox pictureBox = sender as PictureBox;

                if (pictureBox.ImageLocation == null && !button.Visible)
                {
                    point++;
                    label.Text = point.ToString();
                    pictureBox.BorderStyle = BorderStyle.Fixed3D;
                    pictureBox.BackColor = Color.Transparent;

                    pictureBox.ImageLocation = pictureBox.Tag.ToString();

                    List<PictureBox> pictureBoxesWithImage = panel.Controls.OfType<PictureBox>().Where(pb => pb.BorderStyle == BorderStyle.Fixed3D).ToList();

                    if (pictureBoxesWithImage.Count == 2)
                    {
                        if (pictureBoxesWithImage.First().ImageLocation == pictureBoxesWithImage.Last().ImageLocation)
                        {
                            foreach (PictureBox pb in pictureBoxesWithImage)
                            {
                                pb.BorderStyle = BorderStyle.None;
                            }
                        }
                        else
                        {
                            await Task.Delay(1500);

                            foreach (PictureBox pb in pictureBoxesWithImage)
                            {
                                pb.ImageLocation = null;
                                pb.BorderStyle = BorderStyle.None;
                                pb.BackColor = Color.Black;
                            }
                        }
                    }
                }
            }
        }
        public static void ShowWinLabel(Panel panel, Label label)
        {
            foreach (PictureBox pb in panel.Controls)
            {
                if (pb.ImageLocation == null)
                {
                    return;
                }
            }

            label.Visible = true;
        }
    }
}

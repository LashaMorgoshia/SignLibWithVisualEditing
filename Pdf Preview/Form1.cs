using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pdf_Preview
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                using (var document = PdfiumViewer.PdfDocument.Load(@"D:\GreenCard\2021\AES Print Lasha.pdf"))
                {
                    this.pictureBox1.Image = document.Render(0, 300, 300, true);
                }
            }
            catch (Exception ex)
            {
                // handle exception here;
            }
        }

        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            var returnImage = default(Image);
            try
            {
                MemoryStream ms = new MemoryStream(byteArrayIn, 0, byteArrayIn.Length);
                ms.Write(byteArrayIn, 0, byteArrayIn.Length);
                returnImage = Image.FromStream(ms, true);//Exception occurs here
            }
            catch { }
            return returnImage;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

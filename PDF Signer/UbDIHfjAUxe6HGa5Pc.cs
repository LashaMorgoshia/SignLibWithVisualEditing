using System;
using System.Drawing;
using System.Windows.Forms;

namespace PDFSigner
{
    public partial class UbDIHfjAUxe6HGa5Pc : Form
    {
        bool IsMouseDown = false;
        System.Drawing.Point LocationXY;
        System.Drawing.Point LocationX1Y1;
        public Rectangle rect;

        public UbDIHfjAUxe6HGa5Pc(string pdfPath)
        {
            InitializeComponent();

            this.loadPreview(pdfPath);
        }

        private void loadPreview(string path)
        {
            try
            {
                using (var document = PdfiumViewer.PdfDocument.Load(path))
                {
                    this.pictureBoxPdfPreview.Image = document.Render(0, 300, 300, true);
                }
            }
            catch (Exception ex)
            {
                // handle exception here;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBoxPdfPreview_MouseDown(object sender, MouseEventArgs e)
        {
            IsMouseDown = true; // If This Event Is Occured So This Variable Is True.
            LocationXY = e.Location;
        }

        private void pictureBoxPdfPreview_MouseMove(object sender, MouseEventArgs e)
        {
            if (IsMouseDown == true) // This Block Is Not Execute Until Mouse Down Event Is Not a Fire.
            {
                LocationX1Y1 = e.Location; // Get The Current Location Of Point X and Y.

                Refresh(); // Refresh the form.
            }
        }

        private void pictureBoxPdfPreview_MouseUp(object sender, MouseEventArgs e)
        {
            if (IsMouseDown == true) // This Block Is Not Execute Until Mouse Down Event Is Not a Fire.
            {
                LocationX1Y1 = e.Location; // Get The Ending Point of X and Y.

                IsMouseDown = false; // false this..

                label1.Text = $"x:{rect.X} y:{rect.Y} | w:{rect.Width} h:{rect.Height}";
            }
        }

        private void pictureBoxPdfPreview_Paint(object sender, PaintEventArgs e)
        {
            if (rect != null) // Check If Rectangle Is Not a null.
            {
                e.Graphics.DrawRectangle(Pens.Red, GetRect()); // GetRect() Is a Function, Now Creates this function.
            }
        }

        private Rectangle GetRect()
        {
            //Create Object Of rect. we define rect at TOP.
            rect = new Rectangle();

            //The x-value of our Rectangle should be the minimum between the start x-value and the current x-position.
            rect.X = Math.Min(LocationXY.X, LocationX1Y1.X);

            //same as above x-value. The y-value of our Rectangle should be the minimum between the start y-value and the current y-position.
            rect.Y = Math.Min(LocationXY.Y, LocationX1Y1.Y);

            //the width of our rectangle should be the maximum between the start x-position and current x-position MINUS.
            rect.Width = Math.Abs(LocationXY.X - LocationX1Y1.X);

            rect.Height = Math.Abs(LocationXY.Y - LocationX1Y1.Y);

            return rect;
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrEditor2023
{
    public partial class frmGrEditor : Form
    {
        Graphics mobjPlatno;
        int mintMouseX, mintMouseY;

        Bitmap mobjBitmapInMemory;
        Graphics mobjGrapficsInMemory;

        // kreslící nástroje
        enum enTool
        {
            Line,
            Rectangle,
            Ellipse
        }
        // aktuální nástroj
        enTool menActiveTool;

        public frmGrEditor()
        {
            InitializeComponent();

            // vytvoření kreslicí grafiky
            mobjPlatno = pbPlatno.CreateGraphics();

            // vytvoření bitmapy 
            mobjBitmapInMemory = new Bitmap(pbPlatno.Width, 
                pbPlatno.Height, mobjPlatno);
            // z bitmapy vytvoření grafiky
            mobjGrapficsInMemory = Graphics.FromImage(mobjBitmapInMemory);
            mobjGrapficsInMemory.Clear(Color.White);

            // init nástroje
            menActiveTool = enTool.Line;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Brush lobjStetec;
            
            mobjPlatno.DrawLine(Pens.Red,10,10,100,100);

            lobjStetec = new SolidBrush(Color.RoyalBlue);
            mobjPlatno.FillRectangle(lobjStetec, 50, 50, 30, 30);
        }

        private void pbPlatno_MouseMove(object sender, MouseEventArgs e)
        {
            tsSouradniceMysi.Text = "x:" + e.X.ToString() + " y:" + e.Y.ToString();

            if (e.Button == MouseButtons.None) return;

            // na plátno dát původní obrázek
            mobjPlatno.Clear(Color.White);
            mobjPlatno.DrawImage(mobjBitmapInMemory, 0, 0);

            // nakreslení na picturebox
            GraphicsDraw(mobjPlatno, e);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pbPlatno_MouseUp(object sender, MouseEventArgs e)
        {
            // nakreslení na paměti
            GraphicsDraw(mobjGrapficsInMemory, e);
        }

        private void GraphicsDraw(Graphics objGrafika, MouseEventArgs e)
        {
            Pen lobjActivePen;
            Brush lobjActiveBrush;
            // pero kterým kreslí obrys
            lobjActivePen = new Pen(pbColor1.BackColor);
            //výplň
            lobjActiveBrush = new SolidBrush(pbColor2.BackColor);
            // kreslení podle typu nástroje
            switch (menActiveTool)
            {
                // usečka
                case enTool.Line:
                    objGrafika.DrawLine(lobjActivePen, mintMouseX, mintMouseY,
                        e.X, e.Y);
                    break;
                // obdelník
                case enTool.Rectangle:
                    objGrafika.DrawRectangle(lobjActivePen,
                        mintMouseX, mintMouseY,
                        e.X - mintMouseX, e.Y - mintMouseY);
                    objGrafika.FillRectangle(lobjActiveBrush,
                        mintMouseX, mintMouseY,
                        e.X - mintMouseX, e.Y - mintMouseY);
                    break;
                // elipsa
                case enTool.Ellipse:
                    objGrafika.DrawEllipse(lobjActivePen,
                        mintMouseX, mintMouseY,
                        e.X - mintMouseX, e.Y - mintMouseY);
                    objGrafika.FillEllipse(lobjActiveBrush,
                        mintMouseX, mintMouseY,
                        e.X - mintMouseX, e.Y - mintMouseY);
                    break;
            }
        }

        private void pbSelectBlack_MouseDown(object sender, MouseEventArgs e)
        {
            PictureBox lobjPicturebox;

            lobjPicturebox = (PictureBox)sender;

            if (e.Button==MouseButtons.Left)
                pbColor1.BackColor = lobjPicturebox.BackColor;

            if (e.Button == MouseButtons.Right)
                pbColor2.BackColor = lobjPicturebox.BackColor;
        }

        private void rbLine_Click(object sender, EventArgs e)
        {
            RadioButton lrbTool;

            lrbTool = (RadioButton)sender;

            switch (lrbTool.Text)
            {
                case "Úsecka": menActiveTool = enTool.Line; break;
                case "Obdelník": menActiveTool = enTool.Rectangle; break;
                case "Elipsa": menActiveTool = enTool.Ellipse; break;
            }
        }

        // -------------------------------------------------------------
        // ukončení programu
        // -------------------------------------------------------------
        private void tsmKonec_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // -------------------------------------------------------------
        // uložení na disk
        // -------------------------------------------------------------
        private void tsmSouborUlozit_Click(object sender, EventArgs e)
        {
            Bitmap bmp =new Bitmap(pbPlatno.Width, pbPlatno.Height);
            Graphics g = Graphics.FromImage(bmp);
            Rectangle rect = pbPlatno.RectangleToScreen(pbPlatno.ClientRectangle);
            g.CopyFromScreen(rect.Location, Point.Empty, pbPlatno.Size);
            g.Dispose();
            SaveFileDialog s = new SaveFileDialog();
            s.Filter = "Png files|*.png|jpeg files|*jpg|bitmaps|*.bmp";
            if(s.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (s.FileName.Contains(".jpg"))
                {
                    bmp.Save(s.FileName, ImageFormat.Jpeg);
                }
                else if (s.FileName.Contains(".png"))
                {
                    bmp.Save(s.FileName, ImageFormat.Png);
                }
                else if (s.FileName.Contains(".bmp"))
                {
                    bmp.Save(s.FileName, ImageFormat.Bmp);
                }
            }

        }

        private void rbLine_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btSave_Click(object sender, EventArgs e)
        {

        }

        private void tsmSouborOtevrit_Click(object sender, EventArgs e)
        {
            OpenFileDialog o = new OpenFileDialog();
            
            o.Filter = "Png files|*.png|jpeg files|*jpg|bitmaps|*.bmp";
            if (o.ShowDialog()==System.Windows.Forms.DialogResult.OK)
            {
                pbPlatno.Image=(Image)Image.FromFile(o.FileName).Clone();
            }
        }

        // -------------------------------------------------------------
        // začátek kreslení na pictureboxem
        // -------------------------------------------------------------
        private void pbPlatno_MouseDown(object sender, MouseEventArgs e)
        {
            mintMouseX = e.X;
            mintMouseY = e.Y;

        }
    }
}

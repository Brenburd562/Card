using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace Card
{
    public partial class Doot : Form
    {
        public Doot()
        {
            InitializeComponent();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            //declartion of tools
            Graphics g = this.CreateGraphics();
            SolidBrush cardback = new SolidBrush(Color.FromArgb(247, 241, 172));
            SolidBrush text1 = new SolidBrush(Color.FromArgb(100, 100, 100));
            SolidBrush trumpetmain = new SolidBrush(Color.FromArgb(251, 202, 9));
            SolidBrush trumpetmain2 = new SolidBrush(Color.FromArgb(100, 100, 100));
            SolidBrush cardborder = new SolidBrush(Color.FromArgb(200, 200, 200));
            Font cardFont = new Font("Arial Black", 14, FontStyle.Bold);
            g.Clear(Color.Black);
            g.FillRectangle(cardback, 45, 20, 600, 370);
            g.FillRectangle(cardborder, 55, 30, 580, 350);
            g.DrawString("DONT ENTER THERE ARE SPOOKY SCARY THINGS!", cardFont, text1, 70, 70);
            //MAKE IT SPOOKY SCARY DOOT TRUMPET HALLOWEEN CARD SKELTONS CAN CAN BABY!
            //START OF TRUMPET CODE
            g.TranslateTransform(250, 30);
            g.RotateTransform(15);
            //trumpet horn part
            g.FillRectangle(trumpetmain, 0, 120, 110, 15);
            g.FillRectangle(trumpetmain, 0, 95, 90, 60);
            g.FillEllipse(cardborder, 0, 70, 200, 50);
            g.FillEllipse(cardborder, 0, 133, 200, 50);
            //rounded rectangle
            g.FillRectangle(trumpetmain, 100, 130, 250, 80);
            g.FillRectangle(trumpetmain, 110, 120, 230, 100);
            g.FillEllipse(trumpetmain, 100, 120, 20, 20);
            g.FillEllipse(trumpetmain, 100, 200, 20, 20);
            g.FillEllipse(trumpetmain, 330, 120, 20, 20);
            g.FillEllipse(trumpetmain, 330, 200, 20, 20);
            //clearing center to create "rounded" loops
            g.FillRectangle(cardborder, 110, 140, 230, 60);
            g.FillRectangle(cardborder, 120, 130, 210, 80);
            g.FillEllipse(cardborder, 110, 130, 20, 20);
            g.FillEllipse(cardborder, 110, 190, 20, 20);
            g.FillEllipse(cardborder, 320, 130, 20, 20);
            g.FillEllipse(cardborder, 320, 190, 20, 20);
            //trumpet button control stick thingys
            g.FillRectangle(trumpetmain, 215, 100, 10, 60);
            g.FillRectangle(trumpetmain, 190, 100, 10, 60);
            g.FillRectangle(trumpetmain, 240, 100, 10, 60);
            //buttons drawing for sticky things above
            g.FillRectangle(trumpetmain, 215, 100, 20, 60);
            g.FillRectangle(trumpetmain, 190, 100, 20, 60);
            g.FillRectangle(trumpetmain, 240, 100, 20, 60);
            g.FillRectangle(trumpetmain, 215, 100, 20, 60);
            g.FillRectangle(trumpetmain, 190, 100, 20, 60);
            g.FillRectangle(trumpetmain, 240, 100, 20, 60);
            g.ResetTransform();
            //END OF TRUMPET CODE
            {

            }
        }

        private void Doot_Click(object sender, EventArgs e)
        {
            //DEC OF VARS
            Graphics g = this.CreateGraphics();
            SolidBrush text = new SolidBrush(Color.FromArgb(255, 0, 0, 0));
            SoundPlayer DOOT = new SoundPlayer(Properties.Resources.skullsound2);
            SolidBrush trumpetmain = new SolidBrush(Color.FromArgb(251, 202, 9));
            SolidBrush trumpetmain2 = new SolidBrush(Color.FromArgb(100, 100, 100));
            SolidBrush cardborder = new SolidBrush(Color.FromArgb(200, 200, 200));
            Font textfont = new Font("Arial Black", 14, FontStyle.Bold);
            //created format to slowly fade away text will repet many times
            g.Clear(Color.Silver);
            g.DrawString("I TOLD YOU NOT TO ENTER!", textfont, text, 200, 70);
            Thread.Sleep(200);
            g.Clear(Color.Silver);
            SolidBrush text1 = new SolidBrush(Color.FromArgb(200, 0, 0, 0));
            g.DrawString("I TOLD YOU NOT TO ENTER!", textfont, text1, 200, 70);
            Thread.Sleep(200);
            g.Clear(Color.Silver);
            SolidBrush text2 = new SolidBrush(Color.FromArgb(150, 0, 0, 0));
            g.DrawString("I TOLD YOU NOT TO ENTER!", textfont, text2, 200, 70);
            Thread.Sleep(200);
            g.Clear(Color.Silver);
            SolidBrush text3 = new SolidBrush(Color.FromArgb(100, 0, 0, 0));
            g.DrawString("I TOLD YOU NOT TO ENTER!", textfont, text3, 200, 70);
            Thread.Sleep(200);
            g.Clear(Color.Silver);
            SolidBrush text4 = new SolidBrush(Color.FromArgb(25, 0, 0, 0));
            g.DrawString("I TOLD YOU NOT TO ENTER!", textfont, text4, 200, 70);
            Thread.Sleep(200);
            g.Clear(Color.FromArgb(200,200,200));
            //START OF TRUMPET CODE
            g.TranslateTransform(20, 050);
            g.RotateTransform(15);
            //trumpet horn part
            g.FillRectangle(trumpetmain, 0, 120, 110, 15);
            g.FillRectangle(trumpetmain, 0, 95, 90, 60);
            g.FillEllipse(cardborder, 0, 70, 200, 50);
            g.FillEllipse(cardborder, 0, 133, 200, 50);
            //rounded rectangle
            g.FillRectangle(trumpetmain, 100, 130, 250, 80);
            g.FillRectangle(trumpetmain, 110, 120, 230, 100);
            g.FillEllipse(trumpetmain, 100, 120, 20, 20);
            g.FillEllipse(trumpetmain, 100, 200, 20, 20);
            g.FillEllipse(trumpetmain, 330, 120, 20, 20);
            g.FillEllipse(trumpetmain, 330, 200, 20, 20);
            //clearing center to create "rounded" loops
            g.FillRectangle(cardborder, 110, 140, 230, 60);
            g.FillRectangle(cardborder, 120, 130, 210, 80);
            g.FillEllipse(cardborder, 110, 130, 20, 20);
            g.FillEllipse(cardborder, 110, 190, 20, 20);
            g.FillEllipse(cardborder, 320, 130, 20, 20);
            g.FillEllipse(cardborder, 320, 190, 20, 20);
            //trumpet button control stick thingys
            g.FillRectangle(trumpetmain, 215, 100, 10, 60);
            g.FillRectangle(trumpetmain, 190, 100, 10, 60);
            g.FillRectangle(trumpetmain, 240, 100, 10, 60);
            //buttons drawing for sticky things above
            g.FillRectangle(trumpetmain, 215, 100, 20, 60);
            g.FillRectangle(trumpetmain, 190, 100, 20, 60);
            g.FillRectangle(trumpetmain, 240, 100, 20, 60);
            g.FillRectangle(trumpetmain, 215, 100, 20, 60);
            g.FillRectangle(trumpetmain, 190, 100, 20, 60);
            g.FillRectangle(trumpetmain, 240, 100, 20, 60);
            g.ResetTransform();
            //END OF TRUMPET CODE
            DOOT.Play();
            Thread.Sleep(1000);
            //START OF TRUMPET CODE
            g.TranslateTransform(500, 0);
            g.RotateTransform(80);
            //trumpet horn part
            g.FillRectangle(trumpetmain, 0, 120, 110, 15);
            g.FillRectangle(trumpetmain, 0, 95, 90, 60);
            g.FillEllipse(cardborder, 0, 70, 200, 50);
            g.FillEllipse(cardborder, 0, 133, 200, 50);
            //rounded rectangle
            g.FillRectangle(trumpetmain, 100, 130, 250, 80);
            g.FillRectangle(trumpetmain, 110, 120, 230, 100);
            g.FillEllipse(trumpetmain, 100, 120, 20, 20);
            g.FillEllipse(trumpetmain, 100, 200, 20, 20);
            g.FillEllipse(trumpetmain, 330, 120, 20, 20);
            g.FillEllipse(trumpetmain, 330, 200, 20, 20);
            //clearing center to create "rounded" loops
            g.FillRectangle(cardborder, 110, 140, 230, 60);
            g.FillRectangle(cardborder, 120, 130, 210, 80);
            g.FillEllipse(cardborder, 110, 130, 20, 20);
            g.FillEllipse(cardborder, 110, 190, 20, 20);
            g.FillEllipse(cardborder, 320, 130, 20, 20);
            g.FillEllipse(cardborder, 320, 190, 20, 20);
            //trumpet button control stick thingys
            g.FillRectangle(trumpetmain, 215, 100, 10, 60);
            g.FillRectangle(trumpetmain, 190, 100, 10, 60);
            g.FillRectangle(trumpetmain, 240, 100, 10, 60);
            //buttons drawing for sticky things above
            g.FillRectangle(trumpetmain, 215, 100, 20, 60);
            g.FillRectangle(trumpetmain, 190, 100, 20, 60);
            g.FillRectangle(trumpetmain, 240, 100, 20, 60);
            g.FillRectangle(trumpetmain, 215, 100, 20, 60);
            g.FillRectangle(trumpetmain, 190, 100, 20, 60);
            g.FillRectangle(trumpetmain, 240, 100, 20, 60);
            g.ResetTransform();
            //END OF TRUMPET CODE
            DOOT.Play();
            Thread.Sleep(1000);
            //START OF TRUMPET CODE
            g.TranslateTransform(400, 0);
            g.RotateTransform(350);
            //trumpet horn part
            g.FillRectangle(trumpetmain, 0, 120, 110, 15);
            g.FillRectangle(trumpetmain, 0, 95, 90, 60);
            g.FillEllipse(cardborder, 0, 70, 200, 50);
            g.FillEllipse(cardborder, 0, 133, 200, 50);
            //rounded rectangle
            g.FillRectangle(trumpetmain, 100, 130, 250, 80);
            g.FillRectangle(trumpetmain, 110, 120, 230, 100);
            g.FillEllipse(trumpetmain, 100, 120, 20, 20);
            g.FillEllipse(trumpetmain, 100, 200, 20, 20);
            g.FillEllipse(trumpetmain, 330, 120, 20, 20);
            g.FillEllipse(trumpetmain, 330, 200, 20, 20);
            //clearing center to create "rounded" loops
            g.FillRectangle(cardborder, 110, 140, 230, 60);
            g.FillRectangle(cardborder, 120, 130, 210, 80);
            g.FillEllipse(cardborder, 110, 130, 20, 20);
            g.FillEllipse(cardborder, 110, 190, 20, 20);
            g.FillEllipse(cardborder, 320, 130, 20, 20);
            g.FillEllipse(cardborder, 320, 190, 20, 20);
            //trumpet button control stick thingys
            g.FillRectangle(trumpetmain, 215, 100, 10, 60);
            g.FillRectangle(trumpetmain, 190, 100, 10, 60);
            g.FillRectangle(trumpetmain, 240, 100, 10, 60);
            //buttons drawing for sticky things above
            g.FillRectangle(trumpetmain, 215, 100, 20, 60);
            g.FillRectangle(trumpetmain, 190, 100, 20, 60);
            g.FillRectangle(trumpetmain, 240, 100, 20, 60);
            g.FillRectangle(trumpetmain, 215, 100, 20, 60);
            g.FillRectangle(trumpetmain, 190, 100, 20, 60);
            g.FillRectangle(trumpetmain, 240, 100, 20, 60);
            g.ResetTransform();
            //END OF TRUMPET CODE
            DOOT.Play();
            Thread.Sleep(1000);
            //START OF TRUMPET CODE
            g.TranslateTransform(400, 20);
            g.RotateTransform(130);
            //trumpet horn part
            g.FillRectangle(trumpetmain, 0, 120, 110, 15);
            g.FillRectangle(trumpetmain, 0, 95, 90, 60);
            g.FillEllipse(cardborder, 0, 70, 200, 50);
            g.FillEllipse(cardborder, 0, 133, 200, 50);
            //rounded rectangle
            g.FillRectangle(trumpetmain, 100, 130, 250, 80);
            g.FillRectangle(trumpetmain, 110, 120, 230, 100);
            g.FillEllipse(trumpetmain, 100, 120, 20, 20);
            g.FillEllipse(trumpetmain, 100, 200, 20, 20);
            g.FillEllipse(trumpetmain, 330, 120, 20, 20);
            g.FillEllipse(trumpetmain, 330, 200, 20, 20);
            //clearing center to create "rounded" loops
            g.FillRectangle(cardborder, 110, 140, 230, 60);
            g.FillRectangle(cardborder, 120, 130, 210, 80);
            g.FillEllipse(cardborder, 110, 130, 20, 20);
            g.FillEllipse(cardborder, 110, 190, 20, 20);
            g.FillEllipse(cardborder, 320, 130, 20, 20);
            g.FillEllipse(cardborder, 320, 190, 20, 20);
            //trumpet button control stick thingys
            g.FillRectangle(trumpetmain, 215, 100, 10, 60);
            g.FillRectangle(trumpetmain, 190, 100, 10, 60);
            g.FillRectangle(trumpetmain, 240, 100, 10, 60);
            //buttons drawing for sticky things above
            g.FillRectangle(trumpetmain, 215, 100, 20, 60);
            g.FillRectangle(trumpetmain, 190, 100, 20, 60);
            g.FillRectangle(trumpetmain, 240, 100, 20, 60);
            g.FillRectangle(trumpetmain, 215, 100, 20, 60);
            g.FillRectangle(trumpetmain, 190, 100, 20, 60);
            g.FillRectangle(trumpetmain, 240, 100, 20, 60);
            g.ResetTransform();
            //END OF TRUMPET CODE
            DOOT.Play();
        }
    }
}

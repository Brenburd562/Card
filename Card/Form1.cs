﻿using System;
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

//Brendan Burdett (Card) 24/09/19
//a spook_tober card with a doom theme

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
            SolidBrush cardBack = new SolidBrush(Color.FromArgb(247, 241, 172));
            SolidBrush text1 = new SolidBrush(Color.FromArgb(100, 100, 100));
            SolidBrush trumpetMain = new SolidBrush(Color.FromArgb(251, 202, 9));
            SolidBrush trumpetMain2 = new SolidBrush(Color.FromArgb(100, 100, 100));
            SolidBrush cardBorder = new SolidBrush(Color.FromArgb(200, 200, 200));
            Font cardFont = new Font("Arial Black", 14, FontStyle.Bold);

            //title card
            g.Clear(Color.Black);
            g.FillRectangle(cardBack, 45, 20, 600, 370);
            g.FillRectangle(cardBorder, 55, 30, 580, 350);
            g.DrawString("DONT ENTER THERE ARE SPOOKY SCARY THINGS!", cardFont, text1, 70, 70);

            //START OF TRUMPET CODE
            g.TranslateTransform(250, 30);
            g.RotateTransform(15);
            //trumpet horn part
            g.FillRectangle(trumpetMain, 0, 120, 110, 15);
            g.FillRectangle(trumpetMain, 0, 95, 90, 60);
            g.FillEllipse(cardBorder, 0, 70, 200, 50);
            g.FillEllipse(cardBorder, 0, 133, 200, 50);
            //rounded rectangle
            g.FillRectangle(trumpetMain, 100, 130, 250, 80);
            g.FillRectangle(trumpetMain, 110, 120, 230, 100);
            g.FillEllipse(trumpetMain, 100, 120, 20, 20);
            g.FillEllipse(trumpetMain, 100, 200, 20, 20);
            g.FillEllipse(trumpetMain, 330, 120, 20, 20);
            g.FillEllipse(trumpetMain, 330, 200, 20, 20);
            //clearing center to create "rounded" loops
            g.FillRectangle(cardBorder, 110, 140, 230, 60);
            g.FillRectangle(cardBorder, 120, 130, 210, 80);
            g.FillEllipse(cardBorder, 110, 130, 20, 20);
            g.FillEllipse(cardBorder, 110, 190, 20, 20);
            g.FillEllipse(cardBorder, 320, 130, 20, 20);
            g.FillEllipse(cardBorder, 320, 190, 20, 20);
            //trumpet button control stick thingys
            g.FillRectangle(trumpetMain, 215, 100, 10, 60);
            g.FillRectangle(trumpetMain, 190, 100, 10, 60);
            g.FillRectangle(trumpetMain, 240, 100, 10, 60);
            //buttons drawing for sticky things above
            g.FillRectangle(trumpetMain, 215, 100, 20, 60);
            g.FillRectangle(trumpetMain, 190, 100, 20, 60);
            g.FillRectangle(trumpetMain, 240, 100, 20, 60);
            g.FillRectangle(trumpetMain, 215, 100, 20, 60);
            g.FillRectangle(trumpetMain, 190, 100, 20, 60);
            g.FillRectangle(trumpetMain, 240, 100, 20, 60);
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
            SoundPlayer DOOM = new SoundPlayer(Properties.Resources.e1m1___at_doom_s_gate);
            SolidBrush trumpetMain = new SolidBrush(Color.FromArgb(251, 202, 9));
            SolidBrush cardBorder = new SolidBrush(Color.FromArgb(200, 200, 200));
            Font textFont = new Font("Arial Black", 14, FontStyle.Bold);
            Font textFont2 = new Font("Times new Roman", 25, FontStyle.Bold);

            //created format to slowly fade away text will repet many times
            g.Clear(Color.FromArgb(200, 200, 200));
            g.DrawString("I TOLD YOU NOT TO ENTER!", textFont, text, 200, 70);
            Thread.Sleep(200);
            g.Clear(Color.FromArgb(200, 200, 200));
            SolidBrush text1 = new SolidBrush(Color.FromArgb(200, 0, 0, 0));
            g.DrawString("I TOLD YOU NOT TO ENTER!", textFont, text1, 200, 70);
            Thread.Sleep(200);
            g.Clear(Color.FromArgb(200, 200, 200));
            SolidBrush text2 = new SolidBrush(Color.FromArgb(150, 0, 0, 0));
            g.DrawString("I TOLD YOU NOT TO ENTER!", textFont, text2, 200, 70);
            Thread.Sleep(200);
            g.Clear(Color.FromArgb(200, 200, 200));
            SolidBrush text3 = new SolidBrush(Color.FromArgb(100, 0, 0, 0));
            g.DrawString("I TOLD YOU NOT TO ENTER!", textFont, text3, 200, 70);
            Thread.Sleep(200);
            g.Clear(Color.FromArgb(200, 200, 200));
            SolidBrush text4 = new SolidBrush(Color.FromArgb(25, 0, 0, 0));
            g.DrawString("I TOLD YOU NOT TO ENTER!", textFont, text4, 200, 70);
            Thread.Sleep(200);
            g.Clear(Color.FromArgb(200,200,200));

            //START OF TRUMPET CODE
            g.TranslateTransform(20, 050);
            g.RotateTransform(15);
            //trumpet horn part
            g.FillRectangle(trumpetMain, 0, 120, 110, 15);
            g.FillRectangle(trumpetMain, 0, 95, 90, 60);
            g.FillEllipse(cardBorder, 0, 70, 200, 50);
            g.FillEllipse(cardBorder, 0, 133, 200, 50);
            //rounded rectangle
            g.FillRectangle(trumpetMain, 100, 130, 250, 80);
            g.FillRectangle(trumpetMain, 110, 120, 230, 100);
            g.FillEllipse(trumpetMain, 100, 120, 20, 20);
            g.FillEllipse(trumpetMain, 100, 200, 20, 20);
            g.FillEllipse(trumpetMain, 330, 120, 20, 20);
            g.FillEllipse(trumpetMain, 330, 200, 20, 20);
            //clearing center to create "rounded" loops
            g.FillRectangle(cardBorder, 110, 140, 230, 60);
            g.FillRectangle(cardBorder, 120, 130, 210, 80);
            g.FillEllipse(cardBorder, 110, 130, 20, 20);
            g.FillEllipse(cardBorder, 110, 190, 20, 20);
            g.FillEllipse(cardBorder, 320, 130, 20, 20);
            g.FillEllipse(cardBorder, 320, 190, 20, 20);
            //trumpet button control stick thingys
            g.FillRectangle(trumpetMain, 215, 100, 10, 60);
            g.FillRectangle(trumpetMain, 190, 100, 10, 60);
            g.FillRectangle(trumpetMain, 240, 100, 10, 60);
            //buttons drawing for sticky things above
            g.FillRectangle(trumpetMain, 215, 100, 20, 60);
            g.FillRectangle(trumpetMain, 190, 100, 20, 60);
            g.FillRectangle(trumpetMain, 240, 100, 20, 60);
            g.FillRectangle(trumpetMain, 215, 100, 20, 60);
            g.FillRectangle(trumpetMain, 190, 100, 20, 60);
            g.FillRectangle(trumpetMain, 240, 100, 20, 60);
            g.ResetTransform();
            //END OF TRUMPET CODE
            DOOT.Play();
            Thread.Sleep(1000);

            //START OF TRUMPET CODE
            g.TranslateTransform(500, 0);
            g.RotateTransform(80);
            //trumpet horn part
            g.FillRectangle(trumpetMain, 0, 120, 110, 15);
            g.FillRectangle(trumpetMain, 0, 95, 90, 60);
            g.FillEllipse(cardBorder, 0, 70, 200, 50);
            g.FillEllipse(cardBorder, 0, 133, 200, 50);
            //rounded rectangle
            g.FillRectangle(trumpetMain, 100, 130, 250, 80);
            g.FillRectangle(trumpetMain, 110, 120, 230, 100);
            g.FillEllipse(trumpetMain, 100, 120, 20, 20);
            g.FillEllipse(trumpetMain, 100, 200, 20, 20);
            g.FillEllipse(trumpetMain, 330, 120, 20, 20);
            g.FillEllipse(trumpetMain, 330, 200, 20, 20);
            //clearing center to create "rounded" loops
            g.FillRectangle(cardBorder, 110, 140, 230, 60);
            g.FillRectangle(cardBorder, 120, 130, 210, 80);
            g.FillEllipse(cardBorder, 110, 130, 20, 20);
            g.FillEllipse(cardBorder, 110, 190, 20, 20);
            g.FillEllipse(cardBorder, 320, 130, 20, 20);
            g.FillEllipse(cardBorder, 320, 190, 20, 20);
            //trumpet button control stick thingys
            g.FillRectangle(trumpetMain, 215, 100, 10, 60);
            g.FillRectangle(trumpetMain, 190, 100, 10, 60);
            g.FillRectangle(trumpetMain, 240, 100, 10, 60);
            //buttons drawing for sticky things above
            g.FillRectangle(trumpetMain, 215, 100, 20, 60);
            g.FillRectangle(trumpetMain, 190, 100, 20, 60);
            g.FillRectangle(trumpetMain, 240, 100, 20, 60);
            g.FillRectangle(trumpetMain, 215, 100, 20, 60);
            g.FillRectangle(trumpetMain, 190, 100, 20, 60);
            g.FillRectangle(trumpetMain, 240, 100, 20, 60);
            g.ResetTransform();
            //END OF TRUMPET CODE
            DOOT.Play();
            Thread.Sleep(1000);

            //START OF TRUMPET CODE
            g.TranslateTransform(400, 0);
            g.RotateTransform(350);
            //trumpet horn part
            g.FillRectangle(trumpetMain, 0, 120, 110, 15);
            g.FillRectangle(trumpetMain, 0, 95, 90, 60);
            g.FillEllipse(cardBorder, 0, 70, 200, 50);
            g.FillEllipse(cardBorder, 0, 133, 200, 50);
            //rounded rectangle
            g.FillRectangle(trumpetMain, 100, 130, 250, 80);
            g.FillRectangle(trumpetMain, 110, 120, 230, 100);
            g.FillEllipse(trumpetMain, 100, 120, 20, 20);
            g.FillEllipse(trumpetMain, 100, 200, 20, 20);
            g.FillEllipse(trumpetMain, 330, 120, 20, 20);
            g.FillEllipse(trumpetMain, 330, 200, 20, 20);
            //clearing center to create "rounded" loops
            g.FillRectangle(cardBorder, 110, 140, 230, 60);
            g.FillRectangle(cardBorder, 120, 130, 210, 80);
            g.FillEllipse(cardBorder, 110, 130, 20, 20);
            g.FillEllipse(cardBorder, 110, 190, 20, 20);
            g.FillEllipse(cardBorder, 320, 130, 20, 20);
            g.FillEllipse(cardBorder, 320, 190, 20, 20);
            //trumpet button control stick thingys
            g.FillRectangle(trumpetMain, 215, 100, 10, 60);
            g.FillRectangle(trumpetMain, 190, 100, 10, 60);
            g.FillRectangle(trumpetMain, 240, 100, 10, 60);
            //buttons drawing for sticky things above
            g.FillRectangle(trumpetMain, 215, 100, 20, 60);
            g.FillRectangle(trumpetMain, 190, 100, 20, 60);
            g.FillRectangle(trumpetMain, 240, 100, 20, 60);
            g.FillRectangle(trumpetMain, 215, 100, 20, 60);
            g.FillRectangle(trumpetMain, 190, 100, 20, 60);
            g.FillRectangle(trumpetMain, 240, 100, 20, 60);
            g.ResetTransform();
            //END OF TRUMPET CODE
            DOOT.Play();
            Thread.Sleep(1000);

            //START OF TRUMPET CODE
            g.TranslateTransform(400, 20);
            g.RotateTransform(130);
            //trumpet horn part
            g.FillRectangle(trumpetMain, 0, 120, 110, 15);
            g.FillRectangle(trumpetMain, 0, 95, 90, 60);
            g.FillEllipse(cardBorder, 0, 70, 200, 50);
            g.FillEllipse(cardBorder, 0, 133, 200, 50);
            //rounded rectangle
            g.FillRectangle(trumpetMain, 100, 130, 250, 80);
            g.FillRectangle(trumpetMain, 110, 120, 230, 100);
            g.FillEllipse(trumpetMain, 100, 120, 20, 20);
            g.FillEllipse(trumpetMain, 100, 200, 20, 20);
            g.FillEllipse(trumpetMain, 330, 120, 20, 20);
            g.FillEllipse(trumpetMain, 330, 200, 20, 20);
            //clearing center to create "rounded" loops
            g.FillRectangle(cardBorder, 110, 140, 230, 60);
            g.FillRectangle(cardBorder, 120, 130, 210, 80);
            g.FillEllipse(cardBorder, 110, 130, 20, 20);
            g.FillEllipse(cardBorder, 110, 190, 20, 20);
            g.FillEllipse(cardBorder, 320, 130, 20, 20);
            g.FillEllipse(cardBorder, 320, 190, 20, 20);
            //trumpet button control stick thingys
            g.FillRectangle(trumpetMain, 215, 100, 10, 60);
            g.FillRectangle(trumpetMain, 190, 100, 10, 60);
            g.FillRectangle(trumpetMain, 240, 100, 10, 60);
            //buttons drawing for sticky things above
            g.FillRectangle(trumpetMain, 215, 100, 20, 60);
            g.FillRectangle(trumpetMain, 190, 100, 20, 60);
            g.FillRectangle(trumpetMain, 240, 100, 20, 60);
            g.FillRectangle(trumpetMain, 215, 100, 20, 60);
            g.FillRectangle(trumpetMain, 190, 100, 20, 60);
            g.FillRectangle(trumpetMain, 240, 100, 20, 60);
            g.ResetTransform();
            //END OF TRUMPET CODE
            DOOT.Play();
            Thread.Sleep(2000);

            //end screen
            g.Clear(Color.FromArgb(255, 100, 100));
            g.FillRectangle(trumpetMain, 200, 200, 300, 50);
            g.DrawString("Happy Spook-tober", textFont2, text1, 200, 200);
            DOOM.Play();
        }
    }
}

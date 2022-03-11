using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Slot
{
    public partial class Form1 : Form
    {
        public Image Pic777;
        public Image PicBar;
        public Image PicCherry;
        public Image PicClover;
        public Image PicDiamond;
        public Image PicGrapes;
        public Image PicLemon;
        public Image PicBigWin;
        public Image PicCrown;
        public Form1()
        {
            InitializeComponent();
            Pic777 = btn1.Image;
            PicDiamond = btn2.Image;
            PicBar = btn3.Image;
            PicClover = btn4.Image;
            PicLemon = btn5.Image;
            PicGrapes = btn6.Image;
            PicCherry = btn7.Image;
            PicBigWin = btn8.Image;
            PicCrown = btn9.Image;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSpin_Click(object sender, EventArgs e)
        {

        }

        public void Spin() //Srartet den Spin-Vorgang so das sich alle Reihen nach einander und dann Permanent drehen.
        {

        }

        private void btnStop_Click(object sender, EventArgs e)
        {

        }

        public void Stop() //Stopt den Spin-Vorgang so das der Win berechnet werden kann.
        {

        }

        public void GetBtnImange()
        {
           
        }
    }
}

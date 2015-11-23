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

namespace Stars
{
    public partial class Form1 : Form
    {
        public static Random randNum = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StarField(500);
        }

        public void StarField(int starNum)
        {

            Graphics swag = this.CreateGraphics();
            SolidBrush starBrush = new SolidBrush(Color.White);

            int counter = 0;
            while (counter < starNum)
            {
                //colours
                int r = randNum.Next(1, 254);
                int g = randNum.Next(1, 254);
                int b = randNum.Next(1, 254);
                //location
                int x = randNum.Next(1, 401);
                int y = randNum.Next(1, 401);

                starBrush.Color = Color.FromArgb(r, g, b);
                swag.FillEllipse(starBrush, x, y, 15, 15);
                Thread.Sleep(50);
                counter++;
            }
        }
    }
}

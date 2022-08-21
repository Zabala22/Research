using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Research
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.InitializeComponent();
            image.Visible = false;
            image1.Visible = false;
            image2.Visible = false;
            image3.Visible = false;
            image4.Visible = false;
            image5.Visible = false;
            image6.Visible = false;
            image7.Visible = false;
            image8.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int x = nobutton.Location.X;
            int y = nobutton.Location.Y;
            nobutton.Location = new Point(528, 175);
            image.Visible = true;

            if (x == 528)
            {
                nobutton.Location = new Point(12, 12);
                yesbutton.Width = 91;
                yesbutton.Height = 47;
            }
            if (x == 12)
            {
                nobutton.Location = new Point(738, 517);
                
            }
            if (x == 738)
            {
                nobutton.Location = new Point(109, 377);
                yesbutton.Width = 101;
                yesbutton.Height = 57;
            }
            if (x == 109)
            {
                nobutton.Location = new Point(528, 175);
                image1.Visible = true;

            }
            if (x == 528)
            {
                nobutton.Location = new Point(12, 12);
                yesbutton.Width = 106;
                yesbutton.Height = 62;
                image2.Visible = true;
            }
            if (x == 12)
            {
                nobutton.Location = new Point(738, 517);
                image3.Visible = true;

            }
            if (x == 738)
            {
                nobutton.Location = new Point(109, 377);
                yesbutton.Width = 111;
                yesbutton.Height = 67;
                image4.Visible = true;
            }
            if (x == 109)
            {
                nobutton.Location = new Point(394, 399);
                image5.Visible = true;

            }
            if (x == 394)
            {
                nobutton.Location = new Point(606, 118);
                image6.Visible = true;

            }
            if (x == 606)
            {
                nobutton.Location = new Point(179, 187);
                image7.Visible = true;


            }
            if (x == 179)
            {
                nobutton.Location = new Point(437, 276);
                nobutton.Enabled = false;
                image8.Visible = true;

            }
        }

        private void yesbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.Show();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

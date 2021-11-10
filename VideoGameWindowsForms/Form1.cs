using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoGameWindowsForms
{
    public partial class Form1 : Form
    {
        private int valueX, valueY;

        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;
            panel3.Visible = false;
            valueX = 10;
            valueY = 10;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button10.SetBounds(valueX += 10,10,50,50);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button10.SetBounds(valueX, valueY += 10, 50, 50);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button10.SetBounds(valueX -= 10, 10, 50, 50);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            this.panel3.Visible = false;
            this.panel2.Visible = false;            
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Button[] btn = { button4, button5, button6, button7, button8, button9, button10, button11 };

            for (int i = 0; i < btn.Length; i++)
            {
                btn[i].Visible = true;
            }


            panel3.Visible = false;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            Button[] btn = { button4 , button5, button6, button7, button8, button9, button10, button11 };

            for(int i = 0; i < btn.Length; i++)
            {
                btn[i].Visible = false;
            }

            panel3.Visible = true;
    

        }

        private void button6_Click(object sender, EventArgs e)
        {
            button10.SetBounds(valueX, valueY -= 10, 50, 50);
        }
    }
}

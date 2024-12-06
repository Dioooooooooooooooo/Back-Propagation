using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Backprop;

namespace BFNN
{
    public partial class Form1 : Form
    {

        NeuralNet nn;

        int[,] truthTable = new int[16, 5]
        {
            {0, 0, 0, 0, 0},
            {0, 0, 0, 1, 0},
            {0, 0, 1, 0, 0},
            {0, 0, 1, 1, 0},
            {0, 1, 0, 0, 0},
            {0, 1, 0, 1, 0},
            {0, 1, 1, 0, 0},
            {0, 1, 1, 1, 0},
            {1, 0, 0, 0, 0},
            {1, 0, 0, 1, 0},
            {1, 0, 1, 0, 0},
            {1, 0, 1, 1, 0},
            {1, 1, 0, 0, 0},
            {1, 1, 0, 1, 0},
            {1, 1, 1, 0, 0},
            {1, 1, 1, 1, 1}
        };

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            nn=new NeuralNet(4,8,1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 200; i++)
            {


                for (int row = 0; row < truthTable.GetLength(0); row++)
                {
                    for (int j = 0; j < truthTable.GetLength(1) - 1; j++)
                    {
                        Console.WriteLine("val of j: " + j);
                        nn.setInputs(j, Convert.ToDouble(truthTable[row, j]));
                    }

                    nn.setDesiredOutput(0, Convert.ToDouble(truthTable[row, 4]));
                    nn.learn();
                }
                
            }

            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            nn.setInputs(0, Convert.ToDouble(textBox1.Text));
            nn.setInputs(1, Convert.ToDouble(textBox2.Text));
            nn.setInputs(2, Convert.ToDouble(textBox3.Text));
            nn.setInputs(3, Convert.ToDouble(textBox4.Text));
            nn.run();

            textBox5.Text =""+nn.getOuputData(0);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

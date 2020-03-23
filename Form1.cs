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

namespace DiceRandomizer
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (File.Exists("names.txt"))
            {
                try
                {
                    string[] allLines1 = File.ReadAllLines("names.txt");
                    Random rnd1 = new Random();
                    label1.Text = (allLines1[rnd1.Next(allLines1.Length)]);
                }
                catch (Exception)
                {
                    MessageBox.Show("Add names below each other in the names.txt file", "No names found!");
                }
            }
            else
            {
                File.Create("names.txt").Dispose();
                MessageBox.Show("Add names below each other in the names.txt file", "Add names to the file!");
            }

            if (File.Exists("jokes.txt"))
            {
                try
                {
                    string[] allLines2 = File.ReadAllLines("jokes.txt");
                    Random rnd2 = new Random();
                    label2.Text = (allLines2[rnd2.Next(allLines2.Length)]);
                }
                catch (Exception)
                {
                    MessageBox.Show("Add jokes below each other in the jokes.txt file", "No jokes found!");
                }
            }
            else
            {
                File.Create("jokes.txt").Dispose();
                MessageBox.Show("Add jokes below each other in the jokes.txt file", "Add jokes to the file!");
            }
        }
    }
}

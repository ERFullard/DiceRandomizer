using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiceRandomizer
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        private int timer_count;

        public Form1()
        {
            InitializeComponent();

            this.Timer.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer_count = 11;

            timer1.Start();
            Timer.Visible = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            if (timer_count > 0)
            {
                timer_count--;
                Thread.Sleep(500);
                this.Timer.Text = timer_count.ToString();
                Randomize();
            }
            else
            { 
                timer1.Stop();
                Timer.Text = "Tag, you're it!";
            }
        }

        public void Randomize()
        {
            if (File.Exists("names.txt"))
            {
                try
                {
                    string[] allLines1 = File.ReadAllLines("names.txt");
                    Random rnd1 = new Random();
                    UserName.Text = (allLines1[rnd1.Next(allLines1.Length)]);
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
                    JokeType.Text = (allLines2[rnd2.Next(allLines2.Length)]);
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

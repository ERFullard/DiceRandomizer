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
        private int totalseconds;

        public Form1()
        {
            InitializeComponent();

            this.Timer.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            totalseconds = 6;

            timer1.Start();
            Timer.Visible = true;
            Name.Visible = false;
            JokeType.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            if (totalseconds > 0)
            {
                totalseconds--;
                Thread.Sleep(500);
                Randomize();
                this.Timer.Text = totalseconds.ToString();
            }
            else
            { 
                timer1.Stop();
                Timer.Text = "";
                Timer.Visible = false;
                Name.Visible = true;
                JokeType.Visible = true;
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
                    Name.Text = (allLines1[rnd1.Next(allLines1.Length)]);
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

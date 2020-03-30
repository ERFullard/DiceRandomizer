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
        private int timer_count = 0;

        public Form1()
        {
            InitializeComponent();

            Timer.Text = "";
            CheckFiles();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer_count = 11;

            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timer_count > 0)
            {
                timer_count--;
                Thread.Sleep(500);
                Timer.Text = timer_count.ToString();
                Randomize();
            }
            else
            { 
                timer1.Stop();
                Timer.Text = "Tag, you're it!";
            }
        }

        public void CheckFiles()
        {
            if (File.Exists("names.txt"))
            {
                if (File.ReadAllLines("names.txt").Length == 0)
                {
                    MessageBox.Show("Add names below each other in the names.txt file. The application will now close.", "No names found!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Environment.Exit(0);
                }
            }
            else
            {
                File.Create("names.txt").Dispose();
                MessageBox.Show("File names.txt created. Add names below each other in the names.txt file. The application will now close.", "Add names to the file!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(0);
            }

            if (File.Exists("jokes.txt"))
            {
                if (File.ReadAllLines("jokes.txt").Length == 0)
                {
                    MessageBox.Show("Add jokes below each other in the jokes.txt file. The application will now close.", "No jokes found!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Environment.Exit(0);
                }
            }
            else
            {
                File.Create("jokes.txt").Dispose();
                MessageBox.Show("File jokes.txt created. Add jokes below each other in the jokes.txt file. The application will now close.", "Add jokes to the file!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(0);
            }
        }

        public void Randomize()
        {
            try
            {
                string[] allLines1 = File.ReadAllLines("names.txt");
                Random rnd1 = new Random();
                UserName.Text = (allLines1[rnd1.Next(allLines1.Length)]);
            }
            catch(IndexOutOfRangeException)
            {
                MessageBox.Show("Add names below each other in the names.txt file. The application will now close.", "No names found!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(0);
            }

            try
            {
                string[] allLines2 = File.ReadAllLines("jokes.txt");
                Random rnd2 = new Random();
                JokeType.Text = (allLines2[rnd2.Next(allLines2.Length)]);
            }
            catch(IndexOutOfRangeException)
            {
                MessageBox.Show("Add jokes below each other in the jokes.txt file. The application will now close.", "No jokes found!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(0);
            }
        }
    }
}

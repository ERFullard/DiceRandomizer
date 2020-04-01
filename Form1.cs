using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace DiceRandomizer
{
    public partial class Form1 : MetroForm
    {
        private int _timerCount = 0;
        private List<string> _names = new List<string>();
        private List<string> _jokes = new List<string>();
        private Random _randomizer = new Random();

        public Form1()
        {
            InitializeComponent();

            Timer.Text = "";

            CheckFiles();
        }

        private void CheckFiles()
        {
            if (File.Exists("names.txt"))
            {
                try
                {
                    foreach (var name in File.ReadAllLines("names.txt"))
                    {
                        NamesCheckList.Items.Add(name, true);
                    }
                }
                catch (Exception)
                {
                    ShowErrorAndExit(
                        "Add names below each other in the names.txt file. The application will now close.",
                        "No names found!");
                }
            }
            else
            {
                File.Create("names.txt").Dispose();
                ShowErrorAndExit(
                    "File names.txt created. Add names below each other in the names.txt file. The application will now close.",
                    "Add names to the file!");
            }

            if (File.Exists("jokes.txt"))
            {
                try
                {
                    _jokes = File.ReadAllLines("jokes.txt").ToList();
                }
                catch (Exception)
                {
                    ShowErrorAndExit(
                        "Add jokes below each other in the jokes.txt file. The application will now close.",
                        "No jokes found!");
                }
            }
            else
            {
                File.Create("jokes.txt").Dispose();
                ShowErrorAndExit(
                    "File jokes.txt created. Add jokes below each other in the jokes.txt file. The application will now close.",
                    "Add jokes to the file!");
            }
        }

        private static void ShowErrorAndExit(string message, string title)
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
            Environment.Exit(0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _timerCount = 30;

            _names = NamesCheckList.CheckedItems.Cast<string>().ToList();

            Timer.Text = "";
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (_timerCount > 0)
            {
                _timerCount--;
                Thread.Sleep(100);
                Randomize();
            }
            else
            {
                timer1.Stop();
                Timer.Text = @"Tag, you're it!";
            }
        }

        public void Randomize()
        {
            UserName.Text = _names[_randomizer.Next(_names.Count)];
            JokeType.Text = _jokes[_randomizer.Next(_jokes.Count)];
        }
    }
}
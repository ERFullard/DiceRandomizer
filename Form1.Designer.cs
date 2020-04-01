namespace DiceRandomizer
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.UserName = new System.Windows.Forms.Label();
            this.JokeType = new System.Windows.Forms.Label();
            this.Timer = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.NamesCheckList = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.button1.Location = new System.Drawing.Point(269, 305);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(443, 58);
            this.button1.TabIndex = 0;
            this.button1.Text = "Randomize";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // UserName
            // 
            this.UserName.AutoSize = true;
            this.UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.UserName.Location = new System.Drawing.Point(269, 95);
            this.UserName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(252, 91);
            this.UserName.TabIndex = 2;
            this.UserName.Text = "Name";
            // 
            // JokeType
            // 
            this.JokeType.AutoSize = true;
            this.JokeType.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.JokeType.Location = new System.Drawing.Point(269, 186);
            this.JokeType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.JokeType.Name = "JokeType";
            this.JokeType.Size = new System.Drawing.Size(405, 91);
            this.JokeType.TabIndex = 3;
            this.JokeType.Text = "Joke Type";
            // 
            // Timer
            // 
            this.Timer.AutoSize = true;
            this.Timer.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.Timer.Location = new System.Drawing.Point(269, 387);
            this.Timer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Timer.Name = "Timer";
            this.Timer.Size = new System.Drawing.Size(243, 91);
            this.Timer.TabIndex = 4;
            this.Timer.Text = "Timer";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // NamesCheckList
            // 
            this.NamesCheckList.FormattingEnabled = true;
            this.NamesCheckList.Location = new System.Drawing.Point(26, 108);
            this.NamesCheckList.Name = "NamesCheckList";
            this.NamesCheckList.Size = new System.Drawing.Size(203, 400);
            this.NamesCheckList.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 584);
            this.Controls.Add(this.NamesCheckList);
            this.Controls.Add(this.Timer);
            this.Controls.Add(this.JokeType);
            this.Controls.Add(this.UserName);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(17, 60, 17, 18);
            this.Text = "Stand-up Meeting";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label UserName;
        private System.Windows.Forms.Label JokeType;
        private System.Windows.Forms.Label Timer;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.CheckedListBox NamesCheckList;
    }
}


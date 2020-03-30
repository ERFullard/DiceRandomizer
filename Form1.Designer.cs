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
            this.Name = new System.Windows.Forms.Label();
            this.JokeType = new System.Windows.Forms.Label();
            this.Timer = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(68, 368);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(205, 143);
            this.button1.TabIndex = 0;
            this.button1.Text = "Randomize";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name.Location = new System.Drawing.Point(49, 94);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(315, 113);
            this.Name.TabIndex = 2;
            this.Name.Text = "Name";
            // 
            // JokeType
            // 
            this.JokeType.AutoSize = true;
            this.JokeType.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JokeType.Location = new System.Drawing.Point(49, 225);
            this.JokeType.Name = "JokeType";
            this.JokeType.Size = new System.Drawing.Size(510, 113);
            this.JokeType.TabIndex = 3;
            this.JokeType.Text = "Joke Type";
            // 
            // Timer
            // 
            this.Timer.AutoSize = true;
            this.Timer.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Timer.Location = new System.Drawing.Point(326, 381);
            this.Timer.Name = "Timer";
            this.Timer.Size = new System.Drawing.Size(304, 113);
            this.Timer.TabIndex = 4;
            this.Timer.Text = "Timer";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 623);
            this.Controls.Add(this.Timer);
            this.Controls.Add(this.JokeType);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.button1);
            this.Text = "Stand-up Meeting";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Name;
        private System.Windows.Forms.Label JokeType;
        private System.Windows.Forms.Label Timer;
        private System.Windows.Forms.Timer timer1;
    }
}


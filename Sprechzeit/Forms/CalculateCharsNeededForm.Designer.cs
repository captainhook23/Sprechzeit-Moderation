namespace Sprechzeit.Forms
{
    partial class CalculateCharsNeededForm
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
            this.textBoxNumberOfChars = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonCalculateCharsNeeded = new System.Windows.Forms.Button();
            this.textBoxSpeakTimeInSeconds = new System.Windows.Forms.TextBox();
            this.labelTimeOfSounds = new System.Windows.Forms.Label();
            this.labelSpeakTimeInSeconds = new System.Windows.Forms.Label();
            this.textBoxTimeOfSounds = new System.Windows.Forms.TextBox();
            this.textBoxSumTimeInMin = new System.Windows.Forms.TextBox();
            this.labelNumberOfChars = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBoxSumTimeInSec = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // stringNumberOfChars
            // 
            this.textBoxNumberOfChars.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxNumberOfChars.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNumberOfChars.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBoxNumberOfChars.Location = new System.Drawing.Point(400, 200);
            this.textBoxNumberOfChars.Name = "textBoxNumberOfChars";
            this.textBoxNumberOfChars.ReadOnly = true;
            this.textBoxNumberOfChars.Size = new System.Drawing.Size(219, 35);
            this.textBoxNumberOfChars.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 31);
            this.label1.TabIndex = 20;
            this.label1.Text = "Gesamtzeit:";
            // 
            // buttonCalculateCharsNeeded
            // 
            this.buttonCalculateCharsNeeded.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.buttonCalculateCharsNeeded.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCalculateCharsNeeded.ForeColor = System.Drawing.Color.Black;
            this.buttonCalculateCharsNeeded.Location = new System.Drawing.Point(100, 330);
            this.buttonCalculateCharsNeeded.Name = "buttonCalculateCharsNeeded";
            this.buttonCalculateCharsNeeded.Size = new System.Drawing.Size(400, 62);
            this.buttonCalculateCharsNeeded.TabIndex = 19;
            this.buttonCalculateCharsNeeded.Text = "Berechne Zeichen";
            this.buttonCalculateCharsNeeded.UseVisualStyleBackColor = false;
            this.buttonCalculateCharsNeeded.Click += new System.EventHandler(this.buttonCalculateCharsNeeded_Click);
            // 
            // textBoxSpeakTimeInSeconds
            // 
            this.textBoxSpeakTimeInSeconds.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxSpeakTimeInSeconds.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSpeakTimeInSeconds.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBoxSpeakTimeInSeconds.Location = new System.Drawing.Point(400, 140);
            this.textBoxSpeakTimeInSeconds.Name = "textBoxSpeakTimeInSeconds";
            this.textBoxSpeakTimeInSeconds.ReadOnly = true;
            this.textBoxSpeakTimeInSeconds.Size = new System.Drawing.Size(219, 35);
            this.textBoxSpeakTimeInSeconds.TabIndex = 18;
            // 
            // labelTimeOfSounds
            // 
            this.labelTimeOfSounds.AutoSize = true;
            this.labelTimeOfSounds.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTimeOfSounds.Location = new System.Drawing.Point(20, 80);
            this.labelTimeOfSounds.Name = "labelTimeOfSounds";
            this.labelTimeOfSounds.Size = new System.Drawing.Size(196, 31);
            this.labelTimeOfSounds.TabIndex = 17;
            this.labelTimeOfSounds.Text = "O-Töne in Sek:";
            // 
            // labelSpeakTimeInSeconds
            // 
            this.labelSpeakTimeInSeconds.AutoSize = true;
            this.labelSpeakTimeInSeconds.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSpeakTimeInSeconds.Location = new System.Drawing.Point(20, 140);
            this.labelSpeakTimeInSeconds.Name = "labelSpeakTimeInSeconds";
            this.labelSpeakTimeInSeconds.Size = new System.Drawing.Size(151, 31);
            this.labelSpeakTimeInSeconds.TabIndex = 15;
            this.labelSpeakTimeInSeconds.Text = "Sprechzeit:";
            // 
            // stringTimeOfSounds
            // 
            this.textBoxTimeOfSounds.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTimeOfSounds.Location = new System.Drawing.Point(400, 80);
            this.textBoxTimeOfSounds.Name = "textBoxTimeOfSounds";
            this.textBoxTimeOfSounds.Size = new System.Drawing.Size(219, 35);
            this.textBoxTimeOfSounds.TabIndex = 14;
            this.textBoxTimeOfSounds.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxTimeOfSounds_KeyDown);
            // 
            // textBoxSumTimeInMin
            // 
            this.textBoxSumTimeInMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSumTimeInMin.Location = new System.Drawing.Point(400, 20);
            this.textBoxSumTimeInMin.Name = "textBoxSumTimeInMin";
            this.textBoxSumTimeInMin.Size = new System.Drawing.Size(45, 35);
            this.textBoxSumTimeInMin.TabIndex = 13;
            this.textBoxSumTimeInMin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxSumTimeInMin_KeyDown);
            // 
            // labelNumberOfChars
            // 
            this.labelNumberOfChars.AutoSize = true;
            this.labelNumberOfChars.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumberOfChars.Location = new System.Drawing.Point(20, 200);
            this.labelNumberOfChars.Name = "labelNumberOfChars";
            this.labelNumberOfChars.Size = new System.Drawing.Size(343, 31);
            this.labelNumberOfChars.TabIndex = 11;
            this.labelNumberOfChars.Text = "Ungefähre Anzahl Zeichen:";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Info;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(450, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(50, 35);
            this.textBox1.TabIndex = 22;
            this.textBox1.Text = "Min";
            // 
            // textBoxSumTimeInSec
            // 
            this.textBoxSumTimeInSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSumTimeInSec.Location = new System.Drawing.Point(510, 20);
            this.textBoxSumTimeInSec.Name = "textBoxSumTimeInSec";
            this.textBoxSumTimeInSec.Size = new System.Drawing.Size(45, 35);
            this.textBoxSumTimeInSec.TabIndex = 23;
            this.textBoxSumTimeInSec.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxSumTimeInSec_KeyDown);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Info;
            this.textBox2.Enabled = false;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(560, 20);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(52, 35);
            this.textBox2.TabIndex = 24;
            this.textBox2.Text = "Sek";
            // 
            // CalculateCharsNeededForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 411);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBoxSumTimeInSec);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBoxNumberOfChars);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCalculateCharsNeeded);
            this.Controls.Add(this.textBoxSpeakTimeInSeconds);
            this.Controls.Add(this.labelTimeOfSounds);
            this.Controls.Add(this.labelSpeakTimeInSeconds);
            this.Controls.Add(this.textBoxTimeOfSounds);
            this.Controls.Add(this.textBoxSumTimeInMin);
            this.Controls.Add(this.labelNumberOfChars);
            this.Name = "CalculateCharsNeededForm";
            this.Text = "CalculateCharsBeingUsedForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNumberOfChars;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonCalculateCharsNeeded;
        private System.Windows.Forms.TextBox textBoxSpeakTimeInSeconds;
        private System.Windows.Forms.Label labelTimeOfSounds;
        private System.Windows.Forms.Label labelSpeakTimeInSeconds;
        private System.Windows.Forms.TextBox textBoxTimeOfSounds;
        private System.Windows.Forms.TextBox textBoxSumTimeInMin;
        private System.Windows.Forms.Label labelNumberOfChars;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBoxSumTimeInSec;
        private System.Windows.Forms.TextBox textBox2;
    }
}
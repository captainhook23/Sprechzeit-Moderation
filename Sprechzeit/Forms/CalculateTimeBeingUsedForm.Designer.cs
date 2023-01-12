namespace Sprechzeit
{
    partial class CalculateTimeBeingUsedForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelNumberOfChars = new System.Windows.Forms.Label();
            this.labelTimeInSeconds = new System.Windows.Forms.Label();
            this.textBoxNumberOfChars = new System.Windows.Forms.TextBox();
            this.textBoxTimeOfSounds = new System.Windows.Forms.TextBox();
            this.labelSpeakTimeInSeconds = new System.Windows.Forms.Label();
            this.textBoxSpeakTimeInSeconds = new System.Windows.Forms.TextBox();
            this.labelTimeOfSounds = new System.Windows.Forms.Label();
            this.textBoxSumOfTime = new System.Windows.Forms.TextBox();
            this.buttonCalculateTime = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSumOfTimeInMinAndSec = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelNumberOfChars
            // 
            this.labelNumberOfChars.AutoSize = true;
            this.labelNumberOfChars.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumberOfChars.Location = new System.Drawing.Point(20, 20);
            this.labelNumberOfChars.Name = "labelNumberOfChars";
            this.labelNumberOfChars.Size = new System.Drawing.Size(209, 31);
            this.labelNumberOfChars.TabIndex = 0;
            this.labelNumberOfChars.Text = "Anzahl Zeichen:";
            // 
            // labelTimeInSeconds
            // 
            this.labelTimeInSeconds.AutoSize = true;
            this.labelTimeInSeconds.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTimeInSeconds.Location = new System.Drawing.Point(20, 200);
            this.labelTimeInSeconds.Name = "labelTimeInSeconds";
            this.labelTimeInSeconds.Size = new System.Drawing.Size(317, 31);
            this.labelTimeInSeconds.TabIndex = 1;
            this.labelTimeInSeconds.Text = "Gesamtzeit in Sekunden:";
            // 
            // textBoxNumberOfChars
            // 
            this.textBoxNumberOfChars.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNumberOfChars.Location = new System.Drawing.Point(400, 20);
            this.textBoxNumberOfChars.Name = "textBoxNumberOfChars";
            this.textBoxNumberOfChars.Size = new System.Drawing.Size(219, 35);
            this.textBoxNumberOfChars.TabIndex = 2;
            this.textBoxNumberOfChars.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxNumberOfChars_KeyDown);
            // 
            // textBoxTimeOfSounds
            // 
            this.textBoxTimeOfSounds.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTimeOfSounds.Location = new System.Drawing.Point(400, 80);
            this.textBoxTimeOfSounds.Name = "textBoxTimeOfSounds";
            this.textBoxTimeOfSounds.Size = new System.Drawing.Size(219, 35);
            this.textBoxTimeOfSounds.TabIndex = 3;
            this.textBoxTimeOfSounds.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxTimeOfSounds_KeyDown);
            // 
            // labelSpeakTimeInSeconds
            // 
            this.labelSpeakTimeInSeconds.AutoSize = true;
            this.labelSpeakTimeInSeconds.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSpeakTimeInSeconds.Location = new System.Drawing.Point(20, 140);
            this.labelSpeakTimeInSeconds.Name = "labelSpeakTimeInSeconds";
            this.labelSpeakTimeInSeconds.Size = new System.Drawing.Size(285, 31);
            this.labelSpeakTimeInSeconds.TabIndex = 4;
            this.labelSpeakTimeInSeconds.Text = "Ungefähre Sprechzeit:";
            // 
            // textBoxSpeakTimeInSeconds
            // 
            this.textBoxSpeakTimeInSeconds.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxSpeakTimeInSeconds.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSpeakTimeInSeconds.Location = new System.Drawing.Point(400, 140);
            this.textBoxSpeakTimeInSeconds.Name = "textBoxSpeakTimeInSeconds";
            this.textBoxSpeakTimeInSeconds.ReadOnly = true;
            this.textBoxSpeakTimeInSeconds.Size = new System.Drawing.Size(219, 35);
            this.textBoxSpeakTimeInSeconds.TabIndex = 5;
            // 
            // labelTimeOfSounds
            // 
            this.labelTimeOfSounds.AutoSize = true;
            this.labelTimeOfSounds.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTimeOfSounds.Location = new System.Drawing.Point(20, 80);
            this.labelTimeOfSounds.Name = "labelTimeOfSounds";
            this.labelTimeOfSounds.Size = new System.Drawing.Size(196, 31);
            this.labelTimeOfSounds.TabIndex = 6;
            this.labelTimeOfSounds.Text = "O-Töne in Sek:";
            // 
            // textBoxSumOfTime
            // 
            this.textBoxSumOfTime.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxSumOfTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSumOfTime.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBoxSumOfTime.Location = new System.Drawing.Point(400, 200);
            this.textBoxSumOfTime.Name = "textBoxSumOfTime";
            this.textBoxSumOfTime.ReadOnly = true;
            this.textBoxSumOfTime.Size = new System.Drawing.Size(219, 35);
            this.textBoxSumOfTime.TabIndex = 7;
            // 
            // buttonCalculateTime
            // 
            this.buttonCalculateTime.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.buttonCalculateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCalculateTime.ForeColor = System.Drawing.Color.Black;
            this.buttonCalculateTime.Location = new System.Drawing.Point(100, 330);
            this.buttonCalculateTime.Name = "buttonCalculateTime";
            this.buttonCalculateTime.Size = new System.Drawing.Size(400, 62);
            this.buttonCalculateTime.TabIndex = 8;
            this.buttonCalculateTime.Text = "Berechne Zeit";
            this.buttonCalculateTime.UseVisualStyleBackColor = false;
            this.buttonCalculateTime.Click += new System.EventHandler(this.buttonCalculateTime_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 260);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(344, 31);
            this.label1.TabIndex = 9;
            this.label1.Text = "Gesamtzeit in Min und Sek:";
            // 
            // textBoxSumOfTimeInMinAndSec
            // 
            this.textBoxSumOfTimeInMinAndSec.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxSumOfTimeInMinAndSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSumOfTimeInMinAndSec.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBoxSumOfTimeInMinAndSec.Location = new System.Drawing.Point(400, 260);
            this.textBoxSumOfTimeInMinAndSec.Name = "textBoxSumOfTimeInMinAndSec";
            this.textBoxSumOfTimeInMinAndSec.ReadOnly = true;
            this.textBoxSumOfTimeInMinAndSec.Size = new System.Drawing.Size(219, 35);
            this.textBoxSumOfTimeInMinAndSec.TabIndex = 10;
            // 
            // CalculateTimeBeingUsedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 411);
            this.Controls.Add(this.textBoxSumOfTimeInMinAndSec);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCalculateTime);
            this.Controls.Add(this.textBoxSumOfTime);
            this.Controls.Add(this.labelTimeOfSounds);
            this.Controls.Add(this.textBoxSpeakTimeInSeconds);
            this.Controls.Add(this.labelSpeakTimeInSeconds);
            this.Controls.Add(this.textBoxTimeOfSounds);
            this.Controls.Add(this.textBoxNumberOfChars);
            this.Controls.Add(this.labelTimeInSeconds);
            this.Controls.Add(this.labelNumberOfChars);
            this.Name = "CalculateTimeBeingUsedForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNumberOfChars;
        private System.Windows.Forms.Label labelTimeInSeconds;
        private System.Windows.Forms.TextBox textBoxNumberOfChars;
        private System.Windows.Forms.TextBox textBoxTimeOfSounds;
        private System.Windows.Forms.Label labelSpeakTimeInSeconds;
        private System.Windows.Forms.TextBox textBoxSpeakTimeInSeconds;
        private System.Windows.Forms.Label labelTimeOfSounds;
        private System.Windows.Forms.TextBox textBoxSumOfTime;
        private System.Windows.Forms.Button buttonCalculateTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxSumOfTimeInMinAndSec;
    }
}


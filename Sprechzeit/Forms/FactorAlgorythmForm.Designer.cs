namespace Sprechzeit.Forms
{
    partial class FactorAlgorythmForm
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
            this.btn_UpdateFactor = new System.Windows.Forms.Button();
            this.textBox1_Textdokument = new System.Windows.Forms.TextBox();
            this.button1_Clear = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_UpdateFactor
            // 
            this.btn_UpdateFactor.Location = new System.Drawing.Point(34, 390);
            this.btn_UpdateFactor.Name = "btn_UpdateFactor";
            this.btn_UpdateFactor.Size = new System.Drawing.Size(127, 23);
            this.btn_UpdateFactor.TabIndex = 0;
            this.btn_UpdateFactor.Text = "Faktor Updaten";
            this.btn_UpdateFactor.UseVisualStyleBackColor = true;
            this.btn_UpdateFactor.Click += new System.EventHandler(this.btn_UpdateFactor_Click);
            // 
            // textBox1_Textdokument
            // 
            this.textBox1_Textdokument.Location = new System.Drawing.Point(34, 23);
            this.textBox1_Textdokument.Multiline = true;
            this.textBox1_Textdokument.Name = "textBox1_Textdokument";
            this.textBox1_Textdokument.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1_Textdokument.Size = new System.Drawing.Size(297, 361);
            this.textBox1_Textdokument.TabIndex = 1;
            // 
            // button1_Clear
            // 
            this.button1_Clear.Location = new System.Drawing.Point(167, 390);
            this.button1_Clear.Name = "button1_Clear";
            this.button1_Clear.Size = new System.Drawing.Size(127, 23);
            this.button1_Clear.TabIndex = 4;
            this.button1_Clear.Text = "Clear";
            this.button1_Clear.UseVisualStyleBackColor = true;
            this.button1_Clear.Click += new System.EventHandler(this.button1_Clear_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(694, 17);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(297, 361);
            this.textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(357, 23);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox2.Size = new System.Drawing.Size(297, 361);
            this.textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(1019, 252);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox3.Size = new System.Drawing.Size(164, 126);
            this.textBox3.TabIndex = 8;
            // 
            // FactorAlgorythmForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1195, 431);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1_Clear);
            this.Controls.Add(this.textBox1_Textdokument);
            this.Controls.Add(this.btn_UpdateFactor);
            this.Name = "FactorAlgorythmForm";
            this.Text = "FactorAlgorythmForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_UpdateFactor;
        private System.Windows.Forms.TextBox textBox1_Textdokument;
        private System.Windows.Forms.Button button1_Clear;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
    }
}
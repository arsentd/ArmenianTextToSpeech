namespace Visualizer
{
    partial class VisualizerForm
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
            this.TextBoxWord = new System.Windows.Forms.TextBox();
            this.NumericUpDownSpeed = new System.Windows.Forms.NumericUpDown();
            this.ButtonSpeak = new System.Windows.Forms.Button();
            this.LabelWord = new System.Windows.Forms.Label();
            this.LabelSpeed = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownSpeed)).BeginInit();
            this.SuspendLayout();
            // 
            // TextBoxWord
            // 
            this.TextBoxWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.TextBoxWord.Location = new System.Drawing.Point(116, 25);
            this.TextBoxWord.MaxLength = 100;
            this.TextBoxWord.Name = "TextBoxWord";
            this.TextBoxWord.Size = new System.Drawing.Size(315, 26);
            this.TextBoxWord.TabIndex = 0;
            this.TextBoxWord.TextChanged += new System.EventHandler(this.TextBoxWord_TextChanged);
            this.TextBoxWord.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxWord_KeyDown);
            this.TextBoxWord.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxWord_KeyPress);
            // 
            // NumericUpDownSpeed
            // 
            this.NumericUpDownSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.NumericUpDownSpeed.Location = new System.Drawing.Point(116, 71);
            this.NumericUpDownSpeed.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.NumericUpDownSpeed.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.NumericUpDownSpeed.Name = "NumericUpDownSpeed";
            this.NumericUpDownSpeed.Size = new System.Drawing.Size(62, 21);
            this.NumericUpDownSpeed.TabIndex = 1;
            // 
            // ButtonSpeak
            // 
            this.ButtonSpeak.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.ButtonSpeak.Location = new System.Drawing.Point(116, 116);
            this.ButtonSpeak.Name = "ButtonSpeak";
            this.ButtonSpeak.Size = new System.Drawing.Size(315, 38);
            this.ButtonSpeak.TabIndex = 2;
            this.ButtonSpeak.Text = "Speak";
            this.ButtonSpeak.UseVisualStyleBackColor = true;
            this.ButtonSpeak.Click += new System.EventHandler(this.ButtonSpeak_Click);
            // 
            // LabelWord
            // 
            this.LabelWord.AutoSize = true;
            this.LabelWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.LabelWord.Location = new System.Drawing.Point(68, 30);
            this.LabelWord.Name = "LabelWord";
            this.LabelWord.Size = new System.Drawing.Size(42, 17);
            this.LabelWord.TabIndex = 3;
            this.LabelWord.Text = "Word";
            // 
            // LabelSpeed
            // 
            this.LabelSpeed.AutoSize = true;
            this.LabelSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.LabelSpeed.Location = new System.Drawing.Point(61, 72);
            this.LabelSpeed.Name = "LabelSpeed";
            this.LabelSpeed.Size = new System.Drawing.Size(49, 17);
            this.LabelSpeed.TabIndex = 4;
            this.LabelSpeed.Text = "Speed";
            // 
            // VisualizerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 179);
            this.Controls.Add(this.LabelSpeed);
            this.Controls.Add(this.LabelWord);
            this.Controls.Add(this.ButtonSpeak);
            this.Controls.Add(this.NumericUpDownSpeed);
            this.Controls.Add(this.TextBoxWord);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "VisualizerForm";
            this.Text = "Armenian Text To Speech";
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownSpeed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBoxWord;
        private System.Windows.Forms.NumericUpDown NumericUpDownSpeed;
        private System.Windows.Forms.Button ButtonSpeak;
        private System.Windows.Forms.Label LabelWord;
        private System.Windows.Forms.Label LabelSpeed;
    }
}


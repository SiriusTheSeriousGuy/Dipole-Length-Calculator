namespace DipoleCalculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.mhzRadio = new System.Windows.Forms.RadioButton();
            this.khzRadio = new System.Windows.Forms.RadioButton();
            this.ghzRadio = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.dipoleLegLength = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.wavelength = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(168, 144);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 24);
            this.button1.TabIndex = 1;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Frequency";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Antenna Length";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(144, 35);
            this.textBox1.MinimumSize = new System.Drawing.Size(104, 23);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(104, 23);
            this.textBox1.TabIndex = 3;
            this.textBox1.WordWrap = false;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // mhzRadio
            // 
            this.mhzRadio.AutoSize = true;
            this.mhzRadio.Checked = true;
            this.mhzRadio.Location = new System.Drawing.Point(64, 144);
            this.mhzRadio.Name = "mhzRadio";
            this.mhzRadio.Size = new System.Drawing.Size(50, 19);
            this.mhzRadio.TabIndex = 5;
            this.mhzRadio.TabStop = true;
            this.mhzRadio.Text = "MHz";
            this.mhzRadio.UseVisualStyleBackColor = true;
            this.mhzRadio.CheckedChanged += new System.EventHandler(this.mhzRadio_CheckedChanged);
            // 
            // khzRadio
            // 
            this.khzRadio.AutoSize = true;
            this.khzRadio.Location = new System.Drawing.Point(120, 144);
            this.khzRadio.Name = "khzRadio";
            this.khzRadio.Size = new System.Drawing.Size(45, 19);
            this.khzRadio.TabIndex = 6;
            this.khzRadio.Text = "kHz";
            this.khzRadio.UseVisualStyleBackColor = true;
            this.khzRadio.CheckedChanged += new System.EventHandler(this.khzRadio_CheckedChanged);
            // 
            // ghzRadio
            // 
            this.ghzRadio.AutoSize = true;
            this.ghzRadio.Location = new System.Drawing.Point(8, 144);
            this.ghzRadio.Name = "ghzRadio";
            this.ghzRadio.Size = new System.Drawing.Size(47, 19);
            this.ghzRadio.TabIndex = 7;
            this.ghzRadio.Text = "GHz";
            this.ghzRadio.UseVisualStyleBackColor = true;
            this.ghzRadio.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Dipole Leg Length";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // dipoleLegLength
            // 
            this.dipoleLegLength.Location = new System.Drawing.Point(144, 64);
            this.dipoleLegLength.Name = "dipoleLegLength";
            this.dipoleLegLength.ReadOnly = true;
            this.dipoleLegLength.Size = new System.Drawing.Size(104, 23);
            this.dipoleLegLength.TabIndex = 8;
            this.dipoleLegLength.WordWrap = false;
            this.dipoleLegLength.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Wavelength";
            // 
            // wavelength
            // 
            this.wavelength.Location = new System.Drawing.Point(144, 93);
            this.wavelength.Name = "wavelength";
            this.wavelength.ReadOnly = true;
            this.wavelength.Size = new System.Drawing.Size(104, 23);
            this.wavelength.TabIndex = 10;
            this.wavelength.WordWrap = false;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.DecimalPlaces = 4;
            this.numericUpDown1.Location = new System.Drawing.Point(144, 6);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(104, 23);
            this.numericUpDown1.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(259, 174);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.wavelength);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dipoleLegLength);
            this.Controls.Add(this.ghzRadio);
            this.Controls.Add(this.khzRadio);
            this.Controls.Add(this.mhzRadio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.MinimumSize = new System.Drawing.Size(275, 213);
            this.Name = "Form1";
            this.Text = "Dipole Length Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button button1;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private RadioButton mhzRadio;
        private RadioButton khzRadio;
        private RadioButton ghzRadio;
        private Label label3;
        private TextBox dipoleLegLength;
        private Label label4;
        private TextBox wavelength;
        private NumericUpDown numericUpDown1;
    }
}
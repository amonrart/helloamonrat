namespace GPAxConfigure
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
            this.textBoxGPA_input = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxGPAx = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.textBoxMinGPA = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxMaxGPA = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxGPA_input
            // 
            this.textBoxGPA_input.Font = new System.Drawing.Font("Leelawadee UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxGPA_input.Location = new System.Drawing.Point(302, 56);
            this.textBoxGPA_input.Name = "textBoxGPA_input";
            this.textBoxGPA_input.Size = new System.Drawing.Size(237, 61);
            this.textBoxGPA_input.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Leelawadee UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(45, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 54);
            this.label1.TabIndex = 1;
            this.label1.Text = "GPA INPUT";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Leelawadee UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(608, 55);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 62);
            this.button1.TabIndex = 2;
            this.button1.Text = "ADD";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Leelawadee UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(20, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 54);
            this.label2.TabIndex = 4;
            this.label2.Text = "GPAX";
            // 
            // textBoxGPAx
            // 
            this.textBoxGPAx.Font = new System.Drawing.Font("Leelawadee UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxGPAx.Location = new System.Drawing.Point(243, 39);
            this.textBoxGPAx.Name = "textBoxGPAx";
            this.textBoxGPAx.ReadOnly = true;
            this.textBoxGPAx.Size = new System.Drawing.Size(258, 61);
            this.textBoxGPAx.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxMaxGPA);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBoxMinGPA);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.textBoxGPAx);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(59, 151);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(729, 287);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "OUTPUT";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Leelawadee UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(565, 42);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(158, 62);
            this.button2.TabIndex = 6;
            this.button2.Text = "CLEAP";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBoxMinGPA
            // 
            this.textBoxMinGPA.Font = new System.Drawing.Font("Leelawadee UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxMinGPA.Location = new System.Drawing.Point(243, 207);
            this.textBoxMinGPA.Name = "textBoxMinGPA";
            this.textBoxMinGPA.ReadOnly = true;
            this.textBoxMinGPA.Size = new System.Drawing.Size(258, 61);
            this.textBoxMinGPA.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Leelawadee UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(20, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 54);
            this.label3.TabIndex = 8;
            this.label3.Text = "MAX GPA";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBoxMaxGPA
            // 
            this.textBoxMaxGPA.Font = new System.Drawing.Font("Leelawadee UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxMaxGPA.Location = new System.Drawing.Point(243, 123);
            this.textBoxMaxGPA.Name = "textBoxMaxGPA";
            this.textBoxMaxGPA.ReadOnly = true;
            this.textBoxMaxGPA.Size = new System.Drawing.Size(258, 61);
            this.textBoxMaxGPA.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Leelawadee UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(20, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(186, 54);
            this.label4.TabIndex = 10;
            this.label4.Text = "MIN GPA";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxGPA_input);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBoxGPA_input;
        private Label label1;
        private Button button1;
        private Label label2;
        private TextBox textBoxGPAx;
        private GroupBox groupBox1;
        private Button button2;
        private TextBox textBoxMinGPA;
        private Label label3;
        private TextBox textBoxMaxGPA;
        private Label label4;
    }
}
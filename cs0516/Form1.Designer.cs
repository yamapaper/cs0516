namespace cs0516
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
            components = new System.ComponentModel.Container();
            button1 = new Button();
            label1 = new Label();
            button2 = new Button();
            button3 = new Button();
            textBox1 = new TextBox();
            timer1 = new System.Windows.Forms.Timer(components);
            button4 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(5, 15);
            button1.Name = "button1";
            button1.Size = new Size(122, 75);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(5, 264);
            label1.Name = "label1";
            label1.Size = new Size(19, 15);
            label1.TabIndex = 1;
            label1.Text = "亀";
            label1.Click += label1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(5, 96);
            button2.Name = "button2";
            button2.Size = new Size(126, 69);
            button2.TabIndex = 2;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(5, 171);
            button3.Name = "button3";
            button3.Size = new Size(131, 90);
            button3.TabIndex = 3;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(179, 209);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(172, 23);
            textBox1.TabIndex = 4;
            textBox1.Text = "山田健太";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // button4
            // 
            button4.Location = new Point(5, 282);
            button4.Name = "button4";
            button4.Size = new Size(113, 70);
            button4.TabIndex = 5;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button4);
            Controls.Add(textBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Button button2;
        private Button button3;
        private TextBox textBox1;
        public System.Windows.Forms.Timer timer1;
        private Button button4;
    }
}

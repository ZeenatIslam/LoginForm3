namespace LoginForm3
{
    partial class Form4
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
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 50);
            label1.Name = "label1";
            label1.Size = new Size(190, 26);
            label1.TabIndex = 0;
            label1.Text = "Enter the First number";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe Script", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 131);
            label2.Name = "label2";
            label2.Size = new Size(221, 25);
            label2.TabIndex = 1;
            label2.Text = "Enter the Second number:";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe Script", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(12, 169);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(221, 32);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe Script", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(12, 79);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(221, 32);
            textBox2.TabIndex = 3;
            // 
            // button1
            // 
            button1.BackColor = Color.Tomato;
            button1.Font = new Font("Lucida Calligraphy", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(64, 221);
            button1.Name = "button1";
            button1.Size = new Size(108, 29);
            button1.TabIndex = 4;
            button1.Text = "Calculate";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.mouse_8341314_640;
            ClientSize = new Size(542, 600);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form4";
            Text = "Form4";
            Load += Form4_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
    }
}
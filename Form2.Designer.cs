namespace LoginForm3
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            button1 = new Button();
            label1 = new Label();
            menuStrip1 = new MenuStrip();
            menuStrip2 = new MenuStrip();
            greatestCommonDivisorToolStripMenuItem = new ToolStripMenuItem();
            fibonacciSeriesToolStripMenuItem1 = new ToolStripMenuItem();
            gCDToolStripMenuItem = new ToolStripMenuItem();
            lCMToolStripMenuItem1 = new ToolStripMenuItem();
            buzzNumberToolStripMenuItem1 = new ToolStripMenuItem();
            sunnyNumberToolStripMenuItem = new ToolStripMenuItem();
            fibonacciSeriesToolStripMenuItem = new ToolStripMenuItem();
            circleToolStripMenuItem = new ToolStripMenuItem();
            squareToolStripMenuItem = new ToolStripMenuItem();
            rectangleToolStripMenuItem = new ToolStripMenuItem();
            lCMToolStripMenuItem = new ToolStripMenuItem();
            buzzNumberToolStripMenuItem = new ToolStripMenuItem();
            menuStrip2.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Info;
            button1.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(1351, 680);
            button1.Name = "button1";
            button1.Size = new Size(116, 48);
            button1.TabIndex = 0;
            button1.Text = "Logout";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.LemonChiffon;
            label1.Font = new Font("Vivaldi", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(566, 184);
            label1.Name = "label1";
            label1.Size = new Size(222, 41);
            label1.TabIndex = 1;
            label1.Text = "HELLO !";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Location = new Point(0, 28);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1479, 24);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            menuStrip2.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            menuStrip2.ImageScalingSize = new Size(20, 20);
            menuStrip2.Items.AddRange(new ToolStripItem[] { greatestCommonDivisorToolStripMenuItem, fibonacciSeriesToolStripMenuItem, lCMToolStripMenuItem, buzzNumberToolStripMenuItem });
            menuStrip2.Location = new Point(0, 0);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Size = new Size(1479, 28);
            menuStrip2.TabIndex = 3;
            menuStrip2.Text = "menuStrip2";
            // 
            // greatestCommonDivisorToolStripMenuItem
            // 
            greatestCommonDivisorToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { fibonacciSeriesToolStripMenuItem1, gCDToolStripMenuItem, lCMToolStripMenuItem1, buzzNumberToolStripMenuItem1, sunnyNumberToolStripMenuItem });
            greatestCommonDivisorToolStripMenuItem.Name = "greatestCommonDivisorToolStripMenuItem";
            greatestCommonDivisorToolStripMenuItem.Size = new Size(140, 24);
            greatestCommonDivisorToolStripMenuItem.Text = "Number problems";
            // 
            // fibonacciSeriesToolStripMenuItem1
            // 
            fibonacciSeriesToolStripMenuItem1.Name = "fibonacciSeriesToolStripMenuItem1";
            fibonacciSeriesToolStripMenuItem1.Size = new Size(224, 26);
            fibonacciSeriesToolStripMenuItem1.Text = "Fibonacci Series";
            // 
            // gCDToolStripMenuItem
            // 
            gCDToolStripMenuItem.Name = "gCDToolStripMenuItem";
            gCDToolStripMenuItem.Size = new Size(224, 26);
            gCDToolStripMenuItem.Text = "GCD";
            gCDToolStripMenuItem.Click += gCDToolStripMenuItem_Click;
            // 
            // lCMToolStripMenuItem1
            // 
            lCMToolStripMenuItem1.Name = "lCMToolStripMenuItem1";
            lCMToolStripMenuItem1.Size = new Size(224, 26);
            lCMToolStripMenuItem1.Text = "LCM";
            // 
            // buzzNumberToolStripMenuItem1
            // 
            buzzNumberToolStripMenuItem1.Name = "buzzNumberToolStripMenuItem1";
            buzzNumberToolStripMenuItem1.Size = new Size(224, 26);
            buzzNumberToolStripMenuItem1.Text = "Buzz Number";
            buzzNumberToolStripMenuItem1.Click += buzzNumberToolStripMenuItem1_Click;
            // 
            // sunnyNumberToolStripMenuItem
            // 
            sunnyNumberToolStripMenuItem.Name = "sunnyNumberToolStripMenuItem";
            sunnyNumberToolStripMenuItem.Size = new Size(224, 26);
            sunnyNumberToolStripMenuItem.Text = "Sunny number";
            sunnyNumberToolStripMenuItem.Click += sunnyNumberToolStripMenuItem_Click;
            // 
            // fibonacciSeriesToolStripMenuItem
            // 
            fibonacciSeriesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { circleToolStripMenuItem, squareToolStripMenuItem, rectangleToolStripMenuItem });
            fibonacciSeriesToolStripMenuItem.Name = "fibonacciSeriesToolStripMenuItem";
            fibonacciSeriesToolStripMenuItem.Size = new Size(58, 24);
            fibonacciSeriesToolStripMenuItem.Text = "Area ";
            // 
            // circleToolStripMenuItem
            // 
            circleToolStripMenuItem.Name = "circleToolStripMenuItem";
            circleToolStripMenuItem.Size = new Size(156, 26);
            circleToolStripMenuItem.Text = "Circle";
            // 
            // squareToolStripMenuItem
            // 
            squareToolStripMenuItem.Name = "squareToolStripMenuItem";
            squareToolStripMenuItem.Size = new Size(156, 26);
            squareToolStripMenuItem.Text = "Square";
            // 
            // rectangleToolStripMenuItem
            // 
            rectangleToolStripMenuItem.Name = "rectangleToolStripMenuItem";
            rectangleToolStripMenuItem.Size = new Size(156, 26);
            rectangleToolStripMenuItem.Text = "Rectangle";
            // 
            // lCMToolStripMenuItem
            // 
            lCMToolStripMenuItem.Name = "lCMToolStripMenuItem";
            lCMToolStripMenuItem.Size = new Size(58, 24);
            lCMToolStripMenuItem.Text = "LCM";
            // 
            // buzzNumberToolStripMenuItem
            // 
            buzzNumberToolStripMenuItem.Name = "buzzNumberToolStripMenuItem";
            buzzNumberToolStripMenuItem.Size = new Size(110, 24);
            buzzNumberToolStripMenuItem.Text = "Buzz Number";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1479, 749);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(menuStrip1);
            Controls.Add(menuStrip2);
            MainMenuStrip = menuStrip1;
            Name = "Form2";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Form2";
            WindowState = FormWindowState.Maximized;
            Load += Form2_Load;
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private MenuStrip menuStrip1;
        private MenuStrip menuStrip2;
        private ToolStripMenuItem greatestCommonDivisorToolStripMenuItem;
        private ToolStripMenuItem fibonacciSeriesToolStripMenuItem1;
        private ToolStripMenuItem gCDToolStripMenuItem;
        private ToolStripMenuItem lCMToolStripMenuItem1;
        private ToolStripMenuItem buzzNumberToolStripMenuItem1;
        private ToolStripMenuItem fibonacciSeriesToolStripMenuItem;
        private ToolStripMenuItem circleToolStripMenuItem;
        private ToolStripMenuItem squareToolStripMenuItem;
        private ToolStripMenuItem rectangleToolStripMenuItem;
        private ToolStripMenuItem lCMToolStripMenuItem;
        private ToolStripMenuItem buzzNumberToolStripMenuItem;
        private ToolStripMenuItem sunnyNumberToolStripMenuItem;
    }
}
namespace shapes
{
    partial class Form3
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
            label3 = new Label();
            label4 = new Label();
            sa = new TextBox();
            sb = new TextBox();
            sc = new TextBox();
            button1 = new Button();
            button2 = new Button();
            label5 = new Label();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(342, 73);
            label1.Name = "label1";
            label1.Size = new Size(62, 20);
            label1.TabIndex = 0;
            label1.Text = "Triangle";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(223, 157);
            label2.Name = "label2";
            label2.Size = new Size(19, 20);
            label2.TabIndex = 1;
            label2.Text = "A";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(223, 204);
            label3.Name = "label3";
            label3.Size = new Size(18, 20);
            label3.TabIndex = 2;
            label3.Text = "B";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(223, 248);
            label4.Name = "label4";
            label4.Size = new Size(18, 20);
            label4.TabIndex = 3;
            label4.Text = "C";
            label4.Click += label4_Click;
            // 
            // sa
            // 
            sa.Location = new Point(311, 159);
            sa.Name = "sa";
            sa.Size = new Size(125, 27);
            sa.TabIndex = 4;
            // 
            // sb
            // 
            sb.Location = new Point(311, 204);
            sb.Name = "sb";
            sb.Size = new Size(125, 27);
            sb.TabIndex = 5;
            // 
            // sc
            // 
            sc.Location = new Point(311, 248);
            sc.Name = "sc";
            sc.Size = new Size(125, 27);
            sc.TabIndex = 6;
            // 
            // button1
            // 
            button1.Location = new Point(229, 342);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 7;
            button1.Text = "Area";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(454, 342);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 8;
            button2.Text = "Perimeter";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(381, 404);
            label5.Name = "label5";
            label5.Size = new Size(0, 20);
            label5.TabIndex = 9;
            // 
            // button3
            // 
            button3.Location = new Point(139, 27);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 10;
            button3.Text = "Circle";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(591, 39);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 11;
            button4.Text = "Rectangle";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(label5);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(sc);
            Controls.Add(sb);
            Controls.Add(sa);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form3";
            Text = "Triangle";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox sa;
        private TextBox sb;
        private TextBox sc;
        private Button button1;
        private Button button2;
        private Label label5;
        private Button button3;
        private Button button4;
    }
}
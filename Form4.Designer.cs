namespace joyobilat
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
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(633, 373);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 0;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(104, 77);
            label1.Name = "label1";
            label1.Size = new Size(68, 25);
            label1.TabIndex = 1;
            label1.Text = "Book 1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(104, 153);
            label2.Name = "label2";
            label2.Size = new Size(68, 25);
            label2.TabIndex = 2;
            label2.Text = "Book 2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(104, 226);
            label3.Name = "label3";
            label3.Size = new Size(68, 25);
            label3.TabIndex = 3;
            label3.Text = "Book 3";
            // 
            // button2
            // 
            button2.Location = new Point(40, 322);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 4;
            button2.Text = "Borrow";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(316, 322);
            button3.Name = "button3";
            button3.Size = new Size(112, 34);
            button3.TabIndex = 5;
            button3.Text = "Update";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(463, 322);
            button4.Name = "button4";
            button4.Size = new Size(112, 34);
            button4.TabIndex = 6;
            button4.Text = "Remove";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(173, 322);
            button5.Name = "button5";
            button5.Size = new Size(112, 34);
            button5.TabIndex = 7;
            button5.Text = "Add";
            button5.UseVisualStyleBackColor = true;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(800, 450);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form4";
            Text = "Form4";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
    }
}
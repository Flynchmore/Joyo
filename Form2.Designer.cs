﻿namespace joyobilat
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
            button1 = new Button();
            label1 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            textBox3 = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(339, 297);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 0;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Gill Sans Ultra Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(290, 55);
            label1.Name = "label1";
            label1.Size = new Size(201, 50);
            label1.TabIndex = 8;
            label1.Text = "SIGN UP";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(237, 178);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Password";
            textBox2.Size = new Size(326, 31);
            textBox2.TabIndex = 7;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(237, 120);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Username";
            textBox1.Size = new Size(326, 31);
            textBox1.TabIndex = 6;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(237, 231);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "Bading ka ba pre?";
            textBox3.Size = new Size(326, 31);
            textBox3.TabIndex = 10;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox3);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private TextBox textBox2;
        private TextBox textBox1;
        private TextBox textBox3;
    }
}
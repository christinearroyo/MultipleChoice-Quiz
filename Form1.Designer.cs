namespace Multiple_Choice_Quiz
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton4 = new RadioButton();
            btnNext = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlText;
            label1.Font = new Font("Verdana", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(137, 49);
            label1.Name = "label1";
            label1.Size = new Size(354, 31);
            label1.TabIndex = 0;
            label1.Text = "What is 111 in decimal?";
            // 
            // radioButton1
            // 
            radioButton1.Anchor = AnchorStyles.None;
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Perpetua Titling MT", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            radioButton1.ForeColor = SystemColors.Control;
            radioButton1.Location = new Point(28, 12);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(62, 28);
            radioButton1.TabIndex = 5;
            radioButton1.TabStop = true;
            radioButton1.Text = "   3";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.Anchor = AnchorStyles.None;
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Perpetua Titling MT", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            radioButton2.ForeColor = SystemColors.Control;
            radioButton2.Location = new Point(28, 57);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(62, 28);
            radioButton2.TabIndex = 6;
            radioButton2.TabStop = true;
            radioButton2.Text = "   5";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.Anchor = AnchorStyles.None;
            radioButton3.AutoSize = true;
            radioButton3.Font = new Font("Perpetua Titling MT", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            radioButton3.ForeColor = SystemColors.Control;
            radioButton3.Location = new Point(28, 102);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(63, 28);
            radioButton3.TabIndex = 7;
            radioButton3.TabStop = true;
            radioButton3.Text = "   7";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            radioButton4.Anchor = AnchorStyles.None;
            radioButton4.AutoSize = true;
            radioButton4.Font = new Font("Perpetua Titling MT", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            radioButton4.ForeColor = SystemColors.Control;
            radioButton4.Location = new Point(28, 145);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(63, 28);
            radioButton4.TabIndex = 8;
            radioButton4.TabStop = true;
            radioButton4.Text = "   9";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            btnNext.Anchor = AnchorStyles.None;
            btnNext.BackColor = SystemColors.ControlText;
            btnNext.BackgroundImage = (Image)resources.GetObject("btnNext.BackgroundImage");
            btnNext.BackgroundImageLayout = ImageLayout.Zoom;
            btnNext.FlatStyle = FlatStyle.Flat;
            btnNext.Location = new Point(638, 347);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(57, 57);
            btnNext.TabIndex = 9;
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNext_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackgroundImage = Properties.Resources._482144123_9398402743587514_2257695987033967719_n;
            panel1.BackgroundImageLayout = ImageLayout.Zoom;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(113, 22);
            panel1.Name = "panel1";
            panel1.Size = new Size(608, 121);
            panel1.TabIndex = 10;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Controls.Add(radioButton3);
            panel2.Controls.Add(radioButton1);
            panel2.Controls.Add(radioButton2);
            panel2.Controls.Add(radioButton4);
            panel2.Location = new Point(124, 149);
            panel2.Name = "panel2";
            panel2.Size = new Size(585, 181);
            panel2.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlText;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(btnNext);
            Name = "Form1";
            Text = "Multiple Choice";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
        private Button btnNext;
        public Label label1;
        private Panel panel1;
        private Panel panel2;
    }
}

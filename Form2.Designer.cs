namespace Multiple_Choice_Quiz
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
            radioButton4 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            label1 = new Label();
            btnNext = new Button();
            btnBack = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // radioButton4
            // 
            radioButton4.Anchor = AnchorStyles.None;
            radioButton4.AutoSize = true;
            radioButton4.BackColor = SystemColors.ControlText;
            radioButton4.Font = new Font("Perpetua Titling MT", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            radioButton4.ForeColor = SystemColors.Control;
            radioButton4.Location = new Point(29, 158);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(104, 28);
            radioButton4.TabIndex = 13;
            radioButton4.TabStop = true;
            radioButton4.Text = "   Ram";
            radioButton4.UseVisualStyleBackColor = false;
            // 
            // radioButton3
            // 
            radioButton3.Anchor = AnchorStyles.None;
            radioButton3.AutoSize = true;
            radioButton3.BackColor = SystemColors.ControlText;
            radioButton3.Font = new Font("Perpetua Titling MT", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            radioButton3.ForeColor = SystemColors.Control;
            radioButton3.Location = new Point(29, 109);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(158, 28);
            radioButton3.TabIndex = 12;
            radioButton3.TabStop = true;
            radioButton3.Text = "   Monitor";
            radioButton3.UseVisualStyleBackColor = false;
            // 
            // radioButton2
            // 
            radioButton2.Anchor = AnchorStyles.None;
            radioButton2.AutoSize = true;
            radioButton2.BackColor = SystemColors.ControlText;
            radioButton2.Font = new Font("Perpetua Titling MT", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            radioButton2.ForeColor = SystemColors.Control;
            radioButton2.Location = new Point(29, 61);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(175, 28);
            radioButton2.TabIndex = 11;
            radioButton2.TabStop = true;
            radioButton2.Text = "   Keyboard";
            radioButton2.UseVisualStyleBackColor = false;
            // 
            // radioButton1
            // 
            radioButton1.Anchor = AnchorStyles.None;
            radioButton1.AutoSize = true;
            radioButton1.BackColor = SystemColors.ControlText;
            radioButton1.Font = new Font("Perpetua Titling MT", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            radioButton1.ForeColor = SystemColors.Control;
            radioButton1.Location = new Point(29, 12);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(175, 28);
            radioButton1.TabIndex = 10;
            radioButton1.TabStop = true;
            radioButton1.Text = "   Hard Disk";
            radioButton1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlText;
            label1.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(52, 39);
            label1.Name = "label1";
            label1.Size = new Size(539, 25);
            label1.TabIndex = 9;
            label1.Text = "Which of the ff is the example of Input Device?";
            // 
            // btnNext
            // 
            btnNext.Anchor = AnchorStyles.None;
            btnNext.BackgroundImage = (Image)resources.GetObject("btnNext.BackgroundImage");
            btnNext.BackgroundImageLayout = ImageLayout.Stretch;
            btnNext.FlatStyle = FlatStyle.Flat;
            btnNext.Location = new Point(622, 342);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(66, 46);
            btnNext.TabIndex = 14;
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // btnBack
            // 
            btnBack.Anchor = AnchorStyles.None;
            btnBack.BackgroundImage = (Image)resources.GetObject("btnBack.BackgroundImage");
            btnBack.BackgroundImageLayout = ImageLayout.Stretch;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Location = new Point(110, 342);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(62, 46);
            btnBack.TabIndex = 15;
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(81, 23);
            panel1.Name = "panel1";
            panel1.Size = new Size(639, 104);
            panel1.TabIndex = 16;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Controls.Add(radioButton2);
            panel2.Controls.Add(radioButton1);
            panel2.Controls.Add(radioButton3);
            panel2.Controls.Add(radioButton4);
            panel2.Location = new Point(81, 133);
            panel2.Name = "panel2";
            panel2.Size = new Size(639, 195);
            panel2.TabIndex = 17;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlText;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(btnBack);
            Controls.Add(btnNext);
            Name = "Form2";
            Text = "Multiple Choice";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private RadioButton radioButton4;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Label label1;
        private Button btnNext;
        private Button btnBack;
        private Panel panel1;
        private Panel panel2;
    }
}
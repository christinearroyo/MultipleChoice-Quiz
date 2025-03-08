namespace Multiple_Choice_Quiz
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            radioButton4 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            label1 = new Label();
            btnBack = new Button();
            btnSubmit = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Font = new Font("Perpetua Titling MT", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            radioButton4.ForeColor = SystemColors.Control;
            radioButton4.Location = new Point(25, 141);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(115, 28);
            radioButton4.TabIndex = 18;
            radioButton4.TabStop = true;
            radioButton4.Text = "   Wind";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Font = new Font("Perpetua Titling MT", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            radioButton3.ForeColor = SystemColors.Control;
            radioButton3.Location = new Point(28, 99);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(110, 28);
            radioButton3.TabIndex = 17;
            radioButton3.TabStop = true;
            radioButton3.Text = "   West";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Perpetua Titling MT", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            radioButton2.ForeColor = SystemColors.Control;
            radioButton2.Location = new Point(25, 56);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(153, 28);
            radioButton2.TabIndex = 16;
            radioButton2.TabStop = true;
            radioButton2.Text = "   Window";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Perpetua Titling MT", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            radioButton1.ForeColor = SystemColors.Control;
            radioButton1.Location = new Point(25, 13);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(100, 28);
            radioButton1.TabIndex = 15;
            radioButton1.TabStop = true;
            radioButton1.Text = "   Web";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(106, 44);
            label1.Name = "label1";
            label1.Size = new Size(417, 25);
            label1.TabIndex = 14;
            label1.Text = "WWW stands for World Wide _____";
            // 
            // btnBack
            // 
            btnBack.BackgroundImage = (Image)resources.GetObject("btnBack.BackgroundImage");
            btnBack.BackgroundImageLayout = ImageLayout.Stretch;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Location = new Point(105, 345);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(71, 46);
            btnBack.TabIndex = 20;
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnSubmit
            // 
            btnSubmit.BackgroundImage = (Image)resources.GetObject("btnSubmit.BackgroundImage");
            btnSubmit.BackgroundImageLayout = ImageLayout.Stretch;
            btnSubmit.FlatStyle = FlatStyle.Popup;
            btnSubmit.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSubmit.ForeColor = SystemColors.Control;
            btnSubmit.Location = new Point(573, 345);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(115, 41);
            btnSubmit.TabIndex = 19;
            btnSubmit.Text = "SUBMIT";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources._482144123_9398402743587514_2257695987033967719_n;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(91, 25);
            panel1.Name = "panel1";
            panel1.Size = new Size(614, 113);
            panel1.TabIndex = 21;
            // 
            // panel2
            // 
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Controls.Add(radioButton2);
            panel2.Controls.Add(radioButton1);
            panel2.Controls.Add(radioButton3);
            panel2.Controls.Add(radioButton4);
            panel2.Location = new Point(91, 153);
            panel2.Name = "panel2";
            panel2.Size = new Size(614, 177);
            panel2.TabIndex = 22;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlText;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(btnBack);
            Controls.Add(btnSubmit);
            Name = "Form3";
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
        private Button btnBack;
        private Button btnSubmit;
        private Panel panel1;
        private Panel panel2;
    }
}
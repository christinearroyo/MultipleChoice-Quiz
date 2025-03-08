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
            radioButton4 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            label1 = new Label();
            btnBack = new Button();
            btnSubmit = new Button();
            SuspendLayout();
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(122, 307);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(65, 24);
            radioButton4.TabIndex = 18;
            radioButton4.TabStop = true;
            radioButton4.Text = "Wind";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(122, 264);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(62, 24);
            radioButton3.TabIndex = 17;
            radioButton3.TabStop = true;
            radioButton3.Text = "West";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(122, 216);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(85, 24);
            radioButton2.TabIndex = 16;
            radioButton2.TabStop = true;
            radioButton2.Text = "Window";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(122, 175);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(60, 24);
            radioButton1.TabIndex = 15;
            radioButton1.TabStop = true;
            radioButton1.Text = "Web";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(220, 89);
            label1.Name = "label1";
            label1.Size = new Size(237, 20);
            label1.TabIndex = 14;
            label1.Text = "WWW stands for World Wide _____";
            // 
            // btnBack
            // 
            btnBack.Location = new Point(112, 362);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 20;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(611, 362);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(94, 29);
            btnSubmit.TabIndex = 19;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBack);
            Controls.Add(btnSubmit);
            Controls.Add(radioButton4);
            Controls.Add(radioButton3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(label1);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton radioButton4;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Label label1;
        private Button btnBack;
        private Button btnSubmit;
    }
}
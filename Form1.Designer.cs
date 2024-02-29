namespace FindNumberWithCS
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
            display = new Label();
            answerTextBox = new TextBox();
            randomNumberGeneratorButton = new Button();
            answerSubminButton = new Button();
            SuspendLayout();
            // 
            // display
            // 
            display.AutoSize = true;
            display.Font = new Font("맑은 고딕", 20F, FontStyle.Regular, GraphicsUnit.Point, 129);
            display.Location = new Point(797, 67);
            display.Name = "display";
            display.Size = new Size(331, 54);
            display.TabIndex = 0;
            display.Text = "랜덤 숫자 맞추기";
            // 
            // answerTextBox
            // 
            answerTextBox.Font = new Font("맑은 고딕", 20F, FontStyle.Regular, GraphicsUnit.Point, 129);
            answerTextBox.Location = new Point(977, 189);
            answerTextBox.Name = "answerTextBox";
            answerTextBox.Size = new Size(265, 61);
            answerTextBox.TabIndex = 1;
            answerTextBox.TextAlign = HorizontalAlignment.Center;
            answerTextBox.TextChanged += answerTextBox_TextChanged;
            // 
            // randomNumberGeneratorButton
            // 
            randomNumberGeneratorButton.Font = new Font("맑은 고딕", 16F, FontStyle.Regular, GraphicsUnit.Point, 129);
            randomNumberGeneratorButton.Location = new Point(565, 189);
            randomNumberGeneratorButton.Name = "randomNumberGeneratorButton";
            randomNumberGeneratorButton.Size = new Size(406, 61);
            randomNumberGeneratorButton.TabIndex = 2;
            randomNumberGeneratorButton.Text = "랜덤 숫자 생성(0~100)";
            randomNumberGeneratorButton.UseVisualStyleBackColor = true;
            randomNumberGeneratorButton.Click += randomNumberGeneratorButton_Click;
            // 
            // answerSubminButton
            // 
            answerSubminButton.Font = new Font("맑은 고딕", 20F, FontStyle.Regular, GraphicsUnit.Point, 129);
            answerSubminButton.Location = new Point(-2, 256);
            answerSubminButton.Name = "answerSubminButton";
            answerSubminButton.Size = new Size(1975, 192);
            answerSubminButton.TabIndex = 3;
            answerSubminButton.Text = "제출";
            answerSubminButton.UseVisualStyleBackColor = true;
            answerSubminButton.Click += answerSubminButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1974, 444);
            Controls.Add(answerSubminButton);
            Controls.Add(randomNumberGeneratorButton);
            Controls.Add(answerTextBox);
            Controls.Add(display);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label display;
        private TextBox answerTextBox;
        private Button randomNumberGeneratorButton;
        private Button answerSubminButton;
    }
}

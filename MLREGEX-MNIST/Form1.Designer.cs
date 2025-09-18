namespace MLREGEX_MNIST
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
            buttonMNISTRegexMatch = new Button();
            SuspendLayout();
            // 
            // buttonMNISTRegexMatch
            // 
            buttonMNISTRegexMatch.Location = new Point(81, 66);
            buttonMNISTRegexMatch.Name = "buttonMNISTRegexMatch";
            buttonMNISTRegexMatch.Size = new Size(131, 40);
            buttonMNISTRegexMatch.TabIndex = 0;
            buttonMNISTRegexMatch.Text = "MLREGEX_MNIST";
            buttonMNISTRegexMatch.UseVisualStyleBackColor = true;
            buttonMNISTRegexMatch.Click += buttonMNISTRegexMatch_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonMNISTRegexMatch);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonMNISTRegexMatch;
    }
}

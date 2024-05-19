namespace Kpiz
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.generateButton = new System.Windows.Forms.Button();
            this.messageInputBox = new System.Windows.Forms.TextBox();
            this.answerText = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.generateButtonFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(136, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введіть текст повідомлення:";
            // 
            // generateButton
            // 
            this.generateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateButton.Location = new System.Drawing.Point(34, 224);
            this.generateButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(163, 30);
            this.generateButton.TabIndex = 2;
            this.generateButton.Text = "Згенерувати хеш";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // messageInputBox
            // 
            this.messageInputBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messageInputBox.Location = new System.Drawing.Point(34, 54);
            this.messageInputBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.messageInputBox.Multiline = true;
            this.messageInputBox.Name = "messageInputBox";
            this.messageInputBox.Size = new System.Drawing.Size(422, 163);
            this.messageInputBox.TabIndex = 4;
            // 
            // answerText
            // 
            this.answerText.AutoSize = true;
            this.answerText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerText.Location = new System.Drawing.Point(11, 298);
            this.answerText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.answerText.Name = "answerText";
            this.answerText.Size = new System.Drawing.Size(84, 20);
            this.answerText.TabIndex = 3;
            this.answerText.Text = "MD5 хеш :";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // generateButtonFile
            // 
            this.generateButtonFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateButtonFile.Location = new System.Drawing.Point(242, 224);
            this.generateButtonFile.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.generateButtonFile.Name = "generateButtonFile";
            this.generateButtonFile.Size = new System.Drawing.Size(214, 30);
            this.generateButtonFile.TabIndex = 5;
            this.generateButtonFile.Text = "Згенерувати хеш файлу";
            this.generateButtonFile.UseVisualStyleBackColor = true;
            this.generateButtonFile.Click += new System.EventHandler(this.generateButtonFile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 366);
            this.Controls.Add(this.generateButtonFile);
            this.Controls.Add(this.messageInputBox);
            this.Controls.Add(this.answerText);
            this.Controls.Add(this.generateButton);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.TextBox messageInputBox;
        private System.Windows.Forms.Label answerText;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button generateButtonFile;
    }
}


namespace Калькулятор
{
    partial class InputBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InputBox));
            this.textBoxInputBox = new System.Windows.Forms.TextBox();
            this.labelInputBox = new System.Windows.Forms.Label();
            this.buttonInputBox = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxInputBox
            // 
            this.textBoxInputBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.textBoxInputBox.Location = new System.Drawing.Point(12, 40);
            this.textBoxInputBox.Name = "textBoxInputBox";
            this.textBoxInputBox.Size = new System.Drawing.Size(169, 29);
            this.textBoxInputBox.TabIndex = 0;
            this.textBoxInputBox.TextChanged += new System.EventHandler(this.textBoxInput_TextChanged);
            // 
            // labelInputBox
            // 
            this.labelInputBox.AutoSize = true;
            this.labelInputBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.labelInputBox.Location = new System.Drawing.Point(13, 12);
            this.labelInputBox.Name = "labelInputBox";
            this.labelInputBox.Size = new System.Drawing.Size(60, 24);
            this.labelInputBox.TabIndex = 1;
            this.labelInputBox.Text = "label1";
            // 
            // buttonInputBox
            // 
            this.buttonInputBox.Location = new System.Drawing.Point(198, 46);
            this.buttonInputBox.Name = "buttonInputBox";
            this.buttonInputBox.Size = new System.Drawing.Size(75, 23);
            this.buttonInputBox.TabIndex = 2;
            this.buttonInputBox.Text = "OK";
            this.buttonInputBox.UseVisualStyleBackColor = true;
            this.buttonInputBox.Click += new System.EventHandler(this.buttonInputBox_Click);
            // 
            // InputBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(280, 81);
            this.Controls.Add(this.buttonInputBox);
            this.Controls.Add(this.labelInputBox);
            this.Controls.Add(this.textBoxInputBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InputBox";
            this.Text = "InputBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxInputBox;
        private System.Windows.Forms.Label labelInputBox;
        private System.Windows.Forms.Button buttonInputBox;
    }
}
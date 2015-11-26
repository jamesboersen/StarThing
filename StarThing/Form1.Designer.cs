namespace StarThing
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
            this.xTextBox = new System.Windows.Forms.TextBox();
            this.yTextBox = new System.Windows.Forms.TextBox();
            this.sizeTextBox = new System.Windows.Forms.TextBox();
            this.xLabel = new System.Windows.Forms.Label();
            this.yLabel = new System.Windows.Forms.Label();
            this.sizeLabel = new System.Windows.Forms.Label();
            this.enterButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // xTextBox
            // 
            this.xTextBox.Location = new System.Drawing.Point(447, 28);
            this.xTextBox.Name = "xTextBox";
            this.xTextBox.Size = new System.Drawing.Size(100, 20);
            this.xTextBox.TabIndex = 0;
            // 
            // yTextBox
            // 
            this.yTextBox.Location = new System.Drawing.Point(447, 70);
            this.yTextBox.Name = "yTextBox";
            this.yTextBox.Size = new System.Drawing.Size(100, 20);
            this.yTextBox.TabIndex = 1;
            // 
            // sizeTextBox
            // 
            this.sizeTextBox.Location = new System.Drawing.Point(447, 109);
            this.sizeTextBox.Name = "sizeTextBox";
            this.sizeTextBox.Size = new System.Drawing.Size(100, 20);
            this.sizeTextBox.TabIndex = 2;
            // 
            // xLabel
            // 
            this.xLabel.AutoSize = true;
            this.xLabel.Location = new System.Drawing.Point(407, 31);
            this.xLabel.Name = "xLabel";
            this.xLabel.Size = new System.Drawing.Size(14, 13);
            this.xLabel.TabIndex = 3;
            this.xLabel.Text = "X";
            // 
            // yLabel
            // 
            this.yLabel.AutoSize = true;
            this.yLabel.Location = new System.Drawing.Point(407, 73);
            this.yLabel.Name = "yLabel";
            this.yLabel.Size = new System.Drawing.Size(14, 13);
            this.yLabel.TabIndex = 4;
            this.yLabel.Text = "Y";
            // 
            // sizeLabel
            // 
            this.sizeLabel.AutoSize = true;
            this.sizeLabel.Location = new System.Drawing.Point(394, 112);
            this.sizeLabel.Name = "sizeLabel";
            this.sizeLabel.Size = new System.Drawing.Size(27, 13);
            this.sizeLabel.TabIndex = 5;
            this.sizeLabel.Text = "Size";
            // 
            // enterButton
            // 
            this.enterButton.Location = new System.Drawing.Point(447, 145);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(94, 32);
            this.enterButton.TabIndex = 6;
            this.enterButton.Text = "Enter";
            this.enterButton.UseVisualStyleBackColor = true;
            this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 462);
            this.Controls.Add(this.enterButton);
            this.Controls.Add(this.sizeLabel);
            this.Controls.Add(this.yLabel);
            this.Controls.Add(this.xLabel);
            this.Controls.Add(this.sizeTextBox);
            this.Controls.Add(this.yTextBox);
            this.Controls.Add(this.xTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox xTextBox;
        private System.Windows.Forms.TextBox yTextBox;
        private System.Windows.Forms.TextBox sizeTextBox;
        private System.Windows.Forms.Label xLabel;
        private System.Windows.Forms.Label yLabel;
        private System.Windows.Forms.Label sizeLabel;
        private System.Windows.Forms.Button enterButton;
    }
}


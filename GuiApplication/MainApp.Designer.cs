namespace GuiApplication
{
    partial class MainApp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up resources.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support.
        /// </summary>
        private void InitializeComponent()
        {
            UserInput = new System.Windows.Forms.TextBox();
            ResponseBox = new System.Windows.Forms.TextBox();
            SendBotton = new System.Windows.Forms.Button();
            pictureBox1 = new System.Windows.Forms.PictureBox();

            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();

            // UserInput
            UserInput.Location = new System.Drawing.Point(214, 373);
            UserInput.Name = "UserInput";
            UserInput.Size = new System.Drawing.Size(422, 23);
            UserInput.TabIndex = 0;
            UserInput.TextChanged += UserInput_TextChanged;

            // ResponseBox
            ResponseBox.Location = new System.Drawing.Point(214, 26);
            ResponseBox.Multiline = true;
            ResponseBox.ReadOnly = true;
            ResponseBox.Name = "ResponseBox";
            ResponseBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            ResponseBox.Size = new System.Drawing.Size(503, 305);
            ResponseBox.TabIndex = 1;

            // SendBotton
            SendBotton.Location = new System.Drawing.Point(642, 373);
            SendBotton.Name = "SendBotton";
            SendBotton.Size = new System.Drawing.Size(75, 23);
            SendBotton.TabIndex = 2;
            SendBotton.Text = "Send";
            SendBotton.UseVisualStyleBackColor = true;
            SendBotton.Click += SendBotton_Click;

            // pictureBox1
            pictureBox1.Location = new System.Drawing.Point(12, 26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(120, 85);
            pictureBox1.SizeMode =
                System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;

            // MainApp
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode =
                System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);

            Controls.Add(pictureBox1);
            Controls.Add(SendBotton);
            Controls.Add(ResponseBox);
            Controls.Add(UserInput);

            Name = "MainApp";
            Text = "Cybersecurity Bot";

            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox UserInput;
        private System.Windows.Forms.TextBox ResponseBox;
        private System.Windows.Forms.Button SendBotton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
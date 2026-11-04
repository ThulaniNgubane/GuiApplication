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
            components = new System.ComponentModel.Container();
            UserInput = new TextBox();
            ResponseBox = new TextBox();
            SendBotton = new Button();
            pictureBox1 = new PictureBox();
            notifyIcon1 = new NotifyIcon(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // UserInput
            // 
            UserInput.BackColor = Color.White;
            UserInput.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UserInput.Location = new Point(306, 622);
            UserInput.Margin = new Padding(4, 5, 4, 5);
            UserInput.Name = "UserInput";
            UserInput.Size = new Size(601, 37);
            UserInput.TabIndex = 0;
            UserInput.TextChanged += UserInput_TextChanged;
            // 
            // ResponseBox
            // 
            ResponseBox.BackColor = Color.FromArgb(255, 128, 128);
            ResponseBox.Font = new Font("Nirmala UI", 14.25F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            ResponseBox.Location = new Point(306, 43);
            ResponseBox.Margin = new Padding(4, 5, 4, 5);
            ResponseBox.Multiline = true;
            ResponseBox.Name = "ResponseBox";
            ResponseBox.ReadOnly = true;
            ResponseBox.ScrollBars = ScrollBars.Vertical;
            ResponseBox.Size = new Size(717, 506);
            ResponseBox.TabIndex = 1;
            // 
            // SendBotton
            // 
            SendBotton.Location = new Point(917, 622);
            SendBotton.Margin = new Padding(4, 5, 4, 5);
            SendBotton.Name = "SendBotton";
            SendBotton.Size = new Size(107, 38);
            SendBotton.TabIndex = 2;
            SendBotton.Text = "Send";
            SendBotton.UseVisualStyleBackColor = true;
            SendBotton.Click += SendBotton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(32, 25);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(73, 68);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // notifyIcon1
            // 
            notifyIcon1.Text = "notifyIcon1";
            notifyIcon1.Visible = true;
            // 
            // MainApp
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 750);
            Controls.Add(pictureBox1);
            Controls.Add(SendBotton);
            Controls.Add(ResponseBox);
            Controls.Add(UserInput);
            Margin = new Padding(4, 5, 4, 5);
            Name = "MainApp";
            Text = "Toolz Cybersecurity";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox UserInput;
        private System.Windows.Forms.TextBox ResponseBox;
        private System.Windows.Forms.Button SendBotton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private NotifyIcon notifyIcon1;
    }
}
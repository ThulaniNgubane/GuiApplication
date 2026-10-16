namespace GuiApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DisplayBackground();
 

        }

        private void DisplayBackground()
        {
            this.BackgroundImage = Image.FromFile("C:\\Users\\Student\\source\\repos\\GUI\\GUI Application\\PART 2\\GuiApplication\\GuiApplication\\Images\\1 (1).png");
            this.BackgroundImageLayout = ImageLayout.Stretch;

    
            pictureBox1.Image = Image.FromFile(
                @"C:\Users\Student\source\repos\GUI\GUI Application\PART 2\GuiApplication\GuiApplication\Images\Logo.png");

            pictureBox1.Size = new Size(150, 100);
            pictureBox1.Location = new Point(20, 20);

       
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;

            pictureBox1.BackColor = Color.Transparent;

           
            this.Controls.Add(pictureBox1);

    
            pictureBox1.BringToFront();
        
        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Open the next page (Form2) and hide the current form
                MainApp nextForm = new MainApp();
                nextForm.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not open the next page: " + ex.Message);
            }
        }

     
        }

    }

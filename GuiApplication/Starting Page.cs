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
            this.BackgroundImage = Image.FromFile("C:\\Users\\Student\\source\\repos\\GUI\\GUI Application\\PART 2\\GUI APP\\GUI APP\\Images\\Landing Background.png");
            this.BackgroundImageLayout = ImageLayout.Stretch;
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DisplayLogo();
        }
        private void DisplayLogo()
        {
            PictureBox pictureBox1 = new PictureBox();
            pictureBox1.Image = Image.FromFile("C:\\Users\\Student\\source\\repos\\GUI\\GUI Application\\PART 2\\GUI APP\\GUI APP\\Images\\Logo.png");
        }

    }
}
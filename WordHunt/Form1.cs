namespace WordHunt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Words words = new Words();
            this.Hide();
            words.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Game2 game = new Game2();
            this.Hide();
            game.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
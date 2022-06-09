namespace Contact_Tracing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAttention_Click(object sender, EventArgs e)
        {
            MessageBox.Show("We will not, in any circumstances, share your personal information with other individuals or organizations without your permission, including public organizations, corporations or individuals, except when applicable by law.");
        }
    }
}
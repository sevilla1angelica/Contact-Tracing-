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

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtbxLastname.Text == "" || txtbxFirstname.Text == "" || txtbxMiddlename.Text == "" || txtbxExtensionname.Text == "" || txtbxGender.Text == "" || txtbxBirthdate.Text == "" || txtbxPhonenumber.Text == "" || txtbxEmailaddress.Text == "" || txtbxHomeno.Text == "" || txtbxBarangay.Text == "" || txtbxCity.Text == "" || txtbxZipcode.Text == "" || txtbxCountry.Text == "" || txtbxCough.Text == "" || txtbxFever.Text == "" || txtbxLossoftasteorsmell.Text == "" || txtbxShortnessofbreath.Text == "" || txtbxSoreThroat.Text == "" || txtbxDiarrhea.Text == "")
            {
                MessageBox.Show("please fill up the form completely, thank you", "Error", MessageBoxButtons.OK);
            }
            else
            {
                StreamWriter file = new StreamWriter(@"C:\Users\HP\OneDrive\Desktop\C# Programs\contacttracingrec.txt", true);
                file.WriteLine("Last Name: " + txtbxLastname.Text);
                file.WriteLine("First Name: " + txtbxFirstname.Text);
                file.WriteLine("Middle Name: " + txtbxMiddlename.Text);
                file.WriteLine("Extension Name: " + txtbxExtensionname.Text);

                file.WriteLine("Gender: " + txtbxGender.Text);
                file.WriteLine("Birthdate: " + txtbxBirthdate.Text);
                file.WriteLine("Phone number: " + txtbxPhonenumber.Text);
                file.WriteLine("Email address: " + txtbxEmailaddress.Text);

                file.WriteLine("Home number, St. Name, Subdivision: " + txtbxHomeno.Text);
                file.WriteLine("Barangay: " + txtbxBarangay.Text);
                file.WriteLine("City: " + txtbxCity.Text);
                file.WriteLine("Zip code: " + txtbxZipcode.Text);
                file.WriteLine("Country: " + txtbxCountry.Text);

                file.WriteLine("Cough: " + txtbxCough.Text);
                file.WriteLine("Fever: " + txtbxFever.Text);
                file.WriteLine("Loss of taste or smell: " + txtbxLossoftasteorsmell.Text);
                file.WriteLine("Shortness of Breathe: " + txtbxShortnessofbreath.Text);
                file.WriteLine("Sore Throat: " + txtbxSoreThroat.Text);
                file.WriteLine("Diarrhea: " + txtbxDiarrhea.Text);

                file.Close();
                MessageBox.Show("Thank you!", "Keep safe.", MessageBoxButtons.OK);
                Application.Exit();
            }
        }
    }
}
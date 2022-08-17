namespace ExercicioDictionary

{
    public partial class GetVowels : Form
    {
        public GetVowels()
        {
            InitializeComponent();
        }

        private void txbInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txbInput.Clear();
            lblOutput.Text = "";
        }
        private void btnRunScript_Click(object sender, EventArgs e)
        {
            Dictionary<char, int> vowelsDictionary = new Dictionary<char, int>();
            Services.ResetDictionary(vowelsDictionary);
            Services.GetVowels(vowelsDictionary, txbInput.Text.ToLower());
            
            foreach (var item in vowelsDictionary)
            {
                lblOutput.Text += ($"{item.Key} aparece {item.Value} vezes\n");
            }

        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GetVowels_Load(object sender, EventArgs e)
        {
            
        }
    }
}
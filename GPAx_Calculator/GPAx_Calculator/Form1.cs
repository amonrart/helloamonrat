namespace GPAx_Calculator
{
    public partial class Form1 : Form
    {
        GPACalculator oGPACal = new GPACalculator();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string input = this.textBoxGPA_input.Text;
            string name = this.textBoxName_input.Text;
            double dInput = Convert.ToDouble(input);
            oGPACal.addGPA(dInput, name);

            double gpax = oGPACal.getGPAx();
            textBoxGPAX.Text = gpax.ToString();

            double max = oGPACal.getMax();
            textBoxMaxGPA.Text = oGPACal.getMax().ToString();
            textBoxMaxName.Text = oGPACal.getMaxName().ToString();

            double min = oGPACal.getMin();
            textBoxMinGPA.Text = oGPACal.getMin().ToString();
            textBoxMinName.Text = oGPACal.getMinName().ToString();

            textBoxGPA_input.Text = "";
            textBoxName_input.Text = "";
            textBoxAllData.Text = oGPACal.getAlldata();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxGPAX.Text = "";
            textBoxGPA_input.Text = "";
            textBoxMinGPA.Text = "";
            textBoxMaxGPA.Text = "";

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
namespace GPAxCakulator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBoxGPA_input_TextChanged(object sender, EventArgs e)
        {
            


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //4.00
            string strInput = textBoxGPA_input.Text;

            double sum = 0.0;

            double dInput = double.Parse(strInput);

            //sum = 0.0 + "4.00"
            sum = sum + dInput;
            //convert double to strint and settext to textbox
            textBoxGPA_input.Text = sum.ToString();
        }

        
    

<<<<<<< HEAD
using System.Text;

namespace Student_Management
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "CSV (*.csv) | *.csv";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string[] readAllLine = File.ReadAllLines(openFileDialog.FileName);

                for (int i = 0; i < readAllLine.Length; i++)
                {
                    string studentRAW = readAllLine[i];
                    string[] studenSplied = studentRAW.Split(',');
                    Student student = new Student(studenSplied[0], studenSplied[1], studenSplied[2]);
                    //addDataToGridView(student);
                    //TODO: Add Student object to DataGridView
                }


            }

        }
        private void addDataToGridView(string id, string name, string major)
        {
            //this.dataGridView1.Rows.Add(new string[] { id, name, major });
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string strdata = string.Empty;


            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "CSV(*.csv) | *.csv";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (saveFileDialog.FileName != string.Empty)
                {
                    int column = this.dataGridView1.Rows.Count;
                    int Row = 0;
                    for (int i = 0; i < Row; i++)
                    {

                        for (int j = 0; j < dataGridView1.Columns.Count; j++)
                        {
                            //strdata = this.dataGridView1.Rows[i].Cells[j].Value.ToString();
                        }
                    }
                }

                File.WriteAllText(saveFileDialog.FileName, strdata, Encoding.UTF8);
            }
        }

       

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows[0].Cells[0].Value = textBoxid.Text;
            dataGridView1.Rows[0].Cells[1].Value = textBoxname.Text;
            dataGridView1.Rows[0].Cells[2].Value = comboBoxMajor.Text;


            Calculator calculator = new Calculator();
            string input = textBoxGpa.Text;


            double dInput = Convert.ToDouble(input);
            calculator.addGPA(dInput, Name);

            double gpax = calculator.getGPAx();
            textBoxGpax.Text = gpax.ToString();

            double max = calculator.getMax();
            textBoxMax.Text = max.ToString();

            double min = calculator.getMin();
            textBoxMin.Text = min.ToString();
        }
    }
}
=======
using System.Text;

namespace Student_Management
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "CSV (*.csv) | *.csv";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string[] readAllLine = File.ReadAllLines(openFileDialog.FileName);

                for (int i = 0; i < readAllLine.Length; i++)
                {
                    string studentRAW = readAllLine[i];
                    string[] studenSplied = studentRAW.Split(',');
                    Student student = new Student(studenSplied[0], studenSplied[1], studenSplied[2]);
                    //addDataToGridView(student);
                    //TODO: Add Student object to DataGridView
                }


            }

        }
        private void addDataToGridView(string id, string name, string major)
        {
            //this.dataGridView1.Rows.Add(new string[] { id, name, major });
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string strdata = string.Empty;


            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "CSV(*.csv) | *.csv";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (saveFileDialog.FileName != string.Empty)
                {
                    int column = this.dataGridView1.Rows.Count;
                    int Row = 0;
                    for (int i = 0; i < Row; i++)
                    {

                        for (int j = 0; j < dataGridView1.Columns.Count; j++)
                        {
                            //strdata = this.dataGridView1.Rows[i].Cells[j].Value.ToString();
                        }
                    }
                }

                File.WriteAllText(saveFileDialog.FileName, strdata, Encoding.UTF8);
            }
        }

       

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows[0].Cells[0].Value = textBoxid.Text;
            dataGridView1.Rows[0].Cells[1].Value = textBoxname.Text;
            dataGridView1.Rows[0].Cells[2].Value = comboBoxMajor.Text;


            Calculator calculator = new Calculator();
            string input = textBoxGpa.Text;


            double dInput = Convert.ToDouble(input);
            calculator.addGPA(dInput, Name);

            double gpax = calculator.getGPAx();
            textBoxGpax.Text = gpax.ToString();

            double max = calculator.getMax();
            textBoxMax.Text = max.ToString();

            double min = calculator.getMin();
            textBoxMin.Text = min.ToString();
        }
    }
}
>>>>>>> 0562862f618c5f1f45062cae48225ad01025ab61
           
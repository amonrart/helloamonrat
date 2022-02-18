using System.Text;

namespace Student_Management_App
{
    public partial class Form1 : Form
    {
        private string readAllText;

        public Form1()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.FileName = "CSV (*.csv) | *.csv";
            if (openFileDialog.ShowDialog() == DialogResult.OK) {
                string[] readAllLine = File.ReadAllLines(openFileDialog.FileName);
                string readAllText = File.ReadAllText(openFileDialog.FileName);
                //this.textBox1.Text = readAllText;
                //this.dataGridView1.Rows.Add()

                for (int i =0; i < readAllLine.Length; i++) {
                    string studentRAW = readAllLine[i];
                    //Student student = new Student(studentRAW[0], studentRAW[1], studentREW[2]);
                }
                addDataToGridView("01","nlme","cis");
            }


        }
        private void addDataToGridView(string id, string name, string major) {
            this.dataGridView1.Rows.Add(new string[] { id, name, major });
        }

       
            
        
            
       
        


        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {


            string strData = string.Empty;
            
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "CSV (*.csv) | *.csv";
            if (saveFileDialog.ShowDialog() == DialogResult.OK) {
                if (saveFileDialog.FileName != String .Empty) {
                    

                    int row = this.dataGridView1.Rows.Count;
                    for (int i = 0; i < row; i++)
                    {
                        int column = this.dataGridView1.Columns.Count;
                        for (int j = 0; j < column; j++) {
                            strData = this.dataGridView1.Rows[i].Cells[j].Value.ToString();
                            //TODO save data from dataGridView1 to variable
                        }
                    }


                    //save file
                    File.WriteAllText(saveFileDialog.FileName, strData, Encoding.UTF8);
                }
            }

        }
    }
}
using DBL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;

namespace StudentApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonElave_Click(object sender, EventArgs e)
        {
            string ad= textBoxAd.Text;
            int yas= Convert.ToInt32(textBoxyash.Text);

            StudentRepository studentRepository = new StudentRepository();
            studentRepository.Save(ad,yas);
            textBoxAd.Clear();
            textBoxyash.Clear();

            dataGridView1.DataSource = studentRepository.GetAllData();
        }

        private void buttonDeyis_Click(object sender, EventArgs e)
        {
            string ad = textBoxAd.Text;
            int yas = Convert.ToInt32(textBoxyash.Text);

            StudentRepository studentRepository = new StudentRepository();
            int stID = Convert.ToInt32(dataGridView1.SelectedCells[0].Value);
            if (stID > 0)
            {
                studentRepository.Update(stID, ad,yas);
            }
            else
            {
                MessageBox.Show("Student ID sec");
            }
            dataGridView1.DataSource = studentRepository.GetAllData();
            textBoxAd.Clear();
            textBoxyash.Clear();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StudentRepository studentRepository = new StudentRepository();
            dataGridView1.DataSource = studentRepository.GetAllData();
        }

        private void buttonSil_Click(object sender, EventArgs e)
        {

           

            StudentRepository studentRepository = new StudentRepository();
            int stID = Convert.ToInt32(dataGridView1.SelectedCells[0].Value);
            if (stID > 0)
            {
                studentRepository.Delete(stID);
            }
            else
            {
                MessageBox.Show("Silmek ucun Student ID sec");
            }
            dataGridView1.DataSource = studentRepository.GetAllData();
           
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization; 

namespace StudentMarksSytem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        BindingSource source = new BindingSource();
        DataHandler d1 = new DataHandler();
        List<Students> allStudents = new List<Students>(); 
        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = source;
            allStudents = d1.InitList();
            allStudents.Sort();
            source.DataSource = allStudents;
            dataGridView1.DataSource = source;
            CultureInfo ci = new CultureInfo("en-ZA"); 
            dataGridView1.Columns["Payment1"].DefaultCellStyle.FormatProvider = ci;
            dataGridView1.Columns["Payment1"].DefaultCellStyle.Format = "c"; 
        }

        private void BtnViewAll_Click(object sender, EventArgs e)
        {

            allStudents = d1.InitList();
            
            source.DataSource = allStudents;
            dataGridView1.DataSource = source;

        }

        private void BtnFulltimeStudents_Click(object sender, EventArgs e)
        {
            List<FulltimeStudents> fullTimeList = new List<FulltimeStudents>();
            foreach (Students item in allStudents)
            {
                if (item is FulltimeStudents)
                {
                    fullTimeList.Add(item as FulltimeStudents);
                }
            }
            fullTimeList.Sort(); 
            source.DataSource = fullTimeList;
            dataGridView1.DataSource = source;
        }

        private void btnPartTimeStudents_Click(object sender, EventArgs e)
        {
            //List<Students> allStudents = d1.InitList();

            List<PartTimeStudents> partTimeList = new List<PartTimeStudents>();
            foreach (Students item in allStudents)
            {
                if (item is PartTimeStudents)
                {
                    partTimeList.Add(item as PartTimeStudents);
                }
            }


            partTimeList.Sort(); 

            source.DataSource = partTimeList;
            dataGridView1.DataSource = source;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            source.MoveFirst();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            source.MoveNext(); 

        }

        private void button3_Click(object sender, EventArgs e)
        {
            source.MovePrevious(); 
        }

        private void button4_Click(object sender, EventArgs e)
        {
            source.MoveLast();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            allStudents = d1.InitList();
            allStudents.Sort();
            int searchitem = int.Parse(textBox1.Text);
            foreach (Students item in allStudents)
            {
                if (item.StudentNumber == searchitem)
                {
                    Sname.Text = item.StudentName1;
                    lblMark.Text = item.Average.ToString();
                    LblResult.Text = item.Results;
                    lblFees.Text = item.Fees.ToString();
                    Payment.Text = item.Payment1.ToString();
                }
            }
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.ТелфонияDataSetTableAdapters;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "телфонияDataSet.Table_1". При необходимости она может быть перемещена или удалена.
            this.table_1TableAdapter.Fill(this.телфонияDataSet.Table_1);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            table1BindingSource.EndEdit();
            table_1TableAdapter.Update(телфонияDataSet.Table_1);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            table1BindingSource.RemoveCurrent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            table1BindingSource.MoveFirst();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            table1BindingSource.MoveLast();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            table1BindingSource.MovePrevious();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            table1BindingSource.MoveNext();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            table1BindingSource.AddNew();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void арендаBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.арендаBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.торговый_центрDataSet);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "торговый_центрDataSet.Аренда". При необходимости она может быть перемещена или удалена.
            this.арендаTableAdapter.Fill(this.торговый_центрDataSet.Аренда);

        }

        private void цель_арендыLabel_Click(object sender, EventArgs e)
        {

        }

        private void цель_арендыTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void фИОLabel_Click(object sender, EventArgs e)
        {

        }

        private void фИОTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

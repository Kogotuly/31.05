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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void участкиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.участкиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.торговый_центрDataSet);

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "торговый_центрDataSet.Участки". При необходимости она может быть перемещена или удалена.
            this.участкиTableAdapter.Fill(this.торговый_центрDataSet.Участки);

        }

        private void услугиTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void дата_окончания_арендыLabel_Click(object sender, EventArgs e)
        {

        }

        private void дата_окончания_арендыDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void услугиLabel_Click(object sender, EventArgs e)
        {

        }
    }
}

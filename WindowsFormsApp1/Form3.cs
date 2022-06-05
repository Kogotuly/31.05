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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void договораBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.договораBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.торговый_центрDataSet);

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "торговый_центрDataSet.Договора". При необходимости она может быть перемещена или удалена.
            this.договораTableAdapter.Fill(this.торговый_центрDataSet.Договора);

        }
    }
}

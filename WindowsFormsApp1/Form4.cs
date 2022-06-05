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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void оплатаBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.оплатаBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.торговый_центрDataSet);

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "торговый_центрDataSet.Оплата". При необходимости она может быть перемещена или удалена.
            this.оплатаTableAdapter.Fill(this.торговый_центрDataSet.Оплата);

        }
    }
}

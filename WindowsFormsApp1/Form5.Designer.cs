namespace WindowsFormsApp1
{
    partial class Form5
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            System.Windows.Forms.Label iD_АрендатораLabel;
            System.Windows.Forms.Label магазинLabel;
            System.Windows.Forms.Label площадьLabel;
            System.Windows.Forms.Label дата_начала_арендыLabel;
            System.Windows.Forms.Label дата_окончания_арендыLabel;
            System.Windows.Forms.Label услугиLabel;
            this.торговый_центрDataSet = new WindowsFormsApp1.Торговый_центрDataSet();
            this.участкиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.участкиTableAdapter = new WindowsFormsApp1.Торговый_центрDataSetTableAdapters.УчасткиTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp1.Торговый_центрDataSetTableAdapters.TableAdapterManager();
            this.участкиBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.участкиBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.iD_АрендатораTextBox = new System.Windows.Forms.TextBox();
            this.магазинTextBox = new System.Windows.Forms.TextBox();
            this.площадьTextBox = new System.Windows.Forms.TextBox();
            this.дата_начала_арендыDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.дата_окончания_арендыDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.услугиTextBox = new System.Windows.Forms.TextBox();
            iD_АрендатораLabel = new System.Windows.Forms.Label();
            магазинLabel = new System.Windows.Forms.Label();
            площадьLabel = new System.Windows.Forms.Label();
            дата_начала_арендыLabel = new System.Windows.Forms.Label();
            дата_окончания_арендыLabel = new System.Windows.Forms.Label();
            услугиLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.торговый_центрDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.участкиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.участкиBindingNavigator)).BeginInit();
            this.участкиBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // торговый_центрDataSet
            // 
            this.торговый_центрDataSet.DataSetName = "Торговый_центрDataSet";
            this.торговый_центрDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // участкиBindingSource
            // 
            this.участкиBindingSource.DataMember = "Участки";
            this.участкиBindingSource.DataSource = this.торговый_центрDataSet;
            // 
            // участкиTableAdapter
            // 
            this.участкиTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp1.Торговый_центрDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.АрендаTableAdapter = null;
            this.tableAdapterManager.Выборка__1TableAdapter = null;
            this.tableAdapterManager.Групповая_операция__1TableAdapter = null;
            this.tableAdapterManager.ДоговораTableAdapter = null;
            this.tableAdapterManager.ОплатаTableAdapter = null;
            this.tableAdapterManager.УчасткиTableAdapter = this.участкиTableAdapter;
            // 
            // участкиBindingNavigator
            // 
            this.участкиBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.участкиBindingNavigator.BindingSource = this.участкиBindingSource;
            this.участкиBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.участкиBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.участкиBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.участкиBindingNavigatorSaveItem});
            this.участкиBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.участкиBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.участкиBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.участкиBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.участкиBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.участкиBindingNavigator.Name = "участкиBindingNavigator";
            this.участкиBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.участкиBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.участкиBindingNavigator.TabIndex = 0;
            this.участкиBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 15);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // участкиBindingNavigatorSaveItem
            // 
            this.участкиBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.участкиBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("участкиBindingNavigatorSaveItem.Image")));
            this.участкиBindingNavigatorSaveItem.Name = "участкиBindingNavigatorSaveItem";
            this.участкиBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.участкиBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.участкиBindingNavigatorSaveItem.Click += new System.EventHandler(this.участкиBindingNavigatorSaveItem_Click);
            // 
            // iD_АрендатораLabel
            // 
            iD_АрендатораLabel.AutoSize = true;
            iD_АрендатораLabel.Location = new System.Drawing.Point(98, 77);
            iD_АрендатораLabel.Name = "iD_АрендатораLabel";
            iD_АрендатораLabel.Size = new System.Drawing.Size(84, 13);
            iD_АрендатораLabel.TabIndex = 1;
            iD_АрендатораLabel.Text = "ID Арендатора:";
            // 
            // iD_АрендатораTextBox
            // 
            this.iD_АрендатораTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.участкиBindingSource, "ID Арендатора", true));
            this.iD_АрендатораTextBox.Location = new System.Drawing.Point(188, 74);
            this.iD_АрендатораTextBox.Name = "iD_АрендатораTextBox";
            this.iD_АрендатораTextBox.Size = new System.Drawing.Size(100, 20);
            this.iD_АрендатораTextBox.TabIndex = 2;
            // 
            // магазинLabel
            // 
            магазинLabel.AutoSize = true;
            магазинLabel.Location = new System.Drawing.Point(128, 103);
            магазинLabel.Name = "магазинLabel";
            магазинLabel.Size = new System.Drawing.Size(54, 13);
            магазинLabel.TabIndex = 3;
            магазинLabel.Text = "Магазин:";
            // 
            // магазинTextBox
            // 
            this.магазинTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.участкиBindingSource, "Магазин", true));
            this.магазинTextBox.Location = new System.Drawing.Point(188, 100);
            this.магазинTextBox.Name = "магазинTextBox";
            this.магазинTextBox.Size = new System.Drawing.Size(100, 20);
            this.магазинTextBox.TabIndex = 4;
            // 
            // площадьLabel
            // 
            площадьLabel.AutoSize = true;
            площадьLabel.Location = new System.Drawing.Point(125, 129);
            площадьLabel.Name = "площадьLabel";
            площадьLabel.Size = new System.Drawing.Size(57, 13);
            площадьLabel.TabIndex = 5;
            площадьLabel.Text = "Площадь:";
            // 
            // площадьTextBox
            // 
            this.площадьTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.участкиBindingSource, "Площадь", true));
            this.площадьTextBox.Location = new System.Drawing.Point(188, 126);
            this.площадьTextBox.Name = "площадьTextBox";
            this.площадьTextBox.Size = new System.Drawing.Size(100, 20);
            this.площадьTextBox.TabIndex = 6;
            // 
            // дата_начала_арендыLabel
            // 
            дата_начала_арендыLabel.AutoSize = true;
            дата_начала_арендыLabel.Location = new System.Drawing.Point(67, 156);
            дата_начала_арендыLabel.Name = "дата_начала_арендыLabel";
            дата_начала_арендыLabel.Size = new System.Drawing.Size(115, 13);
            дата_начала_арендыLabel.TabIndex = 7;
            дата_начала_арендыLabel.Text = "Дата начала аренды:";
            // 
            // дата_начала_арендыDateTimePicker
            // 
            this.дата_начала_арендыDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.участкиBindingSource, "Дата начала аренды", true));
            this.дата_начала_арендыDateTimePicker.Location = new System.Drawing.Point(188, 152);
            this.дата_начала_арендыDateTimePicker.Name = "дата_начала_арендыDateTimePicker";
            this.дата_начала_арендыDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.дата_начала_арендыDateTimePicker.TabIndex = 8;
            // 
            // дата_окончания_арендыLabel
            // 
            дата_окончания_арендыLabel.AutoSize = true;
            дата_окончания_арендыLabel.Location = new System.Drawing.Point(49, 182);
            дата_окончания_арендыLabel.Name = "дата_окончания_арендыLabel";
            дата_окончания_арендыLabel.Size = new System.Drawing.Size(133, 13);
            дата_окончания_арендыLabel.TabIndex = 9;
            дата_окончания_арендыLabel.Text = "Дата окончания аренды:";
            дата_окончания_арендыLabel.Click += new System.EventHandler(this.дата_окончания_арендыLabel_Click);
            // 
            // дата_окончания_арендыDateTimePicker
            // 
            this.дата_окончания_арендыDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.участкиBindingSource, "Дата окончания аренды", true));
            this.дата_окончания_арендыDateTimePicker.Location = new System.Drawing.Point(188, 178);
            this.дата_окончания_арендыDateTimePicker.Name = "дата_окончания_арендыDateTimePicker";
            this.дата_окончания_арендыDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.дата_окончания_арендыDateTimePicker.TabIndex = 10;
            this.дата_окончания_арендыDateTimePicker.ValueChanged += new System.EventHandler(this.дата_окончания_арендыDateTimePicker_ValueChanged);
            // 
            // услугиLabel
            // 
            услугиLabel.AutoSize = true;
            услугиLabel.Location = new System.Drawing.Point(136, 207);
            услугиLabel.Name = "услугиLabel";
            услугиLabel.Size = new System.Drawing.Size(46, 13);
            услугиLabel.TabIndex = 11;
            услугиLabel.Text = "Услуги:";
            услугиLabel.Click += new System.EventHandler(this.услугиLabel_Click);
            // 
            // услугиTextBox
            // 
            this.услугиTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.участкиBindingSource, "Услуги", true));
            this.услугиTextBox.Location = new System.Drawing.Point(188, 204);
            this.услугиTextBox.Name = "услугиTextBox";
            this.услугиTextBox.Size = new System.Drawing.Size(100, 20);
            this.услугиTextBox.TabIndex = 12;
            this.услугиTextBox.TextChanged += new System.EventHandler(this.услугиTextBox_TextChanged);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(услугиLabel);
            this.Controls.Add(this.услугиTextBox);
            this.Controls.Add(дата_окончания_арендыLabel);
            this.Controls.Add(this.дата_окончания_арендыDateTimePicker);
            this.Controls.Add(дата_начала_арендыLabel);
            this.Controls.Add(this.дата_начала_арендыDateTimePicker);
            this.Controls.Add(площадьLabel);
            this.Controls.Add(this.площадьTextBox);
            this.Controls.Add(магазинLabel);
            this.Controls.Add(this.магазинTextBox);
            this.Controls.Add(iD_АрендатораLabel);
            this.Controls.Add(this.iD_АрендатораTextBox);
            this.Controls.Add(this.участкиBindingNavigator);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.торговый_центрDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.участкиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.участкиBindingNavigator)).EndInit();
            this.участкиBindingNavigator.ResumeLayout(false);
            this.участкиBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Торговый_центрDataSet торговый_центрDataSet;
        private System.Windows.Forms.BindingSource участкиBindingSource;
        private Торговый_центрDataSetTableAdapters.УчасткиTableAdapter участкиTableAdapter;
        private Торговый_центрDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator участкиBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton участкиBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox iD_АрендатораTextBox;
        private System.Windows.Forms.TextBox магазинTextBox;
        private System.Windows.Forms.TextBox площадьTextBox;
        private System.Windows.Forms.DateTimePicker дата_начала_арендыDateTimePicker;
        private System.Windows.Forms.DateTimePicker дата_окончания_арендыDateTimePicker;
        private System.Windows.Forms.TextBox услугиTextBox;
    }
}
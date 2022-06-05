namespace WindowsFormsApp1
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            System.Windows.Forms.Label iD_ОплатыLabel;
            System.Windows.Forms.Label дата_оплатыLabel;
            System.Windows.Forms.Label суммаLabel;
            this.торговый_центрDataSet = new WindowsFormsApp1.Торговый_центрDataSet();
            this.оплатаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.оплатаTableAdapter = new WindowsFormsApp1.Торговый_центрDataSetTableAdapters.ОплатаTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp1.Торговый_центрDataSetTableAdapters.TableAdapterManager();
            this.оплатаBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.оплатаBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.iD_ОплатыTextBox = new System.Windows.Forms.TextBox();
            this.дата_оплатыDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.суммаTextBox = new System.Windows.Forms.TextBox();
            iD_ОплатыLabel = new System.Windows.Forms.Label();
            дата_оплатыLabel = new System.Windows.Forms.Label();
            суммаLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.торговый_центрDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.оплатаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.оплатаBindingNavigator)).BeginInit();
            this.оплатаBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // торговый_центрDataSet
            // 
            this.торговый_центрDataSet.DataSetName = "Торговый_центрDataSet";
            this.торговый_центрDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // оплатаBindingSource
            // 
            this.оплатаBindingSource.DataMember = "Оплата";
            this.оплатаBindingSource.DataSource = this.торговый_центрDataSet;
            // 
            // оплатаTableAdapter
            // 
            this.оплатаTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp1.Торговый_центрDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.АрендаTableAdapter = null;
            this.tableAdapterManager.Выборка__1TableAdapter = null;
            this.tableAdapterManager.Групповая_операция__1TableAdapter = null;
            this.tableAdapterManager.ДоговораTableAdapter = null;
            this.tableAdapterManager.ОплатаTableAdapter = this.оплатаTableAdapter;
            this.tableAdapterManager.УчасткиTableAdapter = null;
            // 
            // оплатаBindingNavigator
            // 
            this.оплатаBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.оплатаBindingNavigator.BindingSource = this.оплатаBindingSource;
            this.оплатаBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.оплатаBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.оплатаBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.оплатаBindingNavigatorSaveItem});
            this.оплатаBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.оплатаBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.оплатаBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.оплатаBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.оплатаBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.оплатаBindingNavigator.Name = "оплатаBindingNavigator";
            this.оплатаBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.оплатаBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.оплатаBindingNavigator.TabIndex = 0;
            this.оплатаBindingNavigator.Text = "bindingNavigator1";
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
            // оплатаBindingNavigatorSaveItem
            // 
            this.оплатаBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.оплатаBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("оплатаBindingNavigatorSaveItem.Image")));
            this.оплатаBindingNavigatorSaveItem.Name = "оплатаBindingNavigatorSaveItem";
            this.оплатаBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.оплатаBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.оплатаBindingNavigatorSaveItem.Click += new System.EventHandler(this.оплатаBindingNavigatorSaveItem_Click);
            // 
            // iD_ОплатыLabel
            // 
            iD_ОплатыLabel.AutoSize = true;
            iD_ОплатыLabel.Location = new System.Drawing.Point(81, 67);
            iD_ОплатыLabel.Name = "iD_ОплатыLabel";
            iD_ОплатыLabel.Size = new System.Drawing.Size(63, 13);
            iD_ОплатыLabel.TabIndex = 1;
            iD_ОплатыLabel.Text = "ID Оплаты:";
            // 
            // iD_ОплатыTextBox
            // 
            this.iD_ОплатыTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.оплатаBindingSource, "ID Оплаты", true));
            this.iD_ОплатыTextBox.Location = new System.Drawing.Point(150, 64);
            this.iD_ОплатыTextBox.Name = "iD_ОплатыTextBox";
            this.iD_ОплатыTextBox.Size = new System.Drawing.Size(100, 20);
            this.iD_ОплатыTextBox.TabIndex = 2;
            // 
            // дата_оплатыLabel
            // 
            дата_оплатыLabel.AutoSize = true;
            дата_оплатыLabel.Location = new System.Drawing.Point(68, 94);
            дата_оплатыLabel.Name = "дата_оплатыLabel";
            дата_оплатыLabel.Size = new System.Drawing.Size(76, 13);
            дата_оплатыLabel.TabIndex = 3;
            дата_оплатыLabel.Text = "Дата оплаты:";
            // 
            // дата_оплатыDateTimePicker
            // 
            this.дата_оплатыDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.оплатаBindingSource, "Дата оплаты", true));
            this.дата_оплатыDateTimePicker.Location = new System.Drawing.Point(150, 90);
            this.дата_оплатыDateTimePicker.Name = "дата_оплатыDateTimePicker";
            this.дата_оплатыDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.дата_оплатыDateTimePicker.TabIndex = 4;
            // 
            // суммаLabel
            // 
            суммаLabel.AutoSize = true;
            суммаLabel.Location = new System.Drawing.Point(100, 119);
            суммаLabel.Name = "суммаLabel";
            суммаLabel.Size = new System.Drawing.Size(44, 13);
            суммаLabel.TabIndex = 5;
            суммаLabel.Text = "Сумма:";
            // 
            // суммаTextBox
            // 
            this.суммаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.оплатаBindingSource, "Сумма", true));
            this.суммаTextBox.Location = new System.Drawing.Point(150, 116);
            this.суммаTextBox.Name = "суммаTextBox";
            this.суммаTextBox.Size = new System.Drawing.Size(100, 20);
            this.суммаTextBox.TabIndex = 6;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(суммаLabel);
            this.Controls.Add(this.суммаTextBox);
            this.Controls.Add(дата_оплатыLabel);
            this.Controls.Add(this.дата_оплатыDateTimePicker);
            this.Controls.Add(iD_ОплатыLabel);
            this.Controls.Add(this.iD_ОплатыTextBox);
            this.Controls.Add(this.оплатаBindingNavigator);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.торговый_центрDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.оплатаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.оплатаBindingNavigator)).EndInit();
            this.оплатаBindingNavigator.ResumeLayout(false);
            this.оплатаBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Торговый_центрDataSet торговый_центрDataSet;
        private System.Windows.Forms.BindingSource оплатаBindingSource;
        private Торговый_центрDataSetTableAdapters.ОплатаTableAdapter оплатаTableAdapter;
        private Торговый_центрDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator оплатаBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton оплатаBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox iD_ОплатыTextBox;
        private System.Windows.Forms.DateTimePicker дата_оплатыDateTimePicker;
        private System.Windows.Forms.TextBox суммаTextBox;
    }
}
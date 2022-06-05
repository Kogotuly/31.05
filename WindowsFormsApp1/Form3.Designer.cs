namespace WindowsFormsApp1
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            System.Windows.Forms.Label iD_ОплатыLabel;
            System.Windows.Forms.Label номер_договораLabel;
            System.Windows.Forms.Label дата_заключенияLabel;
            System.Windows.Forms.Label дата_расторженияLabel;
            this.торговый_центрDataSet = new WindowsFormsApp1.Торговый_центрDataSet();
            this.договораBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.договораTableAdapter = new WindowsFormsApp1.Торговый_центрDataSetTableAdapters.ДоговораTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp1.Торговый_центрDataSetTableAdapters.TableAdapterManager();
            this.договораBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.договораBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.iD_ОплатыTextBox = new System.Windows.Forms.TextBox();
            this.номер_договораTextBox = new System.Windows.Forms.TextBox();
            this.дата_заключенияDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.дата_расторженияDateTimePicker = new System.Windows.Forms.DateTimePicker();
            iD_ОплатыLabel = new System.Windows.Forms.Label();
            номер_договораLabel = new System.Windows.Forms.Label();
            дата_заключенияLabel = new System.Windows.Forms.Label();
            дата_расторженияLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.торговый_центрDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.договораBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.договораBindingNavigator)).BeginInit();
            this.договораBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // торговый_центрDataSet
            // 
            this.торговый_центрDataSet.DataSetName = "Торговый_центрDataSet";
            this.торговый_центрDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // договораBindingSource
            // 
            this.договораBindingSource.DataMember = "Договора";
            this.договораBindingSource.DataSource = this.торговый_центрDataSet;
            // 
            // договораTableAdapter
            // 
            this.договораTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp1.Торговый_центрDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.АрендаTableAdapter = null;
            this.tableAdapterManager.Выборка__1TableAdapter = null;
            this.tableAdapterManager.Групповая_операция__1TableAdapter = null;
            this.tableAdapterManager.ДоговораTableAdapter = this.договораTableAdapter;
            this.tableAdapterManager.ОплатаTableAdapter = null;
            this.tableAdapterManager.УчасткиTableAdapter = null;
            // 
            // договораBindingNavigator
            // 
            this.договораBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.договораBindingNavigator.BindingSource = this.договораBindingSource;
            this.договораBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.договораBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.договораBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.договораBindingNavigatorSaveItem});
            this.договораBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.договораBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.договораBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.договораBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.договораBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.договораBindingNavigator.Name = "договораBindingNavigator";
            this.договораBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.договораBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.договораBindingNavigator.TabIndex = 0;
            this.договораBindingNavigator.Text = "bindingNavigator1";
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
            // договораBindingNavigatorSaveItem
            // 
            this.договораBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.договораBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("договораBindingNavigatorSaveItem.Image")));
            this.договораBindingNavigatorSaveItem.Name = "договораBindingNavigatorSaveItem";
            this.договораBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.договораBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.договораBindingNavigatorSaveItem.Click += new System.EventHandler(this.договораBindingNavigatorSaveItem_Click);
            // 
            // iD_ОплатыLabel
            // 
            iD_ОплатыLabel.AutoSize = true;
            iD_ОплатыLabel.Location = new System.Drawing.Point(122, 85);
            iD_ОплатыLabel.Name = "iD_ОплатыLabel";
            iD_ОплатыLabel.Size = new System.Drawing.Size(63, 13);
            iD_ОплатыLabel.TabIndex = 1;
            iD_ОплатыLabel.Text = "ID Оплаты:";
            // 
            // iD_ОплатыTextBox
            // 
            this.iD_ОплатыTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.договораBindingSource, "ID Оплаты", true));
            this.iD_ОплатыTextBox.Location = new System.Drawing.Point(191, 82);
            this.iD_ОплатыTextBox.Name = "iD_ОплатыTextBox";
            this.iD_ОплатыTextBox.Size = new System.Drawing.Size(100, 20);
            this.iD_ОплатыTextBox.TabIndex = 2;
            // 
            // номер_договораLabel
            // 
            номер_договораLabel.AutoSize = true;
            номер_договораLabel.Location = new System.Drawing.Point(91, 111);
            номер_договораLabel.Name = "номер_договораLabel";
            номер_договораLabel.Size = new System.Drawing.Size(94, 13);
            номер_договораLabel.TabIndex = 3;
            номер_договораLabel.Text = "Номер договора:";
            // 
            // номер_договораTextBox
            // 
            this.номер_договораTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.договораBindingSource, "Номер договора", true));
            this.номер_договораTextBox.Location = new System.Drawing.Point(191, 108);
            this.номер_договораTextBox.Name = "номер_договораTextBox";
            this.номер_договораTextBox.Size = new System.Drawing.Size(100, 20);
            this.номер_договораTextBox.TabIndex = 4;
            // 
            // дата_заключенияLabel
            // 
            дата_заключенияLabel.AutoSize = true;
            дата_заключенияLabel.Location = new System.Drawing.Point(85, 149);
            дата_заключенияLabel.Name = "дата_заключенияLabel";
            дата_заключенияLabel.Size = new System.Drawing.Size(100, 13);
            дата_заключенияLabel.TabIndex = 5;
            дата_заключенияLabel.Text = "Дата заключения:";
            // 
            // дата_заключенияDateTimePicker
            // 
            this.дата_заключенияDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.договораBindingSource, "Дата заключения", true));
            this.дата_заключенияDateTimePicker.Location = new System.Drawing.Point(191, 145);
            this.дата_заключенияDateTimePicker.Name = "дата_заключенияDateTimePicker";
            this.дата_заключенияDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.дата_заключенияDateTimePicker.TabIndex = 6;
            // 
            // дата_расторженияLabel
            // 
            дата_расторженияLabel.AutoSize = true;
            дата_расторженияLabel.Location = new System.Drawing.Point(79, 175);
            дата_расторженияLabel.Name = "дата_расторженияLabel";
            дата_расторженияLabel.Size = new System.Drawing.Size(106, 13);
            дата_расторженияLabel.TabIndex = 7;
            дата_расторженияLabel.Text = "Дата расторжения:";
            // 
            // дата_расторженияDateTimePicker
            // 
            this.дата_расторженияDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.договораBindingSource, "Дата расторжения", true));
            this.дата_расторженияDateTimePicker.Location = new System.Drawing.Point(191, 171);
            this.дата_расторженияDateTimePicker.Name = "дата_расторженияDateTimePicker";
            this.дата_расторженияDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.дата_расторженияDateTimePicker.TabIndex = 8;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(дата_расторженияLabel);
            this.Controls.Add(this.дата_расторженияDateTimePicker);
            this.Controls.Add(дата_заключенияLabel);
            this.Controls.Add(this.дата_заключенияDateTimePicker);
            this.Controls.Add(номер_договораLabel);
            this.Controls.Add(this.номер_договораTextBox);
            this.Controls.Add(iD_ОплатыLabel);
            this.Controls.Add(this.iD_ОплатыTextBox);
            this.Controls.Add(this.договораBindingNavigator);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.торговый_центрDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.договораBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.договораBindingNavigator)).EndInit();
            this.договораBindingNavigator.ResumeLayout(false);
            this.договораBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Торговый_центрDataSet торговый_центрDataSet;
        private System.Windows.Forms.BindingSource договораBindingSource;
        private Торговый_центрDataSetTableAdapters.ДоговораTableAdapter договораTableAdapter;
        private Торговый_центрDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator договораBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton договораBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox iD_ОплатыTextBox;
        private System.Windows.Forms.TextBox номер_договораTextBox;
        private System.Windows.Forms.DateTimePicker дата_заключенияDateTimePicker;
        private System.Windows.Forms.DateTimePicker дата_расторженияDateTimePicker;
    }
}
namespace WindowsFormsApp1
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            System.Windows.Forms.Label iD_арендатораLabel;
            System.Windows.Forms.Label номер_договораLabel;
            System.Windows.Forms.Label цель_арендыLabel;
            System.Windows.Forms.Label телефонLabel;
            System.Windows.Forms.Label фИОLabel;
            this.торговый_центрDataSet = new WindowsFormsApp1.Торговый_центрDataSet();
            this.арендаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.арендаTableAdapter = new WindowsFormsApp1.Торговый_центрDataSetTableAdapters.АрендаTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp1.Торговый_центрDataSetTableAdapters.TableAdapterManager();
            this.арендаBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.арендаBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.iD_арендатораTextBox = new System.Windows.Forms.TextBox();
            this.номер_договораTextBox = new System.Windows.Forms.TextBox();
            this.цель_арендыTextBox = new System.Windows.Forms.TextBox();
            this.телефонTextBox = new System.Windows.Forms.TextBox();
            this.фИОTextBox = new System.Windows.Forms.TextBox();
            iD_арендатораLabel = new System.Windows.Forms.Label();
            номер_договораLabel = new System.Windows.Forms.Label();
            цель_арендыLabel = new System.Windows.Forms.Label();
            телефонLabel = new System.Windows.Forms.Label();
            фИОLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.торговый_центрDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.арендаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.арендаBindingNavigator)).BeginInit();
            this.арендаBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // торговый_центрDataSet
            // 
            this.торговый_центрDataSet.DataSetName = "Торговый_центрDataSet";
            this.торговый_центрDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // арендаBindingSource
            // 
            this.арендаBindingSource.DataMember = "Аренда";
            this.арендаBindingSource.DataSource = this.торговый_центрDataSet;
            // 
            // арендаTableAdapter
            // 
            this.арендаTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp1.Торговый_центрDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.АрендаTableAdapter = this.арендаTableAdapter;
            this.tableAdapterManager.Выборка__1TableAdapter = null;
            this.tableAdapterManager.Групповая_операция__1TableAdapter = null;
            this.tableAdapterManager.ДоговораTableAdapter = null;
            this.tableAdapterManager.ОплатаTableAdapter = null;
            this.tableAdapterManager.УчасткиTableAdapter = null;
            // 
            // арендаBindingNavigator
            // 
            this.арендаBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.арендаBindingNavigator.BindingSource = this.арендаBindingSource;
            this.арендаBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.арендаBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.арендаBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.арендаBindingNavigatorSaveItem});
            this.арендаBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.арендаBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.арендаBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.арендаBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.арендаBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.арендаBindingNavigator.Name = "арендаBindingNavigator";
            this.арендаBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.арендаBindingNavigator.Size = new System.Drawing.Size(766, 25);
            this.арендаBindingNavigator.TabIndex = 0;
            this.арендаBindingNavigator.Text = "bindingNavigator1";
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
            // арендаBindingNavigatorSaveItem
            // 
            this.арендаBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.арендаBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("арендаBindingNavigatorSaveItem.Image")));
            this.арендаBindingNavigatorSaveItem.Name = "арендаBindingNavigatorSaveItem";
            this.арендаBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.арендаBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.арендаBindingNavigatorSaveItem.Click += new System.EventHandler(this.арендаBindingNavigatorSaveItem_Click);
            // 
            // iD_арендатораLabel
            // 
            iD_арендатораLabel.AutoSize = true;
            iD_арендатораLabel.Location = new System.Drawing.Point(75, 149);
            iD_арендатораLabel.Name = "iD_арендатораLabel";
            iD_арендатораLabel.Size = new System.Drawing.Size(83, 13);
            iD_арендатораLabel.TabIndex = 1;
            iD_арендатораLabel.Text = "ID арендатора:";
            // 
            // iD_арендатораTextBox
            // 
            this.iD_арендатораTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.арендаBindingSource, "ID арендатора", true));
            this.iD_арендатораTextBox.Location = new System.Drawing.Point(164, 149);
            this.iD_арендатораTextBox.Name = "iD_арендатораTextBox";
            this.iD_арендатораTextBox.Size = new System.Drawing.Size(122, 20);
            this.iD_арендатораTextBox.TabIndex = 2;
            // 
            // номер_договораLabel
            // 
            номер_договораLabel.AutoSize = true;
            номер_договораLabel.Location = new System.Drawing.Point(64, 177);
            номер_договораLabel.Name = "номер_договораLabel";
            номер_договораLabel.Size = new System.Drawing.Size(94, 13);
            номер_договораLabel.TabIndex = 3;
            номер_договораLabel.Text = "Номер договора:";
            // 
            // номер_договораTextBox
            // 
            this.номер_договораTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.арендаBindingSource, "Номер договора", true));
            this.номер_договораTextBox.Location = new System.Drawing.Point(164, 177);
            this.номер_договораTextBox.Name = "номер_договораTextBox";
            this.номер_договораTextBox.Size = new System.Drawing.Size(123, 20);
            this.номер_договораTextBox.TabIndex = 4;
            // 
            // цель_арендыLabel
            // 
            цель_арендыLabel.AutoSize = true;
            цель_арендыLabel.Location = new System.Drawing.Point(81, 206);
            цель_арендыLabel.Name = "цель_арендыLabel";
            цель_арендыLabel.Size = new System.Drawing.Size(77, 13);
            цель_арендыLabel.TabIndex = 5;
            цель_арендыLabel.Text = "Цель аренды:";
            цель_арендыLabel.Click += new System.EventHandler(this.цель_арендыLabel_Click);
            // 
            // цель_арендыTextBox
            // 
            this.цель_арендыTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.арендаBindingSource, "Цель аренды", true));
            this.цель_арендыTextBox.Location = new System.Drawing.Point(164, 203);
            this.цель_арендыTextBox.Name = "цель_арендыTextBox";
            this.цель_арендыTextBox.Size = new System.Drawing.Size(123, 20);
            this.цель_арендыTextBox.TabIndex = 6;
            this.цель_арендыTextBox.TextChanged += new System.EventHandler(this.цель_арендыTextBox_TextChanged);
            // 
            // телефонLabel
            // 
            телефонLabel.AutoSize = true;
            телефонLabel.Location = new System.Drawing.Point(103, 232);
            телефонLabel.Name = "телефонLabel";
            телефонLabel.Size = new System.Drawing.Size(55, 13);
            телефонLabel.TabIndex = 7;
            телефонLabel.Text = "Телефон:";
            // 
            // телефонTextBox
            // 
            this.телефонTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.арендаBindingSource, "Телефон", true));
            this.телефонTextBox.Location = new System.Drawing.Point(164, 229);
            this.телефонTextBox.Name = "телефонTextBox";
            this.телефонTextBox.Size = new System.Drawing.Size(123, 20);
            this.телефонTextBox.TabIndex = 8;
            // 
            // фИОLabel
            // 
            фИОLabel.AutoSize = true;
            фИОLabel.Location = new System.Drawing.Point(120, 258);
            фИОLabel.Name = "фИОLabel";
            фИОLabel.Size = new System.Drawing.Size(37, 13);
            фИОLabel.TabIndex = 9;
            фИОLabel.Text = "ФИО:";
            фИОLabel.Click += new System.EventHandler(this.фИОLabel_Click);
            // 
            // фИОTextBox
            // 
            this.фИОTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.арендаBindingSource, "ФИО", true));
            this.фИОTextBox.Location = new System.Drawing.Point(163, 255);
            this.фИОTextBox.Name = "фИОTextBox";
            this.фИОTextBox.Size = new System.Drawing.Size(123, 20);
            this.фИОTextBox.TabIndex = 10;
            this.фИОTextBox.TextChanged += new System.EventHandler(this.фИОTextBox_TextChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 425);
            this.Controls.Add(фИОLabel);
            this.Controls.Add(this.фИОTextBox);
            this.Controls.Add(телефонLabel);
            this.Controls.Add(this.телефонTextBox);
            this.Controls.Add(цель_арендыLabel);
            this.Controls.Add(this.цель_арендыTextBox);
            this.Controls.Add(номер_договораLabel);
            this.Controls.Add(this.номер_договораTextBox);
            this.Controls.Add(iD_арендатораLabel);
            this.Controls.Add(this.iD_арендатораTextBox);
            this.Controls.Add(this.арендаBindingNavigator);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.торговый_центрDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.арендаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.арендаBindingNavigator)).EndInit();
            this.арендаBindingNavigator.ResumeLayout(false);
            this.арендаBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Торговый_центрDataSet торговый_центрDataSet;
        private System.Windows.Forms.BindingSource арендаBindingSource;
        private Торговый_центрDataSetTableAdapters.АрендаTableAdapter арендаTableAdapter;
        private Торговый_центрDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator арендаBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton арендаBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox iD_арендатораTextBox;
        private System.Windows.Forms.TextBox номер_договораTextBox;
        private System.Windows.Forms.TextBox цель_арендыTextBox;
        private System.Windows.Forms.TextBox телефонTextBox;
        private System.Windows.Forms.TextBox фИОTextBox;
    }
}
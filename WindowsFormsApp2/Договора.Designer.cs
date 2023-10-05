namespace WindowsFormsApp2
{
    partial class Договора
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.назадToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nMBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fULLNAMEPODRDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nAMEOFSTREETDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nUMOFHOUSEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nUMOFROOMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rEQIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rESULTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zachetDataSet1 = new WindowsFormsApp2.zachetDataSet1();
            this.rESULTTableAdapter = new WindowsFormsApp2.zachetDataSet1TableAdapters.RESULTTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rESULTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zachetDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.назадToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // назадToolStripMenuItem
            // 
            this.назадToolStripMenuItem.Name = "назадToolStripMenuItem";
            this.назадToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.назадToolStripMenuItem.Text = "Назад";
            this.назадToolStripMenuItem.Click += new System.EventHandler(this.назадToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(339, 70);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(353, 106);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Найти";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(275, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Введите номер договора";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nMBDataGridViewTextBoxColumn,
            this.nAMEDataGridViewTextBoxColumn,
            this.fULLNAMEPODRDataGridViewTextBoxColumn,
            this.nAMEOFSTREETDataGridViewTextBoxColumn,
            this.nUMOFHOUSEDataGridViewTextBoxColumn,
            this.nUMOFROOMDataGridViewTextBoxColumn,
            this.rEQIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.rESULTBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(30, 182);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(747, 150);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // nMBDataGridViewTextBoxColumn
            // 
            this.nMBDataGridViewTextBoxColumn.DataPropertyName = "NMB";
            this.nMBDataGridViewTextBoxColumn.HeaderText = "NMB";
            this.nMBDataGridViewTextBoxColumn.Name = "nMBDataGridViewTextBoxColumn";
            // 
            // nAMEDataGridViewTextBoxColumn
            // 
            this.nAMEDataGridViewTextBoxColumn.DataPropertyName = "NAME";
            this.nAMEDataGridViewTextBoxColumn.HeaderText = "NAME";
            this.nAMEDataGridViewTextBoxColumn.Name = "nAMEDataGridViewTextBoxColumn";
            // 
            // fULLNAMEPODRDataGridViewTextBoxColumn
            // 
            this.fULLNAMEPODRDataGridViewTextBoxColumn.DataPropertyName = "FULL_NAME_PODR";
            this.fULLNAMEPODRDataGridViewTextBoxColumn.HeaderText = "FULL_NAME_PODR";
            this.fULLNAMEPODRDataGridViewTextBoxColumn.Name = "fULLNAMEPODRDataGridViewTextBoxColumn";
            // 
            // nAMEOFSTREETDataGridViewTextBoxColumn
            // 
            this.nAMEOFSTREETDataGridViewTextBoxColumn.DataPropertyName = "NAME_OF_STREET";
            this.nAMEOFSTREETDataGridViewTextBoxColumn.HeaderText = "NAME_OF_STREET";
            this.nAMEOFSTREETDataGridViewTextBoxColumn.Name = "nAMEOFSTREETDataGridViewTextBoxColumn";
            // 
            // nUMOFHOUSEDataGridViewTextBoxColumn
            // 
            this.nUMOFHOUSEDataGridViewTextBoxColumn.DataPropertyName = "NUM_OF_HOUSE";
            this.nUMOFHOUSEDataGridViewTextBoxColumn.HeaderText = "NUM_OF_HOUSE";
            this.nUMOFHOUSEDataGridViewTextBoxColumn.Name = "nUMOFHOUSEDataGridViewTextBoxColumn";
            // 
            // nUMOFROOMDataGridViewTextBoxColumn
            // 
            this.nUMOFROOMDataGridViewTextBoxColumn.DataPropertyName = "NUM_OF_ROOM";
            this.nUMOFROOMDataGridViewTextBoxColumn.HeaderText = "NUM_OF_ROOM";
            this.nUMOFROOMDataGridViewTextBoxColumn.Name = "nUMOFROOMDataGridViewTextBoxColumn";
            // 
            // rEQIDDataGridViewTextBoxColumn
            // 
            this.rEQIDDataGridViewTextBoxColumn.DataPropertyName = "REQ_ID";
            this.rEQIDDataGridViewTextBoxColumn.HeaderText = "REQ_ID";
            this.rEQIDDataGridViewTextBoxColumn.Name = "rEQIDDataGridViewTextBoxColumn";
            // 
            // rESULTBindingSource
            // 
            this.rESULTBindingSource.DataMember = "RESULT";
            this.rESULTBindingSource.DataSource = this.zachetDataSet1;
            // 
            // zachetDataSet1
            // 
            this.zachetDataSet1.DataSetName = "zachetDataSet1";
            this.zachetDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rESULTTableAdapter
            // 
            this.rESULTTableAdapter.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(441, 353);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Сохранить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(279, 353);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "Удалить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Договора
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 661);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Договора";
            this.Text = "Договора";
            this.Load += new System.EventHandler(this.Договора_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rESULTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zachetDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem назадToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private zachetDataSet1 zachetDataSet1;
        private System.Windows.Forms.BindingSource rESULTBindingSource;
        private zachetDataSet1TableAdapters.RESULTTableAdapter rESULTTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nMBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fULLNAMEPODRDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nAMEOFSTREETDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nUMOFHOUSEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nUMOFROOMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rEQIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}
namespace WindowsFormsApp2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.тарифToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.договораАбонентовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.филлиалыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справочникДомовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.разовыеУслугиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.платежиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сальдоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справочникУлицToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.улицыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.видыУслугToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.кодыЕдиницИзмеренияУслугToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.тарифToolStripMenuItem,
            this.договораАбонентовToolStripMenuItem,
            this.филлиалыToolStripMenuItem,
            this.справочникДомовToolStripMenuItem,
            this.разовыеУслугиToolStripMenuItem,
            this.платежиToolStripMenuItem,
            this.сальдоToolStripMenuItem,
            this.справочникУлицToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // тарифToolStripMenuItem
            // 
            this.тарифToolStripMenuItem.Name = "тарифToolStripMenuItem";
            this.тарифToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.тарифToolStripMenuItem.Text = "Тарифы";
            this.тарифToolStripMenuItem.Click += new System.EventHandler(this.тарифToolStripMenuItem_Click);
            // 
            // договораАбонентовToolStripMenuItem
            // 
            this.договораАбонентовToolStripMenuItem.Name = "договораАбонентовToolStripMenuItem";
            this.договораАбонентовToolStripMenuItem.Size = new System.Drawing.Size(133, 20);
            this.договораАбонентовToolStripMenuItem.Text = "Договора абонентов";
            this.договораАбонентовToolStripMenuItem.Click += new System.EventHandler(this.договораАбонентовToolStripMenuItem_Click);
            // 
            // филлиалыToolStripMenuItem
            // 
            this.филлиалыToolStripMenuItem.Name = "филлиалыToolStripMenuItem";
            this.филлиалыToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.филлиалыToolStripMenuItem.Text = "Филлиалы";
            this.филлиалыToolStripMenuItem.Click += new System.EventHandler(this.филлиалыToolStripMenuItem_Click);
            // 
            // справочникДомовToolStripMenuItem
            // 
            this.справочникДомовToolStripMenuItem.Name = "справочникДомовToolStripMenuItem";
            this.справочникДомовToolStripMenuItem.Size = new System.Drawing.Size(125, 20);
            this.справочникДомовToolStripMenuItem.Text = "Справочник домов";
            this.справочникДомовToolStripMenuItem.Click += new System.EventHandler(this.справочникДомовToolStripMenuItem_Click);
            // 
            // разовыеУслугиToolStripMenuItem
            // 
            this.разовыеУслугиToolStripMenuItem.Name = "разовыеУслугиToolStripMenuItem";
            this.разовыеУслугиToolStripMenuItem.Size = new System.Drawing.Size(105, 20);
            this.разовыеУслугиToolStripMenuItem.Text = "Разовые услуги";
            this.разовыеУслугиToolStripMenuItem.Click += new System.EventHandler(this.разовыеУслугиToolStripMenuItem_Click);
            // 
            // платежиToolStripMenuItem
            // 
            this.платежиToolStripMenuItem.Name = "платежиToolStripMenuItem";
            this.платежиToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.платежиToolStripMenuItem.Text = "Платежи";
            this.платежиToolStripMenuItem.Click += new System.EventHandler(this.платежиToolStripMenuItem_Click);
            // 
            // сальдоToolStripMenuItem
            // 
            this.сальдоToolStripMenuItem.Name = "сальдоToolStripMenuItem";
            this.сальдоToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.сальдоToolStripMenuItem.Text = "Сальдо";
            this.сальдоToolStripMenuItem.Click += new System.EventHandler(this.сальдоToolStripMenuItem_Click);
            // 
            // справочникУлицToolStripMenuItem
            // 
            this.справочникУлицToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.улицыToolStripMenuItem,
            this.видыУслугToolStripMenuItem,
            this.кодыЕдиницИзмеренияУслугToolStripMenuItem});
            this.справочникУлицToolStripMenuItem.Name = "справочникУлицToolStripMenuItem";
            this.справочникУлицToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.справочникУлицToolStripMenuItem.Text = "Справочники";
            // 
            // улицыToolStripMenuItem
            // 
            this.улицыToolStripMenuItem.Name = "улицыToolStripMenuItem";
            this.улицыToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
            this.улицыToolStripMenuItem.Text = "Улицы";
            this.улицыToolStripMenuItem.Click += new System.EventHandler(this.улицыToolStripMenuItem_Click);
            // 
            // видыУслугToolStripMenuItem
            // 
            this.видыУслугToolStripMenuItem.Name = "видыУслугToolStripMenuItem";
            this.видыУслугToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
            this.видыУслугToolStripMenuItem.Text = "Виды услуг";
            this.видыУслугToolStripMenuItem.Click += new System.EventHandler(this.видыУслугToolStripMenuItem_Click);
            // 
            // кодыЕдиницИзмеренияУслугToolStripMenuItem
            // 
            this.кодыЕдиницИзмеренияУслугToolStripMenuItem.Name = "кодыЕдиницИзмеренияУслугToolStripMenuItem";
            this.кодыЕдиницИзмеренияУслугToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
            this.кодыЕдиницИзмеренияУслугToolStripMenuItem.Text = "Коды единиц измерения услуг";
            this.кодыЕдиницИзмеренияУслугToolStripMenuItem.Click += new System.EventHandler(this.кодыЕдиницИзмеренияУслугToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(242, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Выберите одну из опций АСР сверху";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp2.Properties.Resources.billingmob;
            this.pictureBox1.Location = new System.Drawing.Point(87, 84);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(617, 337);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Биллинг";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem тарифToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem договораАбонентовToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem филлиалыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справочникДомовToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem разовыеУслугиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem платежиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сальдоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справочникУлицToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem улицыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem видыУслугToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem кодыЕдиницИзмеренияУслугToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}


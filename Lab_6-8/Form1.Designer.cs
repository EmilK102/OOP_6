namespace Lab_6_8
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnBrush = new System.Windows.Forms.Button();
            this.listColor = new System.Windows.Forms.ListBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnCreateGroup = new System.Windows.Forms.Button();
            this.listGroup = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Location = new System.Drawing.Point(16, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(741, 584);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CreateObj);
            // 
            // btnBrush
            // 
            this.btnBrush.Enabled = false;
            this.btnBrush.Location = new System.Drawing.Point(764, 491);
            this.btnBrush.Margin = new System.Windows.Forms.Padding(4);
            this.btnBrush.Name = "btnBrush";
            this.btnBrush.Size = new System.Drawing.Size(211, 49);
            this.btnBrush.TabIndex = 1;
            this.btnBrush.TabStop = false;
            this.btnBrush.Text = "Покрасить";
            this.btnBrush.UseVisualStyleBackColor = true;
            this.btnBrush.Click += new System.EventHandler(this.btnChangeColor);
            this.btnBrush.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dontTouchKeyboard);
            // 
            // listColor
            // 
            this.listColor.FormattingEnabled = true;
            this.listColor.ItemHeight = 16;
            this.listColor.Items.AddRange(new object[] {
            "Blue",
            "Brown",
            "Yellow",
            "Green",
            "Purple",
            "Red",
            "White"});
            this.listColor.Location = new System.Drawing.Point(765, 351);
            this.listColor.Margin = new System.Windows.Forms.Padding(4);
            this.listColor.Name = "listColor";
            this.listColor.Size = new System.Drawing.Size(67, 132);
            this.listColor.TabIndex = 2;
            this.listColor.SelectedIndexChanged += new System.EventHandler(this.listColor_SelectedIndexChanged);
            this.listColor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dontTouchKeyboard);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Items.AddRange(new object[] {
            "Circle",
            "Square",
            "Triangle"});
            this.listBox1.Location = new System.Drawing.Point(840, 351);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(135, 132);
            this.listBox1.TabIndex = 3;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            this.listBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dontTouchKeyboard);
            // 
            // btnCreateGroup
            // 
            this.btnCreateGroup.Location = new System.Drawing.Point(871, 211);
            this.btnCreateGroup.Margin = new System.Windows.Forms.Padding(4);
            this.btnCreateGroup.Name = "btnCreateGroup";
            this.btnCreateGroup.Size = new System.Drawing.Size(104, 49);
            this.btnCreateGroup.TabIndex = 4;
            this.btnCreateGroup.Text = "Создать группу";
            this.btnCreateGroup.UseVisualStyleBackColor = true;
            this.btnCreateGroup.Click += new System.EventHandler(this.btnCreateGroup_Click);
            this.btnCreateGroup.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dontTouchKeyboard);
            // 
            // listGroup
            // 
            this.listGroup.FormattingEnabled = true;
            this.listGroup.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.listGroup.ItemHeight = 16;
            this.listGroup.Items.AddRange(new object[] {
            "No one"});
            this.listGroup.Location = new System.Drawing.Point(765, 211);
            this.listGroup.Margin = new System.Windows.Forms.Padding(4);
            this.listGroup.Name = "listGroup";
            this.listGroup.Size = new System.Drawing.Size(103, 132);
            this.listGroup.TabIndex = 5;
            this.listGroup.TabStop = false;
            this.listGroup.UseTabStops = false;
            this.listGroup.SelectedIndexChanged += new System.EventHandler(this.button_ApplyGroup_Click);
            this.listGroup.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dontTouchKeyboard);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(871, 309);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 34);
            this.button1.TabIndex = 7;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.save_button);
            this.button1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dontTouchKeyboard);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(871, 266);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 39);
            this.button2.TabIndex = 8;
            this.button2.Text = "Загрузить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.load_button);
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(765, 15);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(210, 189);
            this.treeView1.TabIndex = 11;
            this.treeView1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.treeView1_MouseDown);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(765, 559);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(79, 21);
            this.checkBox1.TabIndex = 12;
            this.checkBox1.Text = "Липкий";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.btn_nSlime_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 607);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listGroup);
            this.Controls.Add(this.btnCreateGroup);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.listColor);
            this.Controls.Add(this.btnBrush);
            this.Controls.Add(this.pictureBox1);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnBrush;
        private System.Windows.Forms.ListBox listColor;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnCreateGroup;
        private System.Windows.Forms.ListBox listGroup;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}


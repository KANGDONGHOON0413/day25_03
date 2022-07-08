
namespace day25_03
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.pageManage = new System.Windows.Forms.TabPage();
            this.select_box01 = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TXT_PRICE = new System.Windows.Forms.TextBox();
            this.TXT_STOCK = new System.Windows.Forms.TextBox();
            this.TXT_NAME = new System.Windows.Forms.TextBox();
            this.TXT_KEY = new System.Windows.Forms.TextBox();
            this.btn_Enter = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.ItemID = new System.Windows.Forms.ColumnHeader();
            this.ItemName = new System.Windows.Forms.ColumnHeader();
            this.stock = new System.Windows.Forms.ColumnHeader();
            this.Price = new System.Windows.Forms.ColumnHeader();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.pageManage.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.pageManage);
            this.tabControl1.Location = new System.Drawing.Point(12, 30);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 408);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 375);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(137, 60);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 375);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(32, 197);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 29);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.button3);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(768, 375);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(223, 189);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 29);
            this.button3.TabIndex = 1;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pageManage
            // 
            this.pageManage.Controls.Add(this.select_box01);
            this.pageManage.Controls.Add(this.label4);
            this.pageManage.Controls.Add(this.label3);
            this.pageManage.Controls.Add(this.label2);
            this.pageManage.Controls.Add(this.label1);
            this.pageManage.Controls.Add(this.TXT_PRICE);
            this.pageManage.Controls.Add(this.TXT_STOCK);
            this.pageManage.Controls.Add(this.TXT_NAME);
            this.pageManage.Controls.Add(this.TXT_KEY);
            this.pageManage.Controls.Add(this.btn_Enter);
            this.pageManage.Controls.Add(this.listView1);
            this.pageManage.Location = new System.Drawing.Point(4, 29);
            this.pageManage.Name = "pageManage";
            this.pageManage.Padding = new System.Windows.Forms.Padding(3);
            this.pageManage.Size = new System.Drawing.Size(768, 375);
            this.pageManage.TabIndex = 3;
            this.pageManage.Text = "pageM";
            this.pageManage.UseVisualStyleBackColor = true;
            // 
            // select_box01
            // 
            this.select_box01.FormattingEnabled = true;
            this.select_box01.ItemHeight = 20;
            this.select_box01.Items.AddRange(new object[] {
            "추가",
            "수정",
            "삭제",
            "삽입"});
            this.select_box01.Location = new System.Drawing.Point(6, 285);
            this.select_box01.Name = "select_box01";
            this.select_box01.Size = new System.Drawing.Size(83, 84);
            this.select_box01.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(488, 288);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(357, 288);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "stock";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(226, 288);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 288);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Serial number";
            // 
            // TXT_PRICE
            // 
            this.TXT_PRICE.Location = new System.Drawing.Point(488, 319);
            this.TXT_PRICE.Name = "TXT_PRICE";
            this.TXT_PRICE.Size = new System.Drawing.Size(125, 27);
            this.TXT_PRICE.TabIndex = 5;
            // 
            // TXT_STOCK
            // 
            this.TXT_STOCK.Location = new System.Drawing.Point(357, 319);
            this.TXT_STOCK.Name = "TXT_STOCK";
            this.TXT_STOCK.Size = new System.Drawing.Size(125, 27);
            this.TXT_STOCK.TabIndex = 4;
            // 
            // TXT_NAME
            // 
            this.TXT_NAME.Location = new System.Drawing.Point(226, 319);
            this.TXT_NAME.Name = "TXT_NAME";
            this.TXT_NAME.Size = new System.Drawing.Size(125, 27);
            this.TXT_NAME.TabIndex = 3;
            // 
            // TXT_KEY
            // 
            this.TXT_KEY.Location = new System.Drawing.Point(95, 319);
            this.TXT_KEY.Name = "TXT_KEY";
            this.TXT_KEY.Size = new System.Drawing.Size(125, 27);
            this.TXT_KEY.TabIndex = 2;
            // 
            // btn_Enter
            // 
            this.btn_Enter.Location = new System.Drawing.Point(619, 319);
            this.btn_Enter.Name = "btn_Enter";
            this.btn_Enter.Size = new System.Drawing.Size(94, 29);
            this.btn_Enter.TabIndex = 1;
            this.btn_Enter.Text = "확인";
            this.btn_Enter.UseVisualStyleBackColor = true;
            this.btn_Enter.Click += new System.EventHandler(this.btn_Enter_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ItemID,
            this.ItemName,
            this.stock,
            this.Price});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(19, 40);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(435, 218);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
           // this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            // 
            // ItemID
            // 
            this.ItemID.Text = "Serial number";
            this.ItemID.Width = 150;
            // 
            // ItemName
            // 
            this.ItemName.Text = "Name";
            this.ItemName.Width = 100;
            // 
            // stock
            // 
            this.stock.Text = "stock";
            this.stock.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Price
            // 
            this.Price.Text = "Price";
            this.Price.Width = 100;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(663, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(125, 27);
            this.textBox1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.pageManage.ResumeLayout(false);
            this.pageManage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TabPage pageManage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TXT_PRICE;
        private System.Windows.Forms.TextBox TXT_STOCK;
        private System.Windows.Forms.TextBox TXT_NAME;
        private System.Windows.Forms.TextBox TXT_KEY;
        private System.Windows.Forms.Button btn_Enter;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader ItemID;
        private System.Windows.Forms.ColumnHeader ItemName;
        private System.Windows.Forms.ColumnHeader stock;
        private System.Windows.Forms.ColumnHeader Price;
        private System.Windows.Forms.ListBox select_box01;
    }
}


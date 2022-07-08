using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace day25_03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "btn1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "btn2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "btn3";
        }

        /*
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            TXT_KEY.Text = listView1.SelectedItems[0].SubItems[0].Text;
            TXT_NAME.Text = listView1.SelectedItems[0].SubItems[1].Text;
            TXT_STOCK.Text = listView1.SelectedItems[0].SubItems[2].Text;
            TXT_PRICE.Text = listView1.SelectedItems[0].SubItems[3].Text;
        }
        */
        private void btn_Enter_Click(object sender, EventArgs e)
        {         
            try
            {
                if (string.IsNullOrEmpty(TXT_KEY.Text) || string.IsNullOrEmpty(TXT_NAME.Text) ||
                    string.IsNullOrEmpty(TXT_PRICE.Text) || string.IsNullOrEmpty(TXT_STOCK.Text))
                    throw new Exception("칸이 비어있습니다");

                switch (select_box01.SelectedIndex)
                {
                    case -1: throw new Exception("먼저 기능을 선택해 주세요.");
                    case 0: AddItem(); break;
                    case 1: UpdateItem(); break;
                    case 2: DeleteItem(); break;
                    case 3: InjectItem(); break;
                    default: throw new Exception("메뉴 이상 발생");
                }
            }
            catch(Exception exct)
            {
                MessageBox.Show(exct.Message);
            }
            finally
            {
                ResetA();
            }
        }

        public void AddItem()
        {
            listView1.Items.Add(new ListViewItem(new string[] { TXT_KEY.Text, TXT_NAME.Text, TXT_STOCK.Text, TXT_PRICE.Text }));
        }
        public void UpdateItem()
        {
            listView1.SelectedItems[0].SubItems[0].Text = TXT_KEY.Text;
            listView1.SelectedItems[0].SubItems[1].Text = TXT_NAME.Text;
            listView1.SelectedItems[0].SubItems[2].Text = TXT_STOCK.Text;
            listView1.SelectedItems[0].SubItems[3].Text = TXT_PRICE.Text;
        }
        public void DeleteItem()
        {
            //listView1.Items.RemoveAt(0);
            listView1.SelectedItems[0].Remove();
        }
        public void InjectItem()
        {
            int index = listView1.SelectedIndices[0];
            listView1.Items.Insert(index, new ListViewItem(new string[] { TXT_KEY.Text, TXT_NAME.Text, TXT_STOCK.Text, TXT_PRICE.Text }));
        }
        public void ResetA()
        {
            TXT_KEY.Clear();
            TXT_NAME.Clear();
            TXT_PRICE.Clear();
            TXT_STOCK.Clear();
            select_box01.SelectedIndex = -1;
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            TXT_KEY.Text = listView1.SelectedItems[0].SubItems[0].Text;
            TXT_NAME.Text = listView1.SelectedItems[0].SubItems[1].Text;
            TXT_STOCK.Text = listView1.SelectedItems[0].SubItems[2].Text;
            TXT_PRICE.Text = listView1.SelectedItems[0].SubItems[3].Text;
        }
    }
}

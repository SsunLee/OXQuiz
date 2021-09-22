using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // 변수
        private float _rate = 0;
        private int _count = 0;
        private List<char> _list = new List<char>();
        private char o = 'O';
        private char x = 'X';

        // 배열 생성
        private void button1_Click(object sender, EventArgs e)
        {
            _list = new List<char>();
            _count = int.Parse(textBox1.Text.ToString());
            _rate = float.Parse(textBox2.Text.ToString()) / 100;

            for (int i = 1; i <= _count; i++)
            { 
                if (i <=  _rate * _count)
                {
                    _list.Add(o);
                    Debug.Print(o.ToString());
                }
                else
                {
                    _list.Add(x);
                }
            }

          // 배열 값 shuffle
           var outLists =  _list.OrderBy(x => Guid.NewGuid()).ToList();


            // print 
            listBox1.Items.Clear();
            foreach (char x in outLists)
            {
                listBox1.Items.Add(x);
            }

            string cntO = outLists.Count(x => x.ToString() == "O").ToString();
            string cntX = outLists.Count(x => x.ToString() == "X").ToString();
            string cnt = outLists.Count().ToString();

            label1.Text = cnt;
            label2.Text = cntO;
            label3.Text = cntX;
        }


    }
}

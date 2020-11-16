using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace test
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        public static string save_text = "";

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string phone = textBox2.Text;
            string Email = textBox3.Text;

	// 在gix修复分支中解决严重的问题，修改了id
	String id = textBox1.Text;

            save_text = save_text + name + "\r\n" + phone + "\r\n" + Email + "\r\n\r\n";
            textBox4.Text = save_text;
        }
    }
}

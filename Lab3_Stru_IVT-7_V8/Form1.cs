using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3_Stru_IVT_7_V8
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            if (textBox_path.Text != null && textBox_path.Text != "")
            {
                bool isValid = Path.IsPathRooted(textBox_path.Text);

                if (isValid)
                {
                    listBox_left.Items.Add(textBox_path.Text);
                } // if
                else
                {
                    listBox_right.Items.Add(textBox_path.Text);
                }
                textBox_path.Text = "";

            } // if
            else
            {
                MessageBox.Show("Пустая строка!", "Что-то пошло не так!");
            }
        }

        private void button_Delete_left_Click(object sender, EventArgs e)
        {
            if (listBox_left.SelectedItems.Count >= 1)
                listBox_left.Items.RemoveAt(listBox_left.SelectedIndex);
        }

        private void button_Delete_right_Click(object sender, EventArgs e)
        {
            if (listBox_right.SelectedItems.Count >= 1)
                listBox_right.Items.RemoveAt(listBox_right.SelectedIndex);
        }

        private void button_tp_Click(object sender, EventArgs e)
        {
            if (listBox_left.SelectedItems.Count >= 1)
            {
                listBox_right.Items.Add(listBox_left.SelectedItem.ToString());
                listBox_left.Items.RemoveAt(listBox_left.SelectedIndex);
            }
        }

        private void button_re_Click(object sender, EventArgs e)
        {
            if (listBox_right.SelectedItems.Count >= 1)
            {
                textBox_path.Text = listBox_right.SelectedItem.ToString();
                listBox_right.Items.RemoveAt(listBox_right.SelectedIndex);
            } // if
            else
            {
                MessageBox.Show("Вы не выбрали строку для повторной проверки!", "Что-то пошло не так!");
            }
        }
    }
}

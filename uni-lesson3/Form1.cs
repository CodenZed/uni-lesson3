using System;
using System.Windows.Forms;

namespace uni_lesson3
{
    public partial class Form1 : Form
    {
        int count = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
        }

        private void label9_Click(object sender, EventArgs e)
        {
        }

        // Exit
        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show(
                "Are you sure to exit?",
                "Notification",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (d == DialogResult.Yes)
            {
                Close();
            }
        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            string a = comboBox1.Text;
            string b = comboBox2.Text;
            string c = a;
            comboBox1.Text = b;
            comboBox2.Text = c;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(comboBox1.Text) ||
                string.IsNullOrWhiteSpace(comboBox2.Text) ||
                !maskedTextBox1.MaskCompleted ||
                !maskedTextBox2.MaskCompleted ||
                string.IsNullOrWhiteSpace(textBox1.Text) ||
                string.IsNullOrWhiteSpace(textBox2.Text) ||
                string.IsNullOrWhiteSpace(textBox3.Text) ||
                
                string.IsNullOrWhiteSpace(textBox4.Text))
            {
                MessageBox.Show("Bütün yerləri doldurun.");
                return;
            }

            if (comboBox1.Text.Trim().Equals(
                comboBox2.Text.Trim(),
                StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("Eyni şəhərdən eyni şəhərə bilet almaq olmaz.");
                return;
            }

            count++;

            listBox1.Items.Add(
                count.ToString() + ") " +
                comboBox1.Text + " " +
                comboBox2.Text + " " +
                maskedTextBox1.Text + " " +
                maskedTextBox2.Text + " " +
                textBox1.Text + " " +
                textBox2.Text);

            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            comboBox1.Text = "";
            comboBox2.Text = "";

            maskedTextBox1.Clear();
            maskedTextBox2.Clear();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }

        
        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Silmək üçün əvvəlcə bir bilet seç.");
                return;
            }

            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
        }
    }
}
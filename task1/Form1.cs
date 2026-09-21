using System.Collections.Generic;
namespace task1
{
    public partial class Form1 : Form
    {
        Dictionary<string, string> users = new Dictionary<string, string>();

        public Form1()
        {
            InitializeComponent();
            users.Add("admin", "admin");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Username or Password empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                if (users.ContainsKey(textBox2.Text) && users[textBox2.Text] == textBox1.Text)
                {
                    MessageBox.Show("System is successfully activated.", "Activated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else if (!users.ContainsKey(textBox2.Text))
                {
                    MessageBox.Show("Username could not be found. Please Sign Up!", "No such username", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show("Username or Password is incorrect!", "Incorrect", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox1.Clear();
                    textBox2.Clear();
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox1.UseSystemPasswordChar = false;
            }

            else
            {
                textBox1.UseSystemPasswordChar = true;
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (users.ContainsKey(textBox4.Text))
            {
                MessageBox.Show("Username already exists.", "Try another username", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("User is successfully added! Try to log in.", "Logged Up", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                users.Add(textBox4.Text, textBox3.Text);
                textBox3.Clear();
                textBox4.Clear();
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

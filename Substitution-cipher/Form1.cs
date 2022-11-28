using System.IO;

namespace Substitution_cipher
{
    public partial class Form1 : Form
    {
        Substitution s;
        public Form1()
        {
            InitializeComponent();
            s = new Substitution();
        }
        SaveFileDialog saveFile;

        private void button4_Click(object sender, EventArgs e)
        {
            saveFile = new SaveFileDialog();
            saveFile.Filter = "|*.txt";
            saveFile.RestoreDirectory = true;
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(saveFile.FileName);
                sw.Write(outputTextBox.Text);
                sw.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            inputTextBox.Text = "";
            outputTextBox.Text = "";
            keyTextBox.Text = "";
            inputTextBox.Focus();
        }

        private void encipherButton_Click(object sender, EventArgs e)
        {
            if (s.SetKey(keyTextBox.Text))
            {
                outputTextBox.Text = s.Encrypt(inputTextBox.Text);
            }
            else
            {
                outputTextBox.Text = "Key is not valid! please type again";
            }
        }

        private void decipherButton_Click(object sender, EventArgs e)
        {
            if (s.SetKey(keyTextBox.Text))
            {
                outputTextBox.Text = s.Decrypt(inputTextBox.Text);
            }
            else
            {
                outputTextBox.Text = "Key is not valid! please type again";
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InformationSecurityLab7
{
    public partial class GronsfeldCipherForm : Form
    {

        public GronsfeldCipherForm()
        {
            InitializeComponent();
        }

        private string Cipher(char[] input, string key)
        {
            StringBuilder output = new StringBuilder();
            int keyIndex = 0;

            for (int i = 0; i < input.Length; i++)
            {
                int index = input[i] - 'а';
                int newIndex = (index + key[keyIndex] - '0') % 32;
                output.Append((char)(newIndex + 'а'));
                keyIndex++;

                if (keyIndex >= key.Length)
                    keyIndex = 0;
            }

            return output.ToString();
        }

        private void buttonCypher_Click(object sender, EventArgs e)
        {
            textBoxEncrypted.Text = Cipher(textBoxDecrypted.Text.ToLower().ToCharArray(), textBoxKey.Text);
        }
    }
}
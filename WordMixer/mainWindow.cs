using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace WordMixer
    {
    public partial class mainWindow : Form
        {
        public mainWindow()
            {
            InitializeComponent();
            }

        private void mixButton_Click(object sender, EventArgs e)
            {
            string input1 = Regex.Replace(inputBox1.Text.Trim(), @"\s+", " ");
            string input2 = Regex.Replace(inputBox2.Text.Trim(), @"\s+", " ");
            string mixed_string = mix(input1, input2);
            resultBox.Text = mixed_string;
            }

        private string mix(string input1, string input2)
            {
            string result_string = "";

            return result_string;
            }
        }
    }

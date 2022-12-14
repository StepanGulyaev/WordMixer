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
            string[] input1_arr = input1.Split(' ');
            string[] input2_arr = input2.Split(' ');
            if (input1_arr.Length >= input2_arr.Length)
                {
                for (int i = 0;i<input1_arr.Length;i++)
                    {
                    result_string += $"{input1_arr[input1_arr.Length - 1 - i]} ";
                    if(i<input2_arr.Length-1)
                        {
                        result_string += $"{input2_arr[input2_arr.Length - 1 - i]} ";
                        }
                    }
                }
            else
                {
                for (int i = 0; i < input2_arr.Length; i++)
                    {
                    if (i < input1_arr.Length-1)
                        {
                        result_string += $"{input1_arr[input1_arr.Length - 1 - i]} ";
                        }
                    result_string += $"{input2_arr[input2_arr.Length - 1 - i]} ";
                    }
                }
            result_string = result_string.Trim();
            return result_string;
            }
        }
    }

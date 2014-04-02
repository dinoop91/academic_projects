using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace OCR
{
    public partial class pascii : Form
    {
        string hexkey;
        public pascii()
        {
            InitializeComponent();
        }

        private void OK_Click(object sender, EventArgs e)
        {
            string conv = Program.ende;
            switch (conv)
            {
                case "R1":

                    Program.key = encrypt(keybox.Text);
                    Program.text = encrypt(Program.text);
                    Program.text =  Program.key+Program.text;
                    word w1 = new word();
                    w1.Show();
                    this.Hide();
                    break;

                case "R2":
                    byte[] mybytes = hexencrption(keybox.Text);

                    hexkey = BitConverter.ToString(mybytes);

                    hexkey = hexkey.Replace("-", "");
                    hexkey = hexkey.Replace("00", "");
                    Program.text = encrypthexa();
                    word w2 = new word();
                    w2.Show();
                    this.Hide();
                    break;

                case "R3":
                    string data1 = "";
                    Program.decryptkey = encrypt(keybox.Text);
                    string entext = Program.text;

                    for (int i = 0; i < 8; i++)
                    {
                        data1 += entext[i];
                    }
                    if (Program.decryptkey == data1)
                    {
                        Program.text = decrypt1(Program.text);
                        word w3 = new word();
                        w3.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Key Mismatch");
                    }

                    break;

                case "R4":
                     string data2 = "";
                     byte[] mybyt = hexencrption(keybox.Text);

                     hexkey = BitConverter.ToString(mybyt);
                     hexkey = hexkey.Replace("-", "");
                     hexkey = hexkey.Replace("00", "");
                     string entext1 = Program.text;

                     for (int i = 0; i < 2; i++)
                        {
                        data2 += entext1[i];
                        }
                    if (hexkey == data2)
                        {
                        Program.text = hexdecrypt1(Program.text);
                        word w4 = new word();
                        w4.Show();
                        this.Hide();
                        }
                    else
                        {
                        MessageBox.Show("Key Mismatch");
                        }
                    break;
            }

        }


        public string encrypt(string data)
        {
            string convert = "";
            byte[] byteArray = ASCIIEncoding.ASCII.GetBytes(data);
           
            for (int i = 0; i < byteArray.Length; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    convert += (byteArray[i] & 0X80) > 0 ? "1" : "0";
                    byteArray[i] <<= 1;
                }
            }
            return convert;
        }


        public static byte[] hexencrption(string data)
        {
            return (new UnicodeEncoding()).GetBytes(data);
        }

        public string encrypthexa()
        {
            byte[] mybytes = hexencrption(Program.text);
            string hexstring = BitConverter.ToString(mybytes);
            hexstring = hexstring.Replace("-", "");
            hexstring = hexstring.Replace("00", "");
            Program.text = hexkey + hexstring;
            return Program.text;
        }

         public string decrypt1(string data)
        {
            byte[] list = new byte[1000];
            int j = 0;
            for (int i = 8; i < data.Length; i += 8)
            {
                string st = data.Substring(i, 8);
                list[j] = Convert.ToByte(st, 2);
                j++;
            }
            string text = Encoding.ASCII.GetString(list);
            return text;
        }

         public string hexdecrypt1(string data)
         {
             string hexstring = data;
             StringBuilder sb = new StringBuilder();
             for (int i = 2; i <= hexstring.Length - 2; i += 2)
             {
                 sb.Append(Convert.ToChar(Int32.Parse(hexstring.Substring(i,2), System.Globalization.NumberStyles.HexNumber)));
             }
             string text = sb.ToString();
             return text;
         }

         private void cancel_Click(object sender, EventArgs e)
         {
             this.Hide();
         }
    }
}

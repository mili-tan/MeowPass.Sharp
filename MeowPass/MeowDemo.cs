﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeowPass
{
    public partial class MeowDemo : Form
    {
        public MeowDemo()
        {
            InitializeComponent();
        }

        private void meowButton_Click(object sender, EventArgs e)
        {
            string uPassCrypto = "";
            if (shaRButton.Checked)
            {
                uPassCrypto = MeowTool.MySHACrypto(uPassBox.Text.ToString());
            }
            else if(md5RButton.Checked)
            {
                uPassCrypto = MeowTool.MyMD5Crypto(uPassBox.Text.ToString());
            }
            switch (encryptBox.SelectedIndex)
            {
                case 0:
                    passBox.Text = MeowTool.MyDESCrypto(tagBox.Text, uPassCrypto);
                    break;
                case 1:
                    passBox.Text = MeowTool.MyTripleDESCrypto(tagBox.Text, uPassCrypto);
                    break;
                default:
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            encryptBox.SelectedIndex = 0;
        }
    }
}

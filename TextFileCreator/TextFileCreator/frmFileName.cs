﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextFileCreator
{
    public partial class frmFileName : Form
    {
        public static string SetFileName;
        public frmFileName()
        {
            InitializeComponent();
        }

        private void btnOkay_Click(object sender, EventArgs e)
        {
            SetFileName = $"{txtFileName.Text}.txt";
            using(FrmRegistration registrationPage = new FrmRegistration())
            {
                MessageBox.Show("Proceeding to Registration Form");
                registrationPage.ShowDialog();
            }
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace AllLab
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start("Lab1.exe");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process.Start("Lab2.exe");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Process.Start("Lab3.exe");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Process.Start("Lab4.exe");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Process.Start("Lab5.exe");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Process.Start("Lab6.exe");

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Process.Start("OpenGLTest.exe");
        }
    }
}

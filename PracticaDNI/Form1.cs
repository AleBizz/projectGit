using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaDNI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int dni = Convert.ToInt32(textBoxDni.Text);
            char letter = functionDni(dni);
            textBoxLetter.Text = Convert.ToString(letter);
        }

        private char functionDni(int dni)
        {
            char letter = 'A';

            return letter;
        }
    }
}

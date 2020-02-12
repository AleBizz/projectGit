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
            if (dni == 8)
            {
                
                int result = dni % 23;
                char[] characters = { 'T', 'R', 'W', 'A', 'G', 'M', 'Y', 'F', 'P', 'D', 'X', 'B', 'N', 'J', 'Z', 'S', 'Q', 'V', 'H', 'L', 'C', 'K', 'E' };
                letter = characters[result];
                return letter;
            }
            else
            {
                textBoxDni.Text ="Wrong DNI";
            }
            return letter;
        }
    }
}

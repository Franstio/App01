using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App01
{
    public partial class Form2 : Form
    {
        public Teks teks = new Teks();
        public Form2()
        {
            InitializeComponent();
        }

        public Form2(Teks teks)
        {
            this.teks = teks;
            this.richTextBox1.Text = teks.teks;
        }
    }
}

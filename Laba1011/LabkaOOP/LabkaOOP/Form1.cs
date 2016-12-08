using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LabkaOOP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (errorKvadr1.FindError(a1, b1, c1))
            {
                //  KvadrUr uravnenie = new KvadrUr(aBox.Text, bBox.Text, cBox.Text);
                //  x1.Text = uravnenie.KvadrMath(1);
                //  x2.Text = uravnenie.KvadrMath(2);
            }
            if (errorKvadr1.FindError(a2, b2, c2))
            {

            }
        }
    }
}

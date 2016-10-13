using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Kvadratic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ResultButton_Click(object sender, EventArgs e)
        {
           if(errorKvadr1.FindError(aBox,bBox,cBox))
            {
                KvadrUr uravnenie = new KvadrUr(aBox.Text, bBox.Text, cBox.Text);
                x1.Text = uravnenie.KvadrMath(1);
                x2.Text = uravnenie.KvadrMath(2);
            }
        }
    }
}

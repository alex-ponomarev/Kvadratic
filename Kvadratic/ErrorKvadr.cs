using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Kvadratic
{
    public partial class ErrorKvadr : Component
    {
        public ErrorKvadr()
        {
            InitializeComponent();
        }

        public ErrorKvadr(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        public bool FindError(TextBox a, TextBox b, TextBox c)
        {
            bool noError = true;
            string erMessage1 = "Допускаются только числа";
            errorProvider1.Dispose();
            try
            {
                double.Parse(a.Text);
            }
            catch
            {
                noError = false;
                errorProvider1.SetError(a, erMessage1);
            }

            try
            {
                double.Parse(b.Text);               
            }
            catch
            {
                noError = false;
                errorProvider1.SetError(b, erMessage1);
            }

            try
            {
                double.Parse(c.Text);
            }
            catch
            {
                noError = false;
                errorProvider1.SetError(c, erMessage1);
            }
            return noError;

        }
    }
}

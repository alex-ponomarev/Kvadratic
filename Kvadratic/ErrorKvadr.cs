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
            bool NoError = true;
            errorProvider1.Dispose();
            try
            {
                double.Parse(a.Text);
            }
            catch
            {
                NoError = false;
                errorProvider1.SetError(a, "Допускаются только числа");
            }

            try
            {
                double.Parse(b.Text);               
            }
            catch
            {
                NoError = false;
                errorProvider1.SetError(b, "Допускаются только числа");
            }

            try
            {
                double.Parse(c.Text);
            }
            catch
            {
                NoError = false;
                errorProvider1.SetError(c, "Допускаются только числа");
            }
            return NoError;

        }
    }
}

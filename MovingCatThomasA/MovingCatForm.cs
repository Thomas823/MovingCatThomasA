using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovingCatThomasA
{
    public partial class frmMovingCat : System.Windows.Forms.Form
    {
        public frmMovingCat()
        {
            InitializeComponent();
        }

        // Close the program when clicked on
        private void mniExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

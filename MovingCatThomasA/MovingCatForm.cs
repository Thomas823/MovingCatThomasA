/*
 * Created by: Thomas Aubin
 * Created on: 5 April, 2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #8 - Moving Cat
 * This program displays a menu bar with menu items that when clicked on will change the picture in the picture box
*/

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

        private void mniExit_Click(object sender, EventArgs e)
        {
            // Close program when exit button clicked
            this.Close();
        }

        private void mniCat1_Click(object sender, EventArgs e)
        {
            // Change image to cat1 image
            this.picCat.Image = Properties.Resources.cat1;
        }

        private void mniCat2_Click(object sender, EventArgs e)
        {
            // Change image to cat2 image
            this.picCat.Image = Properties.Resources.cat2;
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oct15_FormRegistration_BautistsaM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public Point mouseLoc;
        public Point bottleMouse;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseLoc = new Point(-e.X, -e.Y);
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)//checks if left mouse button is held or pressed : D
            {
                Point mousePose = Control.MousePosition;//point var of mouse cursor from topleft corner of sccreen
                mousePose.Offset(mouseLoc.X, mouseLoc.Y);//translates point depending on the location of mouseLoc
                Location = mousePose;//forms location is moved depending on the location of the point variable 
            }
        }
    }
}

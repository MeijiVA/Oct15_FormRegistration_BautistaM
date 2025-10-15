using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oct15_FormRegistration_BautistsaM
{
    public partial class FrmRegistration : Form
    {
        public FrmRegistration()
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string name = "//" +txtStudentNum.Text + ".txt";
            string[] toWrite = new string[7];
            toWrite[0] = "Student No.:" + txtStudentNum.Text;
            toWrite[1] = "Name    :" + txtLName.Text + ", " + txtFName.Text + " " + txtMName.Text;
            toWrite[2] = "Program :" + cBoxProgram.Text;
            toWrite[3] = "Gender  :" + cBoxGender.Text;
            toWrite[4] = "Age     :" + txtAge.Text;
            toWrite[5] = "Birthday:" + dtpDate.Text;
            toWrite[6] = "Contact No.:" + txtContactNum.Text;
            string docPath = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
            FileStream fs = new FileStream(docPath + name, FileMode.Create);
            StreamWriter streamWriter = new StreamWriter(fs);
            int i = 0;
            foreach (string s in toWrite)
            {
                streamWriter.WriteLine(toWrite[i]);
                i++;
            }
            streamWriter.Close();
        }    

    }//class
}//namespace


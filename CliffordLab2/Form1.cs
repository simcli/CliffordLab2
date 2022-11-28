using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CliffordLab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Simon Clifford
            // Oct 6th 2022
            // Lab 2 has 2 purposes the multiplier and the information.

            //Events
            txtNumber.Focus();

        }

        // btnExit_click
        // This event closes the form
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // btnPicture_click
        // This event shows the picture and closes the discription
        private void btnPicture_Click(object sender, EventArgs e)
        {
            lblDiscription.Visible = false;
            picMyPicture.Visible = true;
        }
        // btnHide
        // This event hides the picture and the discription
        private void btnHide_Click(object sender, EventArgs e)
        {
            picMyPicture.Visible = false;           
            lblDiscription.Visible = false;
        }
        //Reset button 
        //sets textbox and answer label to nothing
        //puts focus back to number textbox
        private void btnReset_Click(object sender, EventArgs e)
        {
            txtNumber.Text = "";
            txtMultiplier.Text = "";
            lblAnswer.Text = "";
            txtNumber.Focus();
        }

        // This event shows the discription and concatenates the lblTopic with the discription
        private void btnData_Click(object sender, EventArgs e)
        {
            
            picMyPicture.Visible = false;
            lblDiscription.Visible = true;          
            lblDiscription.Text = lblTopic.Text + lblDiscription.Text;
            

        }
        //This event displays a message box when the user clicks the picture
        private void picMyPicture_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("This is my Dog\nhis name is Norman", "Simon Clifford");
        }
        // This event takes the number and multiplier and multiplies them together
        // Then is displays the answer in the lblanswer
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int number = Convert.ToInt32(txtNumber.Text);
            int multiplier = Convert.ToInt32(txtMultiplier.Text);
            int answer;

            answer = number * multiplier;

            lblAnswer.Text = answer.ToString();

        }
    }
}

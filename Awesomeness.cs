// Name: Gaelen Rhoads
// StudentID: 100804776
// Date: 14 Jan 2021
// Title: Awesomeness Detector!
// Description: This program does not allow the user to select the "No" buttons because we made use of the boolean visable states and event handlers.



using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AwesomenessCE1
{
    public partial class Awesomeness : Form
    {
        public Awesomeness()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Hides the left no button and shows the right no button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HideLeft(object sender, EventArgs e)
        {
            LeftNo.Visible = false;
            RightNo.Visible = true;

        }

        /// <summary>
        /// Displays congratulatory message and ends the application.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonYesClick(object sender, EventArgs e)
        {
            // Display message and close form.
            MessageBox.Show("Yes, you ARE awesome. Congratulations! And have a nice day.");
            Close();
        }

        /// <summary>
        /// Hides the right no button and shows the left no button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HideRight(object sender, EventArgs e)
        {
            RightNo.Hide();
            LeftNo.Show();
        }
    }
}

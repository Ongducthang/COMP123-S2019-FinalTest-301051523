using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
/*
 //STUDENT: Duc Thang ONG
 //ID: 301051523
 //DESCRIPTION: this is the Character Generator Form
 */
namespace COMP123_S2019_FinalTest.Views
{
    public partial class CharacterGeneratorForm : MasterForm
    {
        public CharacterGeneratorForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// this is the event handler for the BackButton Click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackButton_Click(object sender, EventArgs e)
        {
            if (mainTabControl.SelectedIndex != 0 )
            {
                mainTabControl.SelectedIndex--;
            }
        }

        private void FirstNameDataLabel_Click(object sender, EventArgs e)
        {

        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            if (mainTabControl.SelectedIndex < mainTabControl.TabPages.Count)
            {
                mainTabControl.SelectedIndex++;
            }
        }
        //dsfa
    }
}

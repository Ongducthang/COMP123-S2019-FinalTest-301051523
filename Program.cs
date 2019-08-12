using COMP123_S2019_FinalTest.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 //STUDENT: Duc Thang ONG
 //ID: 301051523
 //DESCRIPTION: this is the main driver class for the application
     */
namespace COMP123_S2019_FinalTest
{
    static class Program
    {   //temporary
        public static CharacterGeneratorForm characterForm;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            characterForm = new CharacterGeneratorForm();
            Application.Run(characterForm);
        }
    }
}

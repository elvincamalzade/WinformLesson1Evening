using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstApp
{
    static class Program
    {

        #region MessageBox


        //static DialogResult getDialogResult()
        //{
        //    DialogResult result;
        //    string message = "Window displaying a text message";

        //    //result=MessageBox.Show("Test");

        //    string caption = "C# programming";

        //    //result=MessageBox.Show(message,caption,MessageBoxButtons.OKCancel);

        //    result = MessageBox.Show(message, caption, MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Warning);

        //    return result;
        //}

        ///// <summary>
        ///// The main entry point for the application.
        ///// </summary>
        //[STAThread]
        //static void Main()
        //{
        //    //Application.EnableVisualStyles();
        //    //Application.SetCompatibleTextRenderingDefault(false);
        //    //Application.Run(new Form1());

        //    DialogResult dialog = getDialogResult();

        //    if (dialog == DialogResult.Abort)
        //    {
        //        MessageBox.Show("You clicked Abort button");
        //    }
        //    else if (dialog == DialogResult.Ignore)
        //    {
        //        MessageBox.Show("You clicked Ignore button");
        //    }
        //    else if (dialog == DialogResult.Retry)
        //    {
        //        MessageBox.Show("You clicked Retry button");
        //    }

        //    //if (dialog == DialogResult.OK)
        //    //{
        //    //    MessageBox.Show("You clicked OK button");
        //    //}
        //    //else if (dialog == DialogResult.Cancel)
        //    //{
        //    //    MessageBox.Show("You clicked CANCEL button");
        //    //}

        //}

        #endregion


        #region Form and Controls



        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
        #endregion

    }
}

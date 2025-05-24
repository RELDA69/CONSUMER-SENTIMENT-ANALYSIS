using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CONSUMER_SENTIMENT_ANALYSIS
{

    internal static class Program
    {
        
        
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            // Enable visual styles for modern UI appearance
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            // Start the application with Form1 as the main UI
            Application.Run(new Form1());
        }
    }
}
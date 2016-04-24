/*
Welcome to my new project, VOS / Virtual Operaring System!!!

Copywrite 2016 Bogdan Pechyorin, Enjoy

This project was published under the MIT liscence
If any source code is used, Please credit me as 'Bogdan0804'!
If you need any help, Feel free to ask!
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Speech;
using System.Windows.Forms;
using System.Threading;

namespace Virtual_OS
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Console.Title = "Virtual OS!!!";
            Console.WriteLine("Thanks for using Virtual OS - Created by Bogdan!\r\nPress enter to start!");

            Console.ReadLine();
            //using (System.Speech.Synthesis.SpeechSynthesizer snth = new System.Speech.Synthesis.SpeechSynthesizer())
            //{
            //    snth.SetOutputToDefaultAudioDevice();
            //    snth.Speak("");
            //}
            Thread th = new Thread(new ThreadStart(delegate {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new MainSource.MotherUI());
            }));

            th.Start();
        }
    }
}

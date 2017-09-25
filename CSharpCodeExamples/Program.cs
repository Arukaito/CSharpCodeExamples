// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Alkaworks">
//   Copyright (c) Alkaworks. All rights reserved.
// </copyright>
// <summary>
//   Defines the Program type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace CSharpCodeExamples
{
    using System;
    using System.Windows.Forms;

    using CSharpCodeExamples.Encapsulation;

    /// <summary>
    /// The main program scope.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Starting the examples below
            Encapsulation();
        }

        /// <summary>
        /// The entry point of my Encapsulation Classes
        /// </summary>
        private static void Encapsulation()
        {
            Rectangulo r = new Rectangulo();
            r.Ancho = 1;
            r.Largo = 2;
            r.Area();
            r.Display();
        }
    }
}

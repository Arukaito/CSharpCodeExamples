// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Form1.cs" company="Alkaworks">
//   Code Examples Showing the basic operations of C#
// </copyright>
// <summary>
//   Defines the form1 
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace CSharpCodeExamples
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Windows.Forms;

    using CSharpCodeExamples.Encapsulation;

    /// <summary>
    /// The main form of this application
    /// </summary>
    public partial class Form1 : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Form1"/> class.
        /// </summary>
        public Form1()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// The encapsulation example using rectangle class.
        /// </summary>
        public void Encapsulacion()
        {
            Rectangulo r = new Rectangulo { Largo = 5, Ancho = 3 };

            r.Display();
        }

        /// <summary>
        /// The event button encapsulation click.
        /// </summary>
        /// <param name="sender">
        /// The default sender.
        /// </param>
        /// <param name="e">
        /// Parameters e.
        /// </param>
        private void BtnEncapsulacionClick(object sender, EventArgs e)
        {
            this.Encapsulacion();
           
        }
    }
}

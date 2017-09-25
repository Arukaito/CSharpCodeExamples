// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Encapsulation.cs" company="Alkaworks">
//   This program is for example only
// </copyright>
// <summary>
//   Defines the Rectangulo type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace CSharpCodeExamples.Encapsulation
{
    using System;
    using System.Windows.Forms;


    /// <summary>
    /// Encapsulation example it serves as an example of public access modifiers and operators
    /// </summary>
    public class Rectangulo
    {
        // Variables publicas


        /// <summary>
        /// Private variables with the information of the Weight and Height
        /// </summary>
        private int largo;

        /// <summary>
        /// Private variables with the information of the Weight and Height
        /// </summary>
        private int ancho;

        /// <summary>
        /// Gets or sets the largo using encapsulation.
        /// </summary>
        public int Largo
        {
            get => this.largo;
            set => this.largo = value;
        }

        /// <summary>
        /// Gets or sets the ancho using encapsulation.
        /// </summary>
        public int Ancho
        {
            get => this.ancho;
            set => this.ancho = value;
        }

        /// <summary>
        /// The area of the rectangle class.
        /// </summary>
        /// <returns>
        /// There are only INT  variables inside this method<see cref="int"/>.
        /// </returns>
        public int Area()
        {
            return this.Largo * this.Ancho;
        }

        /// <summary>
        /// Displays the area weight and Height of the rectangle class and all of its properties 
        /// </summary>
        public void Display()
        {
            // Verbatim Interpolation
            MessageBox.Show($@"Largo: {this.Largo}");
            MessageBox.Show($@"Largo: {this.Ancho}");
            MessageBox.Show(this.Area().ToString());
        }

        // Termina la clase rectangulo
    }
}

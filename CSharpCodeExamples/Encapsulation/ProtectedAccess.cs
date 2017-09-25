// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ProtectedAccess.cs" company="Alkaworks">
//   Copyright (c) Alkaworks. All rights reserved. This program is educational purpose only
// </copyright>
// <summary>
//   Defines the ProtectedAccess type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace CSharpCodeExamples.Encapsulation
{
    using System.Drawing;

    /// <summary>
    /// Here Starts The Examples of a protected access modifier 
    /// </summary>
    public class ProtectedAccess
    {
        /// <summary>
        /// The A class with the protected variable.
        /// </summary>
        public class A 
        {
            /// <summary>
            /// Gets or sets the x.
            /// </summary>
            protected int X { get; set; } = 123;
        }

        /// <summary>
        /// The b class derives from A to use the protected variable.
        /// </summary>
        public class B : A
        {
            /// <summary>
            /// you cannot access a.X because its a protected variable but you can access b.X because is derived from A
            /// This is an example of protected modifiers
            /// </summary>
            public void Main()
            {
                var a = new A();
                var b = new B { X = 10 };

            }
        }
    }
}
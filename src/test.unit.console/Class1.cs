//-----------------------------------------------------------------------
// <copyright company="BuildTester">
//     Copyright 2013 BuildTester. Licensed under the Apache License, Version 2.0.
// </copyright>
//-----------------------------------------------------------------------

using System.Diagnostics.CodeAnalysis;
using NUnit.Framework;

namespace Test.Unit.Console
{
    [SuppressMessage("Microsoft.StyleCop.CSharp.DocumentationRules", "SA1600:ElementsMustBeDocumented",
        Justification = "Unit tests do not need documentation.")]
    [TestFixture]
    public class Class1
    {
        [Test]
        public void ProgramMain()
        {
            Assert.Pass();
        }
    }
}

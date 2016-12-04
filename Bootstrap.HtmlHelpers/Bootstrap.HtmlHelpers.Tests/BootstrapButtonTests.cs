using System;
using Bootstrap.HtmlHelpers.BtnClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bootstrap.HtmlHelpers.Tests
{
    [TestClass]
    public class BootstrapButtonTests
    {
        [TestMethod]
        public void GeneratePrimaryButton()
        {
            const string expectedHtml = @"<button class=""btn btn-primary"" type=""button"">Primary</button>";

            var actual = ButtonsExtensions.BootstrapButton(null, ButtonType.Button, "Primary", Btn.Primary);
            Assert.AreEqual(expectedHtml, actual.ToString());
        }
    }
}

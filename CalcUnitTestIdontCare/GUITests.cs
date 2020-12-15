using System;
using System.Collections.Generic;
using System.Text;

using Microsoft.VisualStudio.TestTools.UnitTesting;
using static CalcWhatever.Calculate;
using FluentAssertions;
using FlaUI.UIA3;
using FlaUI.Core.AutomationElements;

namespace CalcUnitTestIdontCare
{
    [TestClass]
    public class GUITestAdd
    {
        [TestMethod]
        public void HappyAddTest()
        {
            // Set up the automation client and launch the program
            var app = FlaUI.Core.Application.Launch("CalcWhatever.exe");
            using var automation = new UIA3Automation();
            var window = app.GetMainWindow(automation);

            // Find the control elements
            var boxNum1 = window.FindFirstDescendant(cf => cf.ByAutomationId("txtNum1"))?.AsTextBox();
            var boxNum2 = window.FindFirstDescendant(cf => cf.ByAutomationId("txtNum2"))?.AsTextBox();
            var btnAdd = window.FindFirstDescendant(cf => cf.ByAutomationId("btnAdd"))?.AsButton();
            var txtResult = window.FindFirstDescendant(cf => cf.ByAutomationId("txtResult"))?.AsTextBox();

            // Set up test variables
            string input1 = "5";
            string input2 = "6";
            string expected = "11";
            var message = $"the sum of {input1} + {input2} should be {expected}";

            // Peforms automation tasks/events
            boxNum1.Enter(input1);
            boxNum2.Enter(input2);
            btnAdd.Click();

            // Pull the result
            var result = txtResult.Text;

            // Closes the app
            app.Close();

            // Verify result
            result.Should().Be(expected, because: message);
        }

        [TestMethod]
        public void SadAddTest()
        {
            // Set up the automation client and launch the program
            var app = FlaUI.Core.Application.Launch("CalcWhatever.exe");
            using var automation = new UIA3Automation();
            var window = app.GetMainWindow(automation);

            // Find the control elements
            var boxNum1 = window.FindFirstDescendant(cf => cf.ByAutomationId("txtNum1"))?.AsTextBox();
            var boxNum2 = window.FindFirstDescendant(cf => cf.ByAutomationId("txtNum2"))?.AsTextBox();
            var btnAdd = window.FindFirstDescendant(cf => cf.ByAutomationId("btnAdd"))?.AsButton();
            var txtResult = window.FindFirstDescendant(cf => cf.ByAutomationId("txtResult"))?.AsTextBox();

            // Set up test variables
            var input1 = "5";
            var input2 = "a";
            var expected = "Error";
            var message = "one of the inputs is not a valid integer";

            // Peforms automation tasks/events
            boxNum1.Enter(input1);
            boxNum2.Enter(input2);
            btnAdd.Click();


            // Pull the result
            var result = txtResult.Text;

            // Closes the app
            app.Close();

            // Verify result
            result.Should().Be(expected, because: message);
        }
    }

    [TestClass]
    public class GUITestSub
    {
        [TestMethod]
        public void HappySubTest()
        {
            // Set up the automation client and launch the program
            var app = FlaUI.Core.Application.Launch("CalcWhatever.exe");
            using var automation = new UIA3Automation();
            var window = app.GetMainWindow(automation);

            // Find the control elements
            var boxNum1 = window.FindFirstDescendant(cf => cf.ByAutomationId("txtNum1"))?.AsTextBox();
            var boxNum2 = window.FindFirstDescendant(cf => cf.ByAutomationId("txtNum2"))?.AsTextBox();
            var btnSub = window.FindFirstDescendant(cf => cf.ByAutomationId("btnSub"))?.AsButton();
            var txtResult = window.FindFirstDescendant(cf => cf.ByAutomationId("txtResult"))?.AsTextBox();

            // Set up test variables
            string input1 = "5";
            string input2 = "6";
            string expected = "-1";
            var message = $"the difference of {input1} - {input2} should be {expected}";

            // Peforms automation tasks/events
            boxNum1.Enter(input1);
            boxNum2.Enter(input2);
            btnSub.Click();

            // Pull the result
            var result = txtResult.Text;

            // Closes the app
            app.Close();

            // Verify result
            result.Should().Be(expected, because: message);
        }

        [TestMethod]
        public void SadSubTest()
        {
            // Set up the automation client and launch the program
            var app = FlaUI.Core.Application.Launch("CalcWhatever.exe");
            using var automation = new UIA3Automation();
            var window = app.GetMainWindow(automation);

            // Find the control elements
            var boxNum1 = window.FindFirstDescendant(cf => cf.ByAutomationId("txtNum1"))?.AsTextBox();
            var boxNum2 = window.FindFirstDescendant(cf => cf.ByAutomationId("txtNum2"))?.AsTextBox();
            var btnSub = window.FindFirstDescendant(cf => cf.ByAutomationId("btnSub"))?.AsButton();
            var txtResult = window.FindFirstDescendant(cf => cf.ByAutomationId("txtResult"))?.AsTextBox();

            // Set up test variables
            var input1 = "5";
            var input2 = "a";
            var expected = "Error";
            var message = "one of the inputs is not a valid integer";

            // Peforms automation tasks/events
            boxNum1.Enter(input1);
            boxNum2.Enter(input2);
            btnSub.Click();


            // Pull the result
            var result = txtResult.Text;

            // Closes the app
            app.Close();

            // Verify result
            result.Should().Be(expected, because: message);
        }
    }

    [TestClass]
    public class GUITestMulti
    {
        [TestMethod]
        public void HappyMultiTest()
        {
            // Set up the automation client and launch the program
            var app = FlaUI.Core.Application.Launch("CalcWhatever.exe");
            using var automation = new UIA3Automation();
            var window = app.GetMainWindow(automation);

            // Find the control elements
            var boxNum1 = window.FindFirstDescendant(cf => cf.ByAutomationId("txtNum1"))?.AsTextBox();
            var boxNum2 = window.FindFirstDescendant(cf => cf.ByAutomationId("txtNum2"))?.AsTextBox();
            var btnMulti = window.FindFirstDescendant(cf => cf.ByAutomationId("btnMulti"))?.AsButton();
            var txtResult = window.FindFirstDescendant(cf => cf.ByAutomationId("txtResult"))?.AsTextBox();

            // Set up test variables
            string input1 = "5";
            string input2 = "6";
            string expected = "30";
            var message = $"the product of {input1} - {input2} should be {expected}";

            // Peforms automation tasks/events
            boxNum1.Enter(input1);
            boxNum2.Enter(input2);
            btnMulti.Click();

            // Pull the result
            var result = txtResult.Text;

            // Closes the app
            app.Close();

            // Verify result
            result.Should().Be(expected, because: message);
        }

        [TestMethod]
        public void SadMultiTest()
        {
            // Set up the automation client and launch the program
            var app = FlaUI.Core.Application.Launch("CalcWhatever.exe");
            using var automation = new UIA3Automation();
            var window = app.GetMainWindow(automation);

            // Find the control elements
            var boxNum1 = window.FindFirstDescendant(cf => cf.ByAutomationId("txtNum1"))?.AsTextBox();
            var boxNum2 = window.FindFirstDescendant(cf => cf.ByAutomationId("txtNum2"))?.AsTextBox();
            var btnMulti = window.FindFirstDescendant(cf => cf.ByAutomationId("btnMulti"))?.AsButton();
            var txtResult = window.FindFirstDescendant(cf => cf.ByAutomationId("txtResult"))?.AsTextBox();

            // Set up test variables
            var input1 = "5";
            var input2 = "a";
            var expected = "Error";
            var message = "one of the inputs is not a valid integer";

            // Peforms automation tasks/events
            boxNum1.Enter(input1);
            boxNum2.Enter(input2);
            btnMulti.Click();


            // Pull the result
            var result = txtResult.Text;

            // Closes the app
            app.Close();

            // Verify result
            result.Should().Be(expected, because: message);
        }
    }

    [TestClass]
    public class GUITestDivide
    {
        [TestMethod]
        public void HappyDivideTest()
        {
            // Set up the automation client and launch the program
            var app = FlaUI.Core.Application.Launch("CalcWhatever.exe");
            using var automation = new UIA3Automation();
            var window = app.GetMainWindow(automation);

            // Find the control elements
            var boxNum1 = window.FindFirstDescendant(cf => cf.ByAutomationId("txtNum1"))?.AsTextBox();
            var boxNum2 = window.FindFirstDescendant(cf => cf.ByAutomationId("txtNum2"))?.AsTextBox();
            var btnDivide = window.FindFirstDescendant(cf => cf.ByAutomationId("btnDivide"))?.AsButton();
            var txtResult = window.FindFirstDescendant(cf => cf.ByAutomationId("txtResult"))?.AsTextBox();

            // Set up test variables
            string input1 = "8";
            string input2 = "4";
            string expected = "2";
            var message = $"the quotient of {input1} / {input2} should be {expected}";

            // Peforms automation tasks/events
            boxNum1.Enter(input1);
            boxNum2.Enter(input2);
            btnDivide.Click();

            // Pull the result
            var result = txtResult.Text;

            // Closes the app
            app.Close();

            // Verify result
            result.Should().Be(expected, because: message);
        }

        public void SadDivideTest()
        {
            // Set up the automation client and launch the program
            var app = FlaUI.Core.Application.Launch("CalcWhatever.exe");
            using var automation = new UIA3Automation();
            var window = app.GetMainWindow(automation);

            // Find the control elements
            var boxNum1 = window.FindFirstDescendant(cf => cf.ByAutomationId("txtNum1"))?.AsTextBox();
            var boxNum2 = window.FindFirstDescendant(cf => cf.ByAutomationId("txtNum2"))?.AsTextBox();
            var btnDivide = window.FindFirstDescendant(cf => cf.ByAutomationId("btnDivide"))?.AsButton();
            var txtResult = window.FindFirstDescendant(cf => cf.ByAutomationId("txtResult"))?.AsTextBox();

            // Set up test variables
            string input1 = "8";
            string input2 = "a";
            string expected = "Error";
            var message = $"one of the inputs is not a valid integer";

            // Peforms automation tasks/events
            boxNum1.Enter(input1);
            boxNum2.Enter(input2);
            btnDivide.Click();

            // Pull the result
            var result = txtResult.Text;

            // Closes the app
            app.Close();

            // Verify result
            result.Should().Be(expected, because: message);
        }

        public void DivideByZeroTest()
        {
            // Set up the automation client and launch the program
            var app = FlaUI.Core.Application.Launch("CalcWhatever.exe");
            using var automation = new UIA3Automation();
            var window = app.GetMainWindow(automation);

            // Find the control elements    
            var boxNum1 = window.FindFirstDescendant(cf => cf.ByAutomationId("txtNum1"))?.AsTextBox();        
            var boxNum2 = window.FindFirstDescendant(cf => cf.ByAutomationId("txtNum2"))?.AsTextBox();
            var btnDivide = window.FindFirstDescendant(cf => cf.ByAutomationId("btnDivide"))?.AsButton();
            var txtResult = window.FindFirstDescendant(cf => cf.ByAutomationId("txtResult"))?.AsTextBox();

            // Set up test variables
            string input1 = "8";
            string input2 = "0";
            string expected = "Error";
            var message = $"you cannot have a divisor of {input2}";

            // Peforms automation tasks/events
            boxNum1.Enter(input1);
            boxNum2.Enter(input2);
            btnDivide.Click();

            // Pull the result
            var result = txtResult.Text;

            // Closes the app
            app.Close();

            // Verify result
            result.Should().Be(expected, because: message);
        }
    }
}

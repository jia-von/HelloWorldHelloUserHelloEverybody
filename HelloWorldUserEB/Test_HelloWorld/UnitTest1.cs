using NUnit.Framework;
using System;
using System.IO;

namespace Test_HelloWorld
{
    public class Tests
    {


        [SetUp]
        public void Setup()
        {
            HelloWorldUserEB.Program.keyPressed = ConsoleKey.Enter;
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
        //Citation:
        //https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/inside-a-program/hello-world-your-first-program?tabs=windows
        //The following unit test wil capture the Console's output inside of the sw variable
        //We will compare the value of sw with our expected output to make our assertion
        [Test]
        public void Test_HelloWorld()
        {
            string expected = "Hello World!";
            var sw = new StringWriter();
            Console.SetOut(sw);
            HelloWorldUserEB.Program.Main();

            var result = sw.ToString().Trim();
            Assert.AreEqual(expected, result);
        }
        //End citation
    }
}

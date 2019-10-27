using System;
using System.Activities;
using System.Collections.Generic;
using clCustomActivity;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace clCustomActivityTest
{
    [TestClass]
    public class UnitTest1
    {
        string name = "SomeOne";

        [TestMethod]
        public void TestMethod1()
        {
            var output = WorkflowInvoker.Invoke(new Greet { FirstName = new InArgument<string>(name) });
            Assert.AreEqual(string.Format("Hi {0} Wenlcome to UiPath",name), output["GreetingMessage"]);
            //foreach (var item in output)
            //{
            //    Console.WriteLine(item.Key + "=>" + item.Value);
            //}




        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mlily.WMSInterfacer.Core;
using System;

namespace Mlily.WMSInterface.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            XMLHelper helper = new XMLHelper();
            var model = helper.Do();

            Console.WriteLine(model.ReqeustData.RequestInfo.Content.Items.Count);
            Assert.IsTrue(true);
        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using NetCoFoBA;

namespace test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var client=new NetCoFoBAClient();
            var result=client.GetData().Result;
            
        }
    }
}

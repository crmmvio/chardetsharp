using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CharDetSharp.UniversalCharDet.Tests
{
    [TestClass]
    public class ThaiDetectionTestFixture : BaseDetectionTestFixure
    {
        public TestContext TestContext { get; set; }

        [TestMethod]
        public void TestLatin7Detection()
        {
            RunThaiTest(Encoding.GetEncoding("TIS-620"));
        }

        [Ignore]
        [TestMethod]
        public void TestUtf8Detection()
        {
            RunThaiTest(Encoding.UTF8);
        }

        [Ignore]
        [TestMethod]
        public void TestUnicodeDetection()
        {
            RunThaiTest(Encoding.Unicode);
        }

        internal void RunThaiTest(Encoding enc)
        {
            RunSBCSGroupTest(enc, @"CharDetSharp.UniversalCharDet.Tests.Samples.th.utf-8.txt",
                new TIS620CharSetProber());
        }
    }
}

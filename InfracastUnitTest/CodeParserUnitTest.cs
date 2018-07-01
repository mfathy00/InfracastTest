using Microsoft.VisualStudio.TestTools.UnitTesting;
using InfracastTest.Interfaces;
using InfracastTest.Services;

namespace InfracastUnitTest
{
    [TestClass]
    public class CodeParserUnitTest
    {
        ICodeParser codeParser;
        [TestInitialize]
        public void TestInitialize()
        {
            codeParser = new CodeParser();
        }

        [TestMethod]
        public void CheckTotalBlockss()
        {
            Assert.AreEqual(8, codeParser.GetTotalBlocks());
        }

        [TestMethod]
        public void CheckTotalStatments()
        {
            Assert.AreEqual(20, codeParser.GetTotalStatments());

        }

        [TestMethod]
        public void CheckTotalExperession()
        {
            Assert.AreEqual(5, codeParser.GetTotalExperession());
        }

    }
}

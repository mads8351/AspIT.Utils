using System;
using AspIT.Utils.Collections;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AspIT.Utils.Collections.Tests
{
    [TestClass]
    public class EasyListTests
    {
        [TestMethod]
        public void InitializationPasses()
        {
            EasyList<int> list = new EasyList<int>(-1);
        }
    }
}

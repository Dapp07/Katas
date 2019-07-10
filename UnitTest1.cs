using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KataSortTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CLEANING_TEXT()
        {
            var data = "";
            var Needed = "";

            var charSort = new CharSort(data);
            charSort.CLEANING_TEXT();

            Assert.AreEqual(Needed, charSort);
        }
    }

    internal class CharSort
    {
        private string data;

        public CharSort(string data)
        {
            this.data = data;
        }

        internal void CLEANING_TEXT()
        {
            throw new NotImplementedException();
        }
    }
}

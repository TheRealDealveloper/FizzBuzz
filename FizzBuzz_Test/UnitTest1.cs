using Microsoft.VisualStudio.TestTools.UnitTesting;
using FizzBuzz;

namespace FizzBuzz_Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [DataRow(2)]
        [DataRow(5)]
        [DataRow(87)]
        public void Converting_A_Number_Not_Divisible_By_3_or_5_Returns_That_Number(int number)
        {
            Assert.AreEqual(Program.Convert(number), number.ToString()) ;
        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using FizzBuzz;

namespace FizzBuzz_Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Converting_A_Number_Not_Divisible_By_3_or_5_Returns_That_Number()
        {
            Assert.AreEqual(Program.Convert(1), "1") ;
        }
    }
}

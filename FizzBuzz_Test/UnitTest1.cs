using Microsoft.VisualStudio.TestTools.UnitTesting;
using FizzBuzz;

namespace FizzBuzz_Test
{
    [TestClass]
    public class UnitTest1
    {
        [DataTestMethod]
        [DataRow(1)]
        [DataRow(2)]
        [DataRow(4)]
        [DataRow(8)]
        [DataRow(71)]
        public void Converting_A_Number_Not_Divisible_By_3_or_5_Returns_That_Number(int number)
        {
            Assert.AreEqual(Program.Convert(number), number.ToString()) ;
        }

        [DataTestMethod]
        [DataRow(3)]
        [DataRow(6)]
        public void Converting_A_Number_Only_Divisible_By_3_But_Not_By_5_Returns_Fizz(int number)
        {
            Assert.AreEqual(
                Program.Convert(number), "Fizz"
            );
        }
    }
}

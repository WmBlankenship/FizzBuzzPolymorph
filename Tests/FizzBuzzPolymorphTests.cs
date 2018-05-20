using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzzPolymorph.Tests
{
    [TestClass]
    public class FizzBuzzPolymorphTests
    {
        [TestMethod]
        [DataRow(3), DataRow(6), DataRow(12), DataRow(18)]
        public void FuzzBuzz_Given_Number_Divisible_By_Three_Should_Return_Fizz(int number)
        {
            var output = Program.GetNumber(number).ToString();
            Assert.AreEqual("Fizz", output);
        }

        [TestMethod]
        [DataRow(5), DataRow(10), DataRow(20), DataRow(25)]
        public void FuzzBuzz_Given_Number_Divisible_By_Five_Should_Return_Buzz(int number)
        {
            var output = Program.GetNumber(number).ToString();
            Assert.AreEqual("Buzz", output);
        }

        [TestMethod]
        [DataRow(15), DataRow(30), DataRow(45), DataRow(60)]
        public void FuzzBuzz_Given_Number_Divisible_By_Three_And_Five_Should_Return_FizzBuzz(int number)
        {
            var output = Program.GetNumber(number).ToString();
            Assert.AreEqual("FizzBuzz", output);
        }

        [TestMethod]
        [DataRow(2), DataRow(8), DataRow(13), DataRow(59)]
        public void FuzzBuzz_Given_Number_Divisible_By_Neither_Three_Nor_Five_Should_Return_Number(int number)
        {
            var output = Program.GetNumber(number).ToString();
            Assert.AreEqual(number.ToString(), output);
        }
    }
}
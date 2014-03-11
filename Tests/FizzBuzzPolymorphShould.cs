using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace FizzBuzzPolymorph
{
    [TestFixture]
    public class FizzBuzzPolymorphShould
    {
        [Test]
        public void ReturnFizzIfNumberIsDivisibleByThreeButNotFive()
        {
            var three = FizzBuzzPolymorph.Program.GetNumber(3);
            Assert.AreEqual("Fizz", three.ToString());
        }

        [Test]
        public void ReturnBuzzIfNumberIsDivisibleByFiveButNotThree()
        {
            var five = FizzBuzzPolymorph.Program.GetNumber(5);
            Assert.AreEqual("Buzz", five.ToString());
        }

        [Test]
        public void ReturnFizzBuzzIfNumberIsDivisibleByThreeAndFive()
        {
            var fifteen = FizzBuzzPolymorph.Program.GetNumber(15);
            Assert.AreEqual("FizzBuzz", fifteen.ToString());
        }

        [Test]
        public void ReturnInputIntAsStringIfNumberIsDivisibleByNeitherThreeNorFive()
        {
            var seven = FizzBuzzPolymorph.Program.GetNumber(7);
            Assert.AreEqual("7", seven.ToString());
        }
    }
}

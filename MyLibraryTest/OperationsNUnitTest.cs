using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    [TestFixture]
    public class OperationsNUnitTest { 
        [Test]
        public void Add_InputNumbers_ReturnNumber()
    {
            //1. Arrange
            // Operations operations = new Operations();
            //Operations operations = new();
            var operations = new Operations();
            int num1 = 5;
            int num2 = 2;
            int expectedResult = 7;
            //2. Act
            int result = operations.Add(num1, num2);

            //3. Assert
            Assert.That(result, Is.EqualTo(expectedResult));
            Assert.That(result, Is.Not.EqualTo(8));
            Assert.That(result, Is.Not.EqualTo(6));


        }
        [Test]
        [TestCase(10)]
        [TestCase(11)]
        [TestCase(14)]
        public void IsEven_InPutNumber_ReturnTrue(int number)
        {
            //1. Arrange

            Operations operations = new Operations();
            var result= operations.IsEven(number); 
            Assert.That(result, Is.True);
        
        
        }
}

}

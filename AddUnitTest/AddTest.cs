using NUnit.Framework;
using AddConsole;

namespace AddUnitTest
{
    [TestFixture]
    public class AddTest
    { 
        
        [Test]
        [TestCase(2,1,3)]
        [TestCase(2, 4, 6)]
        public void Add_WhenCalled_ReturntheSum(int a,int b,int expected)
        {

            var result = Program.Add(a, b);
            
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}

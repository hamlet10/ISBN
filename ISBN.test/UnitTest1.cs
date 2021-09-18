/*

    (-)
    p1.DONE Input_Validator(null) -> ArgumentNullException
    p1.DONE Input_Validator(juana) -> ArgumentException
*/

using NUnit.Framework;
using ISBN;
namespace ISBN.test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Input_NUll_Validation()
        {
            Assert.That(() => ISBN.Input_Validator(null), Throws.ArgumentNullException);
        }

        [Test]
        public void Only_Numbers()
        {
            Assert.That(() => ISBN.Input_Validator("juana"), Throws.ArgumentException);
        }
        [Test]
        public void IBS10Test()
        {
            Assert.That(() => ISBN.ValidISBN10("true"), Is.EqualTo(true));
        }
    }
}
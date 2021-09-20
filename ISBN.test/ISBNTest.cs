/*
Reed
Green
Refactor

(-)
p1.DONE Input_Validator(null) -> ArgumentNullException 
p2.DONE InpuT_Validartor("") -> ArgumentException
p3.DONE Input_Validator("juana") -> ArgumentException

(+)
p4.DONE ISBN10To13("0716703440") -> true
p4. ISBN13To10("9780716703440") -> true

*/

using NUnit.Framework;
using ISBN;

namespace ISBN.Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Input_Validator_Null()
        {
            Assert.That(() => ISBN.Input_Validator(null), Throws.ArgumentNullException);
        }
        [Test]
        public void Input_Validator_Empty()
        {
            Assert.That(() => ISBN.Input_Validator(""), Throws.ArgumentNullException);
        }
        [Test]
        public void Input_Validator_InvalidInput()
        {
            Assert.That(() => ISBN.Input_Validator("juana"), Throws.ArgumentException);
        }
        [Test]
        public void ISBN10To13()
        {
            Assert.That(() => ISBN.ISBNO10To13("0716703440"), Is.EqualTo(true));
        }
        //ISBN13To10
        [Test]
        public void ISBN13To10()
        {
            Assert.That(() => ISBN.ISBNO13To10("9780716703440"), Is.EqualTo(true));
        }
    }
}
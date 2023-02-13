namespace ChellengeApp
{
    public class TypeTests
    {
        [Test]
        public void IntTests()
        {
            //arrange
            int number1 = 2;
            int number2 = 2;

            //act
            //assert
            Assert.AreEqual(number1, number2);
        }

        [Test]
        public void FloatTests()
        {
            //arrange
            float number1 = 50.65f;
            float number2 = 51.60f;

            //act
            //assert
            Assert.AreNotEqual(number1, number2);
        }
        [Test]
        public void CharTests()
        {
            //arrange
            char letter1 = 'M';
            char letter2 = 'F';

            //act
            //assert
            //Asse
            Assert.AreNotEqual(letter2, letter1);
        }

        [Test]
        public void StringTests()
        {
            //arrange
            string emp1 = "Adam";
            string emp2 = "Adam";

            //act
            //assert
            Assert.AreEqual(emp1, emp2);
        }


        ///[Test]
        ///public void GetUserShouldReturnDiffrentObject()
        ///{
        //arrange
        ///  var user1 = GetUser("Adam", "123456");
        ///  var user2 = GetUser("Adam", "123456");

        //act
        //assert
        /// Assert.AreNotEqual(user1, user2);
        ///}

        /// private User GetUser(string name, string password)
        ///  {
        ///      return new User(name, password);
        ///  }
    }
}

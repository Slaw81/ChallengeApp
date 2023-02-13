namespace ChellengeApp.Tests
{
    public class Employee2Tests
    {

        [Test]
        public void WhenLetterScorIsWriten_ShouldGetCorectResult()
        {
            //arrange
            var employee = new Employee2("Adam", "Zawada" , "33","m");

            employee.AddGrade(80);
            employee.AddGrade(80);

            //act
            var stats = employee.GetStats();
            //assert
            Assert.AreEqual(80, stats.Average);
            Assert.AreEqual('A', stats.AverageLetter);
 


        }
        //[Test]
        //public void WhenAverageUnknow_ShouldGetCorectResult()
        //{
        //    //arrange
        //    var employee = new Employee2("Adam", "Zawada", "33");

        //    employee.AddGrade(8);
        //    employee.AddGrade(12);
        //    employee.AddGrade(20);

        //    //act
        //    var stats = employee.GetStats();

        //    Assert.AreEqual(Math.Round(13.33, 2), Math.Round(stats.Average, 2));


        //}
    }
}

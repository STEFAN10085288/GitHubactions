using GitHubactions;
namespace testProject

{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Failedtest()
        {
            TestMe t1 = new TestMe("Jack", "yay", "1", "stefan");

            String expected = "My name is jack and i wrote this yay";
            string actual = t1.ToString();
            Assert.AreEqual(expected, actual);

        }


    }
}
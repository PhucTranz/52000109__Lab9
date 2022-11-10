using StudentService;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void StudentScore_Should_Success()
        {
            Student st = new Student();
            double status = st.Score = 10;
            Assert.AreEqual(status, st.Score);
        }

        [TestMethod]
        [ExpectedException(typeof(SystemException))]
        public void StudentScore_ShouldThrowException()
        {
            Student st = new Student();
            st.Score = 19;
        }

        [TestMethod]
        [ExpectedException(typeof(SystemException))]
        public void StudentScore_ShouldThrowException2()
        {
            Student st = new Student();
            st.Score = -19;
        }

        //
        [TestMethod]
        public void getLetterScores_ShouldReturnB()
        {
            Student st = new Student();
            st.Score = 7;
            char letter = st.getLetterScore();
            Assert.AreEqual(letter, 'B');
        }

    }
}
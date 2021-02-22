using NUnit.Framework;
using MoodAnalyserRepeat;
namespace MoodAnalyserNUnitTestProject
{
    public class Tests
    {
        MoodAnalyser moodAnalyser;
        [SetUp]
        public void Setup()
        {
            moodAnalyser = new MoodAnalyser();
        }
        /// <summary>
        /// TC1.1 Sad mood message should return sad message
        /// </summary>
        [Test]
        public void SadMoodShouldReturnSad()
        {
            string sadMessage = "I am in sad Mood";
            string expected="SAD";
            string actual = moodAnalyser.MoodAnalyserMethod(sadMessage);
            Assert.AreEqual(expected,actual);
        }
        /// <summary>
        /// TC1.2 I am any mood should return happy message
        /// </summary>
        [Test]
        public void AnyMoodShouldReturnHappy()
        {
            string anymoodMessage = "I am in any mood";
            string expected = "HAPPY";
            string actual = moodAnalyser.MoodAnalyserMethod(anymoodMessage);
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        /// Refactor TC1.1
        /// Paramerters constructor
        /// </summary>
        [Test]
        public void ConstructorInSadMoodShouldReturnSad()
        {
            moodAnalyser = new MoodAnalyser("I am in sad mood ");
            string expected = "SAD";
            string actual = moodAnalyser.MoodAnalyseConstructorMethod();
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Refactor TC1.2
        /// Paramerters constructor
        /// </summary>
        [Test]
        public void ConstructorInHappyMoodShouldReturnHappy()
        {
            moodAnalyser = new MoodAnalyser("I am in Happy mood ");
            string expected = "HAPPY";
            string actual = moodAnalyser.MoodAnalyseConstructorMethod();
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        /// TC 2.1 Null mood should return happy 
        /// Exception handling
        /// </summary>
         [Test]
        public void NullMoodShouldReturnHappy()
        {
            string inputMessage = null;
            string excepted = "HAPPY";
            string actual = moodAnalyser.MoodAnalyserMethod(inputMessage);
            Assert.AreEqual(excepted,actual);

        }
        /// <summary>
        /// TC 3.1 given null mood should throw mood analyser custome  exception 
        /// </summary>
        [Test]
        public void NullMoodShouldThrowException()
        { 
            try
            {
                moodAnalyser = new MoodAnalyser(null);
                string result = moodAnalyser.MoodAnalyseConstructorMethod();
            }
            catch(MoodAnalyserException exception)
            {
                Assert.AreEqual("mood should not null",exception.Message);
            }
        }
        /// <summary>
        /// TC 3.2 empty mood should throw custome exception
        /// </summary>
        [Test]
        public void EmptyMoodShouldThrowException()
        {
            try
            {
                moodAnalyser = new MoodAnalyser("");
                string result = moodAnalyser.MoodAnalyseConstructorMethod();
            }
            catch (MoodAnalyserException exception)
            {
                Assert.AreEqual("mood should not empty", exception.Message);
            }
        }
    }
}
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
    }
}
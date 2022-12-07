namespace PrintTool.UnitTests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void Splitter_NoArgs_EmptyString()
        {
            //Arrange
            var input = Array.Empty<string>();

            //Act
            var output = Splitter.Split(input);

            //Assert
            Assert.AreEqual(string.Empty, output);
        }

        [TestMethod]
        public void Splitter_OneArg_OneArg()
        {
            //Arrange
            var value = "one";
            var input = new string[] { value };

            //Act
            var output = Splitter.Split(input);

            //Assert
            Assert.AreEqual(value, output);
        }

        [TestMethod]
        public void Splitter_TwoArgs_TwoArgsCombinedWithComma()
        {
            //Arrange
            var value1 = "one";
            var value2 = "two";
            var input = new string[] { value1, value2 };

            //Act
            var output = Splitter.Split(input);

            //Assert
            Assert.AreEqual($"{value1}, {value2}", output);
        }
    }
}
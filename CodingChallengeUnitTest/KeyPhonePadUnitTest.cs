using CodingChallenge;

namespace CodingChallengeUnitTest
{
    public class KeyPhonePadUnitTest
    {
        [Fact]
        public void ReturnEResultOldPhonePad()
        {
            // Arrange
            string inputDigits = "33#";
            // Act
            List<string> expectedResult = ["E"];

            // Assert
            var result = EncodingUtility.OldPhonePad(inputDigits);
            Assert.Equal(expectedResult, result); // Check if the result is as expected.
        }
        [Fact]
        public void ReturnBResultOldPhonePad()
        {
            // Arrange
            string inputDigits = "227*#";
            // Act
            List<string> expectedResult = ["B"];

            // Assert
            var result = EncodingUtility.OldPhonePad(inputDigits);
            Assert.Equal(expectedResult, result); // Check if the result is as expected.
        }
        [Fact]
        public void ReturnHELLOResultOldPhonePad()
        {
            // Arrange
            string inputDigits = "4433555 555666#";
            // Act
            List<string> expectedResult = ["H","E","L","L","O"];

            // Assert
            var actualResult = EncodingUtility.OldPhonePad(inputDigits);
            Assert.Equal(expectedResult, actualResult); // Check if the result is as expected.
        }

        [Fact]
        public void ReturnTURINNGResultOldPhonePad()
        {
            // Arrange
            string inputDigits = "8 88777444666*664#";
            // Act
            List<string> expectedResult = ["T", "U", "R", "I", "N","N","G"];

            // Assert
            var actualResult = EncodingUtility.OldPhonePad(inputDigits);
            Assert.Equal(expectedResult, actualResult); // Check if the result is as expected.
        }

        [Fact]
        public void ReturnHELLOWORLDResultOldPhonePad()
        {
            // Arrange
            string inputDigits = "4433555 555666 96667775553";
            // Act
            List<string> expectedResult = ["H", "E", "L", "L", "O","W","O","R","L","D"];

            // Assert
            var actualResult = EncodingUtility.OldPhonePad(inputDigits);
            Assert.Equal(expectedResult, actualResult); // Check if the result is as expected.
        }
        [Fact]
        public void ReturnNotTrueResultOldPhonePad()
        {
            // Arrange
            string inputDigits = "222 2 22";
            // Act
            List<string> expectedResult = ["C"];

            // Assert
            var actualResult = EncodingUtility.OldPhonePad(inputDigits);
            Assert.NotEqual(expectedResult, actualResult); // Check if the result is as expected.
        }
        [Fact]
        public void ReturnCABResultOldPhonePad()
        {
            // Arrange
            string inputDigits = "222 2 22";
            // Act
            List<string> expectedResult = ["C","A","B"];

            // Assert
            var actualResult = EncodingUtility.OldPhonePad(inputDigits);
            Assert.Equal(expectedResult, actualResult); // Check if the result is as expected.
        }
    }
}
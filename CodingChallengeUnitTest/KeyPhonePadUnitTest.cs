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
            string expectedResult = "E";

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
            string expectedResult = "B";

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
            string expectedResult = "HELLO";

            // Assert
            var actualResult = EncodingUtility.OldPhonePad(inputDigits);
            Assert.Equal(expectedResult, actualResult); // Check if the result is as expected.
        }

        [Fact]
        public void ReturnTURINGResultOldPhonePad()
        {
            // Arrange
            string inputDigits = "8 88777444666*664#";
            // Act
            string expectedResult = "TURING";

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
            string expectedResult = "HELLOWORLD";

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
            string expectedResult = "C";

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
            string expectedResult = "CAB";

            // Assert
            var actualResult = EncodingUtility.OldPhonePad(inputDigits);
            Assert.Equal(expectedResult, actualResult); // Check if the result is as expected.
        }
    }
}
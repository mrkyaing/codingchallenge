# Program analysis,design,implement,unit test(s) and functional test(s) for OldPhoneKeypad type process
- An old phone keypad with alphabetical letters,a backspace key,and a send button to show the data to the UI.
- Charactor enconding for input to the related english alphabet .
# Functional requriement 
- Here is an old phone keypad with alphabetical letters, a backspace key, and a send button.
- Each button has a number to identify it and pressing a button multiple times will cycle through the letters on it allowing each button to represent more than one letter.
- For example, pressing 2 once will return ‘A’ but pressing twice in succession will return ‘B’.
- You must pause for a second in order to type two characters from the same button after each other: “222 2 22” -> “CAB”.
# Prompt:
- Screen design of Old Phone KeyPad UI Simple
- Assume that a send “#” will always be included at the end of every input.
 ![image](https://github.com/mrkyaing/codingchallenge/assets/9696016/36dcdeb4-7f2a-429f-a23e-185279db5a14)

# Code Implementation  
## Method 1 **OldPhonePad(string input)**
- This method do the encoding process from the inputed (digital numbers)  to string (english alphabet)
```
 public static String OldPhonePad(string input) {
 //get input from the user's keyboard
 //invoke to internal method for generate words
 }
```
- https://github.com/mrkyaing/codingchallenge/blob/main/EncodingUtility.cs
## Method 2 **OldPhonePad(string digits)**
- This method is encapsuleted and generate the alphabest from digits according to keypad dictionary value(s). 
```
private static List<string> GenerateWords(string digits){
//DO WORD GENERATE PROCESS 
}
```
- https://github.com/mrkyaing/codingchallenge/blob/main/EncodingUtility.cs
## Method 3 **ReplaceCharAtIndex(string input, int index, char newChar)**
- This method is encapsulated method for replacing the charactor for specific position and new charactor.
```
private  static string ReplaceCharAtIndex(string input, int index, char newChar){
    //DO REPLACE PROCESS 
}
```
- https://github.com/mrkyaing/codingchallenge/blob/main/EncodingUtility.cs
# Examples outpus:
- OldPhonePad(“33#”) => output: E
- OldPhonePad(“227*#”) => output: B
- OldPhonePad(“4433555 555666#”) => output: HELLO
- OldPhonePad(“8 88777444666*664#”) => output:TURINNG
- OldPhonePad(“888 85632*361*#”) => output:VTJMDDM
# Screen Result
![image](https://github.com/mrkyaing/codingchallenge/assets/9696016/7c22f108-dd2a-4d35-9285-39562d1e82ae)
# Unit Test Result by using xUnit 
- xUnit Test used for unit testing for generate digit(s) to english alphabet .
```
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
```
- https://github.com/mrkyaing/codingchallenge/blob/main/CodingChallengeUnitTest/KeyPhonePadUnitTest.cs
![image](https://github.com/mrkyaing/codingchallenge/assets/9696016/821f136b-e29c-4c0b-b3ed-8b760214637d)
# Software Requirement
- Framework :.Net Core 8.0
- Tools     :Visual Studio 2022 IDE or Visual Studio Code
- Language  : C#
- Main Program Run
![image](https://github.com/mrkyaing/codingchallenge/assets/9696016/b2eccf58-3222-4fdb-958f-4407b77b94d8)
- Unit Test Project run
![image](https://github.com/mrkyaing/codingchallenge/assets/9696016/2c92acab-af45-4e7f-989b-bc9c15dacf1d)
# How to Get Started with the OldPhonePad encoding from digits to english alphabet  as C# Library 
- If you can use this OldPhonePad(string input) in your project,you can reference this DLL(Dynamic Link Library) file in your project .
![image](https://github.com/mrkyaing/codingchallenge/assets/9696016/8cfba5be-06d2-4b7e-a0bc-4694e4ed32fd)
- And then by invoking  this static method EncodingUtility.OldPhonePad(yourInputs) .
- by importing the Library as using namespace
```
using CodingChallenge;
```
- by fully qualified namespaces 
```
CodingChallenge.EncodingUtility(yourInputs);
```
![image](https://github.com/mrkyaing/codingchallenge/assets/9696016/039d0e4f-3f9b-41c4-94d0-f0cbc0bbd000)








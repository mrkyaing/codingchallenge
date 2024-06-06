[[_TOC_]]
# Coding Challenge
Charactor enconding for input to the related english alphabet 
# Requriement 
- Here is an old phone keypad with alphabetical letters, a backspace key, and a send button.
Each button has a number to identify it and pressing a button multiple times will cycle through the letters on it allowing each button to represent more than one letter.
- For example, pressing 2 once will return ‘A’ but pressing twice
in succession will return ‘B’.
- You must pause for a second in order to type two characters from the same
button after each other: “222 2 22” -> “CAB”.
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
## Method 2 **OldPhonePad(string digits)**
- This method is encapsuleted and generate the alphabest from digits according to keypad dictionary value(s). 
```
private static List<string> GenerateWords(string digits){
//DO WORD GENERATE PROCESS 
}
```
## Method 3 **ReplaceCharAtIndex(string input, int index, char newChar)**
- This method is encapsulated method for replacing the charactor for specific position and new charactor.
```
private  static string ReplaceCharAtIndex(string input, int index, char newChar){
    //DO REPLACE PROCESS 
}
```
# Examples outpus:
- OldPhonePad(“33#”) => output: E
- OldPhonePad(“227*#”) => output: B
- OldPhonePad(“4433555 555666#”) => output: HELLO
- OldPhonePad(“8 88777444666*664#”) => output:TURINNG
- OldPhonePad(“888 85632*361*#”) => output:VTJMDDM
# Screen Result
- 

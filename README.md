# ArmenianTextToSpeech.dll
Provides Text to Speech functionality for Armenian language.<br />
The library uses .NET *System.Speech* library which does not provide text to speech functionality for Armenian language.

## Speech Class
*Namespace: ArmenianTextToSpeech* <br />
*Assembly: ArmenianTextToSpeech.dll* <br />
Provides access to the functionality of an text to speech engine for Armenian language.

### Constructors
#### ``` public Speech(); ```
Initializes a new instance of the Speech class.

### Methods
#### ``` Speech.Speak(string word); ```
Speaks the given Armenian word with normal speed.

#### ``` Speech.Speak(string word, int speed); ```
Speaks the given Armenian word with the given speed.

### Example
1. This example speaks word "Արարատ" with speed = 0.
```
var word = "Արարատ";
var speech = new Speech();
speech.Speak(word);
```

2. This example speaks word "Արարատ" with speed = 4.
```
var word = "Արարատ";
var speed = 4;
var speech = new Speech();
speech.Speak(word, speed);
```

# Visualizer.exe
Visualizer Tool uses ArmenianTextToSpeech.dll library and provides simple UI to speak Armenian word.
![Untitled](https://user-images.githubusercontent.com/46923880/71436857-8bfc2280-2708-11ea-9ec6-b78c7fd8a463.jpg)

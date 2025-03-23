Importing this will create three Actions and three Commands in StreamerBot.

ADD LETTER
“!letter [USER VALUE]” will add the first letter of user value to the current word being generated. The word is stored in the non-persisted global variable  “spellingBee”. Once the letter is added it outputs the current value to the chat. You can disable this sub action if desired.

CLEAR WORD
“!clearWord” clears the word so a new one can be created.

WORD COMPLETE
“!wordComplete” will show the final word to the chat and clear the word to start a new one. Edit the sub actions here to send the value of the variable “word” to your TTS or whatever.

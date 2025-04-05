Importing this will create three Actions and three Commands in StreamerBot.

ADD LETTER
!letter [USER VALUE]: Anybody can do this. Will add the first letter of user value to the current word being generated. The word is stored in the non-persisted global variable  “spellingBee”. Once the letter is added it outputs the current value to the chat. You can disable this sub action if desired. You can edit the regex used in "additionIsValid" to allow or disallow certain characters. There are a few already built for you but you could use AI to generate a new regex for whatever rules you want to allow.

CLEAR WORD
!clearWord: Only mods can do this. Clears the word so a new one can be created.

WORD COMPLETE
!wordComplete: Only mods can do this. Will show the final word to the chat and clear the word to start a new one. Edit the sub actions here to send the value of the variable “word” to your TTS or whatever.

Importing this will create the action group "Zaygnor Chat to OBS" and it's commands in Streamer.bot



CREATE THESE PERSISTENT GLOBAL VARIABLES
You must create the three following global persistent variables in Streamer.bot for this to work. Do not skip this step!!!

1) ZaygnorChatToObsBackgroundImageLocation - This is a path, including the file name, of the image that will be created to use as the background of the Stream Deck button. ex. C:\test\ChatHistoryBackground.png

2) ZaygnorChatToObsMaxLinesInfile - This is the maximum number of lines to keep in the text file of the chat log. Set this number to be big enough depending on the activity of your chat. Smaller is better though. Performance theoretically be fine with numbers up to at least 1000 but I doubt you will want to scroll through that much chat history anyway.

3) ZaygnorChatToObsTextFile - This is a path, including the file name, of a .txt file to store a copy of the chat messages in so we can review them when needed.



CLEAR CHAT MESSAGE
This clears the stored line number for the chat. Useful if you started searching for a line but gave up and want to reset so you can start again from the end of the file.



GET NEXT CHAT MESSAGE
Gets the next line of chat history. If there is no current line, gets the last line.



GET PREVIOUS CHAT MESSAGE
Gets the previous line of chat history. If there is no current line, gets the last line.



LOG CHAT MESSAGE
Logs chat messages to the file.



SEND LINE TO OBS
Takes the selected line of chat and sets a "GDI text" source in OBS to have the same value. Also calls the trim text file action.



TRIM TEXT FILE
Deletes lines from the beginning of the file to reduce it to the max lines value. This should keep the file from getting so long that scanning it takes noticeable amounts of time.
using System;
using System.Collections.Generic;

public class CPHInline
{
    public bool Execute()
    {
    	// Written by Zaygnor: 2025-04-01
    	// This script will show one from a list of sources in OBS. It automatically hides all others so only one shows at a time.
    	// You can choose either random or sequential. The script is currently configrued for random. Check line 29 to change.
    	// Edit the list just below these instructions to have all the sources you want in the rotation.
    	// In StreamerBot place this scrit in a [Core > C# > Execute C# Code] sub action.
    	// You can use whatever trigger you want. I use a button on my Steam Deck, but you could do anything, like a chat command, etc.
    	
    	
        // this is a list of all your elements that you want to randomize/loop through.
        // scene name - source name
        List<KeyValuePair<string, string>> elementList = new List<KeyValuePair<string, string>>
        {
            new KeyValuePair<string, string>("My Scene", "Happy"),
            new KeyValuePair<string, string>("My Scene", "Confused"),
            new KeyValuePair<string, string>("My Scene", "Sad"),
            new KeyValuePair<string, string>("My Scene", "Hurry")
        };
        // hide everything
        hideAll(elementList);
        // set this to "true" if you want to show a random element
        // set this to "false" if you want to show them in sequence
        if (true)
        {
        	showRandom(elementList);
        }
        else
        {
        	showNext(elementList);
        }

        return true;
    }

    public void hideAll(List<KeyValuePair<string, string>> elementList)
    {
        foreach (var item in elementList)
        {
            CPH.ObsSetSourceVisibilityState(item.Key, item.Value, 1);
        }
    }

    public void showRandom(List<KeyValuePair<string, string>> elementList)
    {
            // show random entry from list
            Random rnd = new Random();
            int toShow = rnd.Next(0, elementList.Count);
            CPH.SetGlobalVar("ZaygnorElementCycleIndex", toShow, false);
            CPH.ObsSetSourceVisibilityState(elementList[toShow].Key, elementList[toShow].Value, 2);
    }

    public void showNext(List<KeyValuePair<string, string>> elementList)
    {
            int toShow = CPH.GetGlobalVar<int>("ZaygnorElementCycleIndex", false);
            toShow += 1;
            if (toShow >= elementList.Count)
            {
                toShow = 0;
            }

            CPH.SetGlobalVar("ZaygnorElementCycleIndex", toShow, false);
            CPH.ObsSetSourceVisibilityState(elementList[toShow].Key, elementList[toShow].Value, 2);
    }
}
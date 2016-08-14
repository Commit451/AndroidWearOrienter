using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class AndroidWearOrienter : MonoBehaviour {

    private static List<string> BLACKLIST = new List<string>() { "Motorola Moto 360" };
	
	void Start () {
        if (BLACKLIST.Contains(SystemInfo.deviceModel)) {
            Screen.orientation = ScreenOrientation.LandscapeLeft;
        }
        else {
            Screen.orientation = ScreenOrientation.Portrait;
        }
        
    }
}

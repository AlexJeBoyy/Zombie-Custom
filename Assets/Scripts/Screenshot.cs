using UnityEngine;
using System;
using UnityEditor;
using System.Collections.Generic;
using System.IO;

public class Screenshot : MonoBehaviour
{
    
    public void TakeScreen()
    {
        ScreenCapture.CaptureScreenshot(Application.dataPath + "/Screenshots/" + "Screenshot-" + DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss")+".png", 2);
        //AssetDatabase.Refresh();
    }
}

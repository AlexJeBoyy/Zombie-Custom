using UnityEngine;
using System;
using UnityEngine.SceneManagement;
public class Screenshot : MonoBehaviour
{
    
    public void TakeScreen()
    {
        ScreenCapture.CaptureScreenshot(Application.dataPath + "/screenshots/" + "Screenshot-" + DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss")+".png", 2);
        UnityEditor.AssetDatabase.Refresh();
    }
}

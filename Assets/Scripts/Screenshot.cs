using UnityEngine;
using System;
using UnityEditor;
using System.Collections;
using System.Collections.Generic;
using System.IO;

public class Screenshot : MonoBehaviour
{
    public GameObject UI;
    private IEnumerator ScreenShot()
    {
        yield return new WaitForEndOfFrame();
        Texture2D texture = new Texture2D(Screen.width, Screen.height, TextureFormat.RGB24, false);
        
        texture.ReadPixels(new Rect(0,0,Screen.width,Screen.height),0,0);
        texture.Apply();

        string name = "Screenshot-" + DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss") + ".png";
        
        string path = Path.Combine(Application.dataPath, "Screenshots");

        if (!Directory.Exists(path))
        {
            Directory.CreateDirectory(path);
        }
        
        //pc
        byte[] bytes = texture.EncodeToPNG();
        //File.WriteAllBytes(Path.Combine(path, name), bytes);
        //File.WriteAllBytes(Application.dataPath + path + name, bytes);
        File.WriteAllBytes(Path.Combine(path, name), bytes);
        Destroy(texture);
        Vector2 endPos = new Vector2(0,0);
        UI.transform.position = endPos;

        Debug.Log("Screenshot saved to: " + Path.Combine(path, name));
    }
    
    public void TakeScreen()
    {
        
        Vector2 startPos = new Vector2(10, 10);
        UI.transform.position = startPos;
        StartCoroutine("ScreenShot");
        
    }
}

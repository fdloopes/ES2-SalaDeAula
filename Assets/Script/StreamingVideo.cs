using UnityEngine;
using System.Collections;

public class ExampleClass : MonoBehaviour
{
    public string filePath = System.IO.Path.Combine(Application.streamingAssetsPath, "https://www.youtube.com/watch?v=Ee1ZDX9dMbM");
    public string result = "";
    IEnumerator Example()
    {
        if (filePath.Contains("://"))
        {
            WWW www = new WWW(filePath);
            yield return www;
            result = www.text;
        }
        else
            result = System.IO.File.ReadAllText(filePath);
    }
}
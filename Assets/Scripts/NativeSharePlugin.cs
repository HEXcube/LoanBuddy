using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NativeSharePlugin : MonoBehaviour
{
    // https://github.com/yasirkula/UnityNativeShare
    public static void ShowShareURLMenu(string URL)
    {
        // Share a URL
        new NativeShare().SetText(URL).Share();
    }
}

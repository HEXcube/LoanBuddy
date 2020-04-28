using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using pingak9;

public class NativeDialogPlugin : MonoBehaviour
{
    // https://github.com/PingAK9/Mobile-Dialog-Unity
    public static void ShowQuitDialog()
    {
        NativeDialog.OpenDialog("Are you sure to quit?", null, "Yes", "No",
            () =>
            {
                Debug.Log("Quit - Yes button pressed");
                Application.Quit();

            },
            () =>
            {
                Debug.Log("Quit - No button pressed");
            });
    }
}

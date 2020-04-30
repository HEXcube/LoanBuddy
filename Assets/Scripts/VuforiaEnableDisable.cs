using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

/*
    Enable and disable Vuforia
    https://forum.unity.com/threads/vuforia-initialization-and-deinitialization.514794/#post-3956611
*/
public class VuforiaEnableDisable : MonoBehaviour
{
    public static void EnableVuforia()
    {
        VuforiaBehaviour.Instance.enabled = true;
    }

    public static void DisableVuforia()
    {
        VuforiaBehaviour.Instance.enabled = false;
    }
}

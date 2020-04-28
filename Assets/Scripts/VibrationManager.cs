using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VibrationManager : MonoBehaviour
{
    public int inputTime = 40;
    public bool vibrationEnabled = true;

    public void ToggleVibration()
    {
        if (vibrationEnabled)
            vibrationEnabled = false;
        else vibrationEnabled = true;
    }

    public void ActivateVibration()
    {
        vibrationEnabled = true;
    }

    public void DeActivateVibration()
    {
        vibrationEnabled = false;
    }

    public void VibrateCustom()
    {
        if (vibrationEnabled)
            Vibration.Vibrate(inputTime);
    }
}

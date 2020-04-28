using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
    How to Detect Mouse Click or Touch on a GameObject
    https://www.youtube.com/watch?v=0sFrDJKwsdM
*/

public class HandleTouchOnObject : MonoBehaviour
{
    public GameObject PanelToHide;
    public GameObject PanelToShow;
    public AudioManager AudioManagerObject;
    public VibrationManager VibrationManagerObject;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                // https://answers.unity.com/questions/1153357/how-to-get-the-gameobject-a-script-is-attached-to.html
                if (hit.transform.name == gameObject.name)
                {
                    AudioManagerObject.PlayButtonTouchSound();
                    VibrationManagerObject.VibrateCustom();

                    // Switch screen
                    PanelToHide.SetActive(false);
                    PanelToShow.SetActive(true);
                }
            }
        }
    }
}

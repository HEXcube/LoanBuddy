using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
    Scrolling Background | Unity Tutorial | Beginners
    https://www.youtube.com/watch?v=32EIYs6Z18Q
*/

public class ScrollingBackground : MonoBehaviour {

    public float bgSpeed;
    public Renderer bgRend;

	// Update is called once per frame
	void Update ()
    {
        bgRend.material.mainTextureOffset += new Vector2(bgSpeed * Time.deltaTime, 0f);
    }
}

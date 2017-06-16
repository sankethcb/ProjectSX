using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScaleUI : MonoBehaviour {

    float targetAR;
    float windowAR;
    float scaleHeight;

	void Start ()
    {
        targetAR = 9.0f / 16.0f;
        windowAR = (float)Screen.width / Screen.height;
        scaleHeight = windowAR / targetAR;
        gameObject.GetComponent<CanvasScaler>().scaleFactor = scaleHeight;

	}
	
	
}

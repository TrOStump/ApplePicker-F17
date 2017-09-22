using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apple : MonoBehaviour {

    public static float bottomY = -20f;
	
	void Update () {
        if (transform.position.y < bottomY)
        {
            Destroy(this.gameObject);

            //get reference to the apple picker component of Main camera
            ApplePicker apScript = Camera.main.GetComponent<ApplePicker>();
            // call the public AppleDestroyed() method of apScript
            apScript.AppleDestroyed();
        }
	}
}

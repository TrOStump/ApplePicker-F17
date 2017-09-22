using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApplePicker : MonoBehaviour {

    public GameObject basketPrefab;
    public int numBaskets = 3;
    public float basketBottomY = -14f;
    public float basketSpacingY = 2f;
	// Update is called once per frame
	void Start() {
        for (int i = 0; i < numBaskets; i++)
        {
            GameObject tBasketGo = Instantiate(basketPrefab) as GameObject;
            Vector3 pos = Vector3.zero;
            pos.y = basketBottomY + (basketSpacingY * i);
            tBasketGo.transform.position = pos;
        }
	}
    void Update()
    {
        //get the current screen position of the mouse from input
        Vector3 mousePos2D = Input.mousePosition;
        // the Camera's z position sets how far to push the mouse into 3d
        mousePos2D.z = -Camera.main.transform.position.z;
        // Convert the point from 2D screen space into 3d game world space
        Vector3 mousePos3D = Camera.main.ScreenToWorldPoint(mousePos2D);
        //move the x position of the basket to the x position of the mouse
        Vector3 posi = this.transform.position;
        posi.x = mousePos3D.x;
        this.transform.position = posi;
    }
    
}

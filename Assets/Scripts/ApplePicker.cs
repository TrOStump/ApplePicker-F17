using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApplePicker : MonoBehaviour {

    public GameObject basketPrefab;
    public int numBaskets = 3;
    public float basketBottomY = -14f;
    public float basketSpacingY = 2f;
    public List<GameObject> basketList;
	// Update is called once per frame
	void Start() {
        basketList = new List<GameObject>();
        for (int i = 0; i < numBaskets; i++)
        {

            GameObject tBasketGo = Instantiate(basketPrefab) as GameObject;
            Vector3 pos = Vector3.zero;
            pos.y = basketBottomY + (basketSpacingY * i);
            tBasketGo.transform.position = pos;
            basketList.Add(tBasketGo);
        }
	}
    public void AppleDestroyed()
    {
        ////Destroy all of the falling apples
        GameObject[] tAppleArray = GameObject.FindGameObjectsWithTag("Apple");
        foreach (GameObject tGO in tAppleArray)
        {
            Destroy(tGO);
        }
        ////Destroy one of the basket
        //Get the index of the last basket in basketList
        int basketIndex = basketList.Count - 1;
        //get a reference to that Basket GameObject
        GameObject tBasketGO = basketList[basketIndex];
        // Remove the Basket from the List and destroy the GameObject
        basketList.RemoveAt(basketIndex);
        Destroy(tBasketGO);

        //restrart the game, which doesn't affect Highscore.score
        if (basketList.Count == 0)
        {
            Application.LoadLevel("kaboom");
        }
    }
    
    
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Basket : MonoBehaviour {
    public GUIText scoreGT;
    void Start()
    {
        //find a refference to ScoreCounter GameObject
        GameObject scoreGO = GameObject.Find("ScoreCounter");
        // get the GUIText Component of that GameObject
        scoreGT = scoreGO.GetComponent<GUIText>();
        //set the starting number to zero
        scoreGT.text = "0";
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
    void OnCollisionEnter(Collision coll)
    {
        //find out what hit the basket
        GameObject collidedwith = coll.gameObject;
        if (collidedwith.tag == "Apple")
        {
            Destroy(collidedwith);
        }
        //parse the text of ScoreGT into an int
        int score = int.Parse(scoreGT.text);
        //add points for catching an apple
        score += 100;
        //convert the score back to a string and display it
        scoreGT.text = score.ToString();
        //track the high score
        if (score > HighScore.score)
        {
            HighScore.score = score;
        }
    }


}

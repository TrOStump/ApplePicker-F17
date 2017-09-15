using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleTree : MonoBehaviour
{

    // prefabs for instantiating apples
    public GameObject applePrefab;

    //Speed at which the apple tree moves
    public float speed = 1f;

    //Distance where AppleTree turns around
    public float LeftAndRightEdge = 10f;

    //Chance that the AppleTree will change directions
    public float changeToChangeDirections = 0.1f;

    //Rate at which Apples will be instantiated
    public float secondBetweenAppleDrops = 1f;
    void Start()
    {
        Vector3 pos = transform.position;
        pos.x += speed * Time.deltaTime;
        transform.position = pos;
    }
    void Update()
    {
        Vector3 pos = transform.position;
        pos.x += speed * Time.deltaTime;
        transform.position = pos;
        if (pos.x < -LeftAndRightEdge)
        {
            speed = Mathf.Abs(speed); //move right
        }
        else if (pos.x > LeftAndRightEdge)
        {
            speed = -Mathf.Abs(speed); //move left

        }

    }
    void FixedUpdate()
    {
        if (Random.value < changeToChangeDirections)
        {
            speed *= -1;
        }
    }
}
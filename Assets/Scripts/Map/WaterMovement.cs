using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterMovement : MonoBehaviour
{
    private float yPos;
    public float waterSpeed = 0.3f;
    // Start is called before the first frame update
    void Start()
    {
        yPos = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
       // yPos += Time.deltaTime;
        //transform.position = new Vector3(transform.position.x, yPos * waterSpeed, transform.position.z);
    }
}

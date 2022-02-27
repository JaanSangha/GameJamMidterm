using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterTrigger : MonoBehaviour
{
    public GameObject waveController;
    // Start is called before the first frame update
    void Start()
    {
        waveController = GameObject.FindGameObjectWithTag("Water");
        waveController.GetComponent<WaterMovement>().StartRising();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        
    }
}

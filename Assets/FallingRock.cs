using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingRock : MonoBehaviour
{
    private Rigidbody Rockrb;
    public GameObject Rock;
    
    // Start is called before the first frame update
    void Start()
    {
        Rockrb = Rock.GetComponent<Rigidbody>();
        Rockrb.useGravity = false;
        //rb.isKinematic = true;
    }

    // Update is called once per frame
    void Update()
    {
        


    }

    private void OnTriggerEnter(Collider other)
    {
        Rockrb.useGravity = true;
        //rb.isKinematic = false;
    }
}

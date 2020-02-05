using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chai: MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody body;
    float rand;
    float rand2;
    float rand3;
    void Start()
    {
        this.transform. Rotate(0,0, -90, Space.Self);
        this.transform.localScale -= new Vector3(.7f, .7f, .7f);
        Debug.Log("test");
        body = GetComponent < Rigidbody >();
        body.AddForce(this.transform.up*20, ForceMode.Impulse);
        rand = Random.Range(-3, 3);
        rand2 = Random.Range(-3, 3);
        rand3 = Random.Range(-3, 3);
        body.AddTorque(rand, rand2, rand3, ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        if(this.transform.localScale != new Vector3(1, 1, 1))
        {
            this.transform.localScale += new Vector3(.05f, .05f, .05f);
        }
    }

    private void FixedUpdate()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pewPew : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform prefab;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(prefab, transform.position, transform.rotation);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cannon : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.R)) {
            this.transform.rotation = Quaternion.Euler(0, 90, 0);
        }
        if (Input.GetKey(KeyCode.UpArrow) && this.transform.rotation.z<.3)
            this.transform.RotateAround(new Vector3(this.transform.position.x+.05f, this.transform.position.y - .1f, this.transform.position.z), new Vector3(0, 0, 1), 20 * Time.deltaTime);
        if (Input.GetKey(KeyCode.DownArrow) && this.transform.rotation.z > -.1)
            this.transform.RotateAround(new Vector3(this.transform.position.x + .05f, this.transform.position.y-.1f, this.transform.position.z), new Vector3(0, 0, -1), 20 * Time.deltaTime);
        if (Input.GetKey(KeyCode.RightArrow) && this.transform.rotation.y < .1+.7071068)
            this.transform.RotateAround(new Vector3(this.transform.position.x + .05f, this.transform.position.y - .1f, this.transform.position.z), new Vector3(0, 1, 0), 20 * Time.deltaTime);
        if (Input.GetKey(KeyCode.LeftArrow) && this.transform.rotation.y > -.1 + .7071068)
            this.transform.RotateAround(new Vector3(this.transform.position.x + .05f, this.transform.position.y - .1f, this.transform.position.z), new Vector3(0, -1, 0), 20 * Time.deltaTime);
    }
}

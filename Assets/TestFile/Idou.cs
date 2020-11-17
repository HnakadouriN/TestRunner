using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Idou : MonoBehaviour
{
    public int count;
    // Start is called before the first frame update
    void Start()
    {
        count = 1;
    }

    // Update is called once per frame
    void Update()
    {
        this.gameObject.transform.position = this.transform.position + new Vector3(0, 0, 1);
        if(this.transform.position.z >= 100)
        {
            this.gameObject.transform.position = new Vector3(1,0,100);
        }
    }
}

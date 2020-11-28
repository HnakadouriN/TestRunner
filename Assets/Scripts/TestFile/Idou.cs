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
        //this.gameObject.transform.position = this.transform.position + new Vector3(0, 0, 0.1f);
        //if (this.transform.position.z >= 5)
        //{
        //    this.gameObject.transform.position = new Vector3(1, 0, 5);
        //}
    }
    Vector3 hoge()
    {
        return new Vector3(1, 1, 1);
    }

    public void ObjMove()
    {
        //this.gameObject.transform.position = this.transform.position + new Vector3(0, 0, 0.1f);
        //if (this.transform.position.z >= 5)
        //{
        //    this.gameObject.transform.position = new Vector3(1, 0, 5);
        //}
        this.gameObject.transform.position = new Vector3(1, 0, 5);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boundries : MonoBehaviour
{
    public float z1 = 600;
    public float z2 = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x, -10, transform.position.z);
        Vector3 pos = Camera.main.WorldToViewportPoint(transform.position);
        pos.x = Mathf.Clamp01(pos.x);
        transform.position = Camera.main.ViewportToWorldPoint(pos);
        if (transform.position.z > z1)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, z1);
        }
        if (transform.position.z < z2)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, z2);
        }
    }

}

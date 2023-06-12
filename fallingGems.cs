using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fallingGems : MonoBehaviour
{
    public float delay = 10f;
    public GameObject cube;
    GameObject cloneCube;
    public GameObject lights;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn", delay, delay);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Spawn()
    {
        // Vector2 randomPositionOnScreen = Camera.main.ViewportToWorldPoint(new Vector2(Random.value, Random.value));
        var ranx = Random.Range(50, 640);
        var ranz = Random.Range(50, 700);
        transform.position = new Vector3(ranx, 784, ranz);
        lights.transform.position = new Vector3(ranx, 800, ranz);
        cloneCube = Instantiate(cube, transform.position, transform.rotation);
        Rigidbody cloneCubeRB = cloneCube.GetComponent<Rigidbody>();
        cloneCubeRB.AddForce(Vector3.down * 10000);
        //check position cube position = gem position
       // if(cloneCube.GetComponent<Renderer>().enabled == false)
        //{
        //    cloneCube.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePositionY;
        //}
        Destroy(cloneCube, 10f);

    }
    void onCollisionEnter(Collision collision)
    {
        
    }


}

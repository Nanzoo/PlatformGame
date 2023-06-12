using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class colide : MonoBehaviour
{
    public Text ttt;
    int n;
    // Start is called before the first frame update
    void Start()
    {
        //ttt = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if(n>=10)
        {
            UnityEditor.EditorApplication.isPlaying = false;
            Application.Quit();
        }

    }

    void OnCollisionEnter(Collision collision)
    {
        n++;
        ttt.text = "Score: "+n;
        collision.gameObject.GetComponent<Renderer>().enabled = false;
        Destroy(collision.gameObject, 1.0f);
    }
}

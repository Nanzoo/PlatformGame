using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class particleKeeper : MonoBehaviour
{
    public ParticleSystem ps;
    // Start is called before the first frame update
    void Start()
    {
        ps = GetComponent<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void DetachParticles(ParticleSystem ps)
    {

    }
}

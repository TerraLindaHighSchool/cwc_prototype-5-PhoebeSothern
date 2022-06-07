using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CometTrail : MonoBehaviour
{
    public ParticleSystem cometTrail;
    // Start is called before the first frame update
    void Start()
    {
        cometTrail.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

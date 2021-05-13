using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rockect : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject explosion;
    void Start()
    {
        Destroy(gameObject,2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

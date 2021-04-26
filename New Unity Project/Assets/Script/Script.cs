using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody2D herobody;
    public float force = 100;
    void Start()
    {
        herobody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        //if
        herobody.AddForce(Vector2.right * h * force);
    }
}

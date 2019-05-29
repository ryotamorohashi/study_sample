using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    public float speed = 10;
    private float x;
    private float z;

    private Rigidbody rigidbody;
    
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = this.GetComponent<Rigidbody> ();
    }

    // Update is called once per frame
    void Update()
    {   
        x = Input.GetAxis("Horizontal");
        z = Input.GetAxis("Vertical");
        rigidbody.AddForce(x * speed, 0, z * speed, ForceMode.Acceleration);
    }
}

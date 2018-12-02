using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    public float speed;
    public GameObject LeftFist;

    void Start()
    {
        GetComponent<Rigidbody>().velocity = transform.up * speed;
    }
    void OntriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Bag")
        {
            Destroy(LeftFist);
        }
    }

    void Update()
    {

    }
}
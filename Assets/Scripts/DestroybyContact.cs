using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroybyContact : MonoBehaviour

{
        void OnTriggerEnter(Collider other)
        {
            if (other.tag == "Bag")
            Destroy(gameObject);
        GetComponent<AudioSource>().Play();
    }
}
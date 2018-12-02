using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public float enemyHP = 30;
    private GameController gameController;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Fist")
        {
            GetComponent<AudioSource>().Play();
    }

    }

}
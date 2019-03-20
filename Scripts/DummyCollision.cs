using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DummyCollision : MonoBehaviour {
    public float health = 100;

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "HitType1")
        {
            health -= 25;
        }
        if(collision.collider.tag == "HitType2")
        {
            health -= 50;
        }
    }

    private void Update()
    {
        if(health <= 0)
        {
            Destroy(gameObject);
        }
    }
}

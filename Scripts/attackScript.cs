using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attackScript : MonoBehaviour
{
    public CpuMovement movement;
    public Rigidbody rb;
    public Transform parent;
    public GameObject enemy;
    public bool attacking;

    // Start is called before the first frame update
    void Start()
    {
        movement = GetComponentInParent<CpuMovement>();
        rb = GetComponentInParent<Rigidbody>();
        parent = GetComponentInParent<Transform>();
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            Debug.Log("CompareTagAttack OK");
            attacking = true;
            
        } else
        {
            attacking = false;
        }
    }

    void Update()
    {
        int a = Random.Range(1, 3);
        if(attacking == true)
        {
            movement.RandomAttack(a);
            Debug.Log(a);
        }
    }
}

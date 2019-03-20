using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaseScript : MonoBehaviour
{

    public CpuMovement movement;
    public Rigidbody rb;
    public Transform parent;
    public GameObject enemy;

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
            Debug.Log("CompareTagChase OK");
            enemy.transform.LookAt(movement.player);
            movement.Chasing = true;
        } else
        {
            movement.Chasing = false;
        }
    }
}
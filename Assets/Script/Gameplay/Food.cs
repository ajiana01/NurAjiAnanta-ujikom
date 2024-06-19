using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : MonoBehaviour
{
    [SerializeField] private float SpeedFood =300;

    [SerializeField] public float HungerValue = 25;

    [SerializeField] private float LifeTime = 3;

    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Destroy(gameObject, LifeTime);
        Vector3 move = new Vector3(0, 0, SpeedFood);
        rb.velocity = transform.TransformDirection(move);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

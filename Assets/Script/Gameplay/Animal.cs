using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Animal : MonoBehaviour
{
    [SerializeField] private float Speed, hungerNeed, score;
    [SerializeField] private Slider _slider;
    private float _currentHunger;
    private Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        /*_slider.minValue = 0;
        _slider.maxValue = hungerNeed;*/
        _currentHunger = 0;
        
    }

    // Update is called once per frame
    void Update()
    {
        //_slider.value = _currentHunger;
        DeathCondition();
        Move();
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.collider.CompareTag("Food"))
        {
            _currentHunger += 25;
        }

        if (other.collider.CompareTag("Destroy"))
        {
            Destroy(gameObject);
        }
    }

    void DeathCondition()
    {
        if (_currentHunger >= hungerNeed)
        {
            Destroy(gameObject);
        }
    }

    void Move()
    {
        Vector3 move = new Vector3(0, 0, -Speed);
        rb.velocity = transform.TransformDirection(move);
    }
}

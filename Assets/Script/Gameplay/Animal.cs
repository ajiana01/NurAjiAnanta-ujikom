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
    [SerializeField] private GameObject vfxDeath;
    [SerializeField] private AudioSource _audioSource;
    [SerializeField] private AudioClip[] _audioClip;
    private UIGameplay _uiGameplay;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        /*_slider.minValue = 0;
        _slider.maxValue = hungerNeed;*/
        _currentHunger = 0;
        Destroy(gameObject, 20f);
        _uiGameplay = FindAnyObjectByType<UIGameplay>();
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
            _audioSource.clip = _audioClip[0];
            _audioSource.Play();
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
            _audioSource.clip = _audioClip[1];
            _audioSource.Play();
            Vector3 currentPos = new Vector3(transform.position.x, transform.position.y, transform.position.z);
            Instantiate(vfxDeath, currentPos, Quaternion.identity);
            Destroy(gameObject);
            _uiGameplay.AddScore(score);
        }
    }

    void Move()
    {
        Vector3 move = new Vector3(0, 0, Speed);
        rb.velocity = transform.TransformDirection(move);
    }
}

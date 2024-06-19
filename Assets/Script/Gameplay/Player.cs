using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private Animator _animator;

    [SerializeField] private CharacterController _characterController;

    [SerializeField] private float playerSpeed = 30f;

    [SerializeField] private GameObject foodPrefab;

    [SerializeField] private Transform foodShoot;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        MovementPlayer();
        ShootFood();
    }

    void MovementPlayer()
    {
        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, 0);
        _characterController.Move(move * playerSpeed);
        if (move.x > 0)
        {
            _animator.SetBool("Right", true);
            _animator.SetBool("Left", false);
            _animator.SetBool("Shoot", false);
        }
        if (move.x < 0)
        {
            _animator.SetBool("Left", true);
            _animator.SetBool("Right", false);
            _animator.SetBool("Shoot", false);
        }
        if (move.x ==0)
        {
            _animator.SetBool("Left", false);
            _animator.SetBool("Right", false);
            _animator.SetBool("Shoot", false);
            _animator.SetBool("Idle", true);
        }
    }

    void ShootFood()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.Mouse0))
        {
            Instantiate(foodPrefab, foodShoot);
        }
    }
}

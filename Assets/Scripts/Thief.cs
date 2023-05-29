using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent (typeof(Animator))]
public class Thief : MonoBehaviour
{
    private readonly string MovingBool = "IsMoving";
    private Rigidbody2D _rigidbody;
    private Animator _animator;
    private float _speed = 5f;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        _animator = GetComponent<Animator>();
    }

    private void Update()
    {
        _rigidbody.WakeUp();

        if(Input.GetKey(KeyCode.D))
        {
            transform.Translate(_speed * Time.deltaTime, 0, 0);
            _animator.SetBool(MovingBool, true);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-_speed * Time.deltaTime, 0, 0);
            _animator.SetBool(MovingBool, true);
        }
        else
        {
            _animator.SetBool(MovingBool, false);
        }
    }
}

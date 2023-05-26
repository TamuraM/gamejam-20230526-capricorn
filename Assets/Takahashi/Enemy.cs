using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    Rigidbody2D _rb;
    Animator _anim;
    SpriteRenderer _sr;
    [SerializeField] float _speed;
    float _dir = 1;
    [SerializeField] Transform[] _returnPos;
    [SerializeField] EnemyJump _enemyJump;
    public bool _jump = false;
    [SerializeField] float _jumppower;
    [SerializeField] float _cooltime;
    float _isgraundtimer = 0;
    float _moveAnim;
    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        _anim = GetComponent<Animator>();
        _sr = GetComponent<SpriteRenderer>();
        _sr.flipX = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > _returnPos[0].position.x)
        {
            _dir = -1;
            _sr.flipX = false;
        }
        else if (transform.position.x < _returnPos[1].position.x)
        {
            _dir = 1;
            _sr.flipX = true;
        }
        Debug.Log(_dir);

    }

    void FixedUpdate()
    {
        //_rb.AddForce(Vector3.right * _speed * _dir, ForceMode2D.Force);
        if (_enemyJump._isGround && _isgraundtimer > _cooltime)
        {
            _jump = true;
            _rb.velocity = Vector3.zero;
            _moveAnim = 0;
            _rb.AddForce(Vector3.up * _jumppower, ForceMode2D.Impulse);
            _isgraundtimer = 0;
        }
        else if (_enemyJump._isGround && !_jump)
        {
            _rb.velocity = Vector3.right * _dir * _speed;
            _isgraundtimer += Time.fixedDeltaTime;
            _moveAnim = 1;
        }

        Debug.Log(_isgraundtimer);

        _anim.SetFloat("Move",_moveAnim);
    }
}

using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float _movePower = 5f;
    [SerializeField] float _jumpPower = 15f;
    [SerializeField] int _airJumpNum = 1;
    Rigidbody2D _rb = default;
    float _horizontal;
    SpriteRenderer _renderer;
    public int _jump;
    int _airJump;
    Vector2 _jumpVect;
    bool _jumpVectUp = true;

    // Start is called before the first frame update
    void Start()
    {
        _airJump = _airJumpNum;
        _rb = GetComponent<Rigidbody2D>();
        _renderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (_jumpVectUp)
        {
            _jumpVect = new Vector2(0, 1).normalized;
        }
        _horizontal = Input.GetAxisRaw("Horizontal");
        if (_horizontal < 0)
        {
            _renderer.flipX = true;
        }
        else
        {
            _renderer.flipX = false;
        }
        _rb.AddForce(Vector2.right * _horizontal * _movePower, ForceMode2D.Force);
        if (Input.GetButtonDown("Jump") && _jump > 0)
        {
            _rb.AddForce(_jumpVect * _jumpPower, ForceMode2D.Impulse);
            _jump -= 1;
        }
        else if (Input.GetButtonDown("Jump") && _airJump > 0)
        {
            _rb.AddForce(_jumpVect * _jumpPower, ForceMode2D.Impulse);
            _airJump -= 1;
        }
    }

    public void SetDirection(Vector2 direction)
    {
        _jumpVect = direction;
    }

    public void JumpVectUp(bool vect)
    {
        _jumpVectUp = vect;
        _airJump = 1;
    }
}

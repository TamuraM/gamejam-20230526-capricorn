using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameClear : MonoBehaviour
{
    [SerializeField] GameObject _clearText = default;
    [SerializeField] GameObject _notEnoughText;
    [SerializeField] CoinCounter _coinCounter;
    [SerializeField] int _clearNumOfCoin;
    // Start is called before the first frame update
    void Start()
    {
        _clearText.SetActive(false);
        _notEnoughText.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player" )
        {
            if (_coinCounter.Count >= _clearNumOfCoin)
            {
                _clearText.SetActive(true);
            }
            else
            {
                _notEnoughText.SetActive(true);
            }
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            _notEnoughText.SetActive(false);
        }
    }
}

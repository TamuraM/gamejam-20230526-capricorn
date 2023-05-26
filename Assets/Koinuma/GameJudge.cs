using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameJudge : MonoBehaviour
{
    [SerializeField] GameObject _clearText = default;
    [SerializeField] GameObject _gameOverText;
    [SerializeField] GameObject _notEnoughText;
    [SerializeField] GameObject _retryButton;
    [SerializeField] CoinCounter _coinCounter;
    [SerializeField] PlayerController _playerController;
    [SerializeField] int _clearNumOfCoin;
    // Start is called before the first frame update
    void Start()
    {
        _clearText.SetActive(false);
        _gameOverText.SetActive(false);
        _notEnoughText.SetActive(false);
        _retryButton.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (_playerController.Hp == 0)
        {
            _gameOverText.SetActive(true);
            _retryButton.SetActive(true);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player" )
        {
            if (_coinCounter.Count >= _clearNumOfCoin)
            {
                _clearText.SetActive(true);
                _retryButton.SetActive(true);
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

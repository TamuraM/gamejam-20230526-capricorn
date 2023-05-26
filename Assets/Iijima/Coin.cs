using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    AudioSource audioSource;
    [SerializeField] AudioClip a;
    CoinCounter _coinCounter;

    private void Start()
    {
        audioSource = FindObjectOfType<AudioSource>();
        _coinCounter = FindObjectOfType<CoinCounter>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        _coinCounter.CoinCount();
        audioSource.PlayOneShot(a);
        Destroy(gameObject);
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    AudioSource audioSource;
    [SerializeField] AudioClip a;

    private void Start()
    {
        audioSource = FindObjectOfType<AudioSource>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        audioSource.PlayOneShot(a);
        Destroy(gameObject);
    }

}

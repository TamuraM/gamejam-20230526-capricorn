using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SoundManeger : MonoBehaviour
{
    [SerializeField] private Transform _player = default;
    private AudioSource audioSource = default;
    [SerializeField] private float _scale = 0.01f;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }


    private void Update()
    {
        var distance = Mathf.Abs(_player.position.x - transform.position.x);
        audioSource.volume = 1.0f - distance * _scale;
    }
}

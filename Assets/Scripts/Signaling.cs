using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
[RequireComponent (typeof(ThiefInHouse))]

public class Signaling : MonoBehaviour
{
    private AudioSource _audioSource;
    private ThiefInHouse _thiefEnter;
    private float _volumeChange = 0.1f;
    private float _maxVolume = 1;
    private float _minVolume = 0;

    private void Start()
    {
        _audioSource = GetComponent<AudioSource>();
        _thiefEnter = GetComponent<ThiefInHouse>();
    }

    private void Update()
    {
        if(_audioSource.volume < _maxVolume && _thiefEnter.TellThiefInHouse())
        {
            _audioSource.volume = Mathf.MoveTowards(_audioSource.volume, _maxVolume, _volumeChange * Time.deltaTime);
        }
        else
        {
            _audioSource.volume = Mathf.MoveTowards(_audioSource.volume, _minVolume, _volumeChange * Time.deltaTime);
        }
    }
}

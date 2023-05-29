using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]

public class Signaling : MonoBehaviour
{
    private AudioSource _audioSource;
    private float _volumeChange = 0.1f;
    private float _maxVolume = 1;
    private float _minVolume = 0;
    private Coroutine _currenCoroutine;

    public void ActivateVolumeChanging(bool isThiefInHouse)
    {
        if (_currenCoroutine != null)
        {
            StopCoroutine(_currenCoroutine);
        }

        if (_audioSource.volume < _maxVolume && isThiefInHouse)
        {
            _currenCoroutine = StartCoroutine(ChangeVolume(_maxVolume));
        }
        else if (_audioSource.volume > _minVolume)
        {
            _currenCoroutine = StartCoroutine(ChangeVolume(_minVolume));
        }
    }

    private void Start()
    {
        _audioSource = GetComponent<AudioSource>();
    }

    private IEnumerator ChangeVolume(float volumeTargetValue)
    {
        while (_audioSource.volume != volumeTargetValue)
        {
            _audioSource.volume = Mathf.MoveTowards(_audioSource.volume, volumeTargetValue, _volumeChange * Time.deltaTime);
            yield return null;
        }
    }
}

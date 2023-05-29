using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Signaling))]

public class ThiefInHouse : MonoBehaviour
{
    private Signaling _signaling;
    private bool _isThiefInHouse = false;

    private void Start()
    {
        _signaling = GetComponent<Signaling>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        _isThiefInHouse = true;
        _signaling.ActivateVolumeChanging(_isThiefInHouse);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        _isThiefInHouse = false;
        _signaling.ActivateVolumeChanging(_isThiefInHouse);
    }
}

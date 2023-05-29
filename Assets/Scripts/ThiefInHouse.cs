using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThiefInHouse : MonoBehaviour
{
    private bool _isThiefInHouse = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        _isThiefInHouse = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        _isThiefInHouse = false;
    }

    public bool TellThiefInHouse()
    {
        return _isThiefInHouse;
    }
}

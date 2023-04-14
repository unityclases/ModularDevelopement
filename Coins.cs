using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coins : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        CoinsCounter player = other.GetComponent<CoinsCounter>();
        player.CollectCoins();
        Destroy(gameObject);
    }
}

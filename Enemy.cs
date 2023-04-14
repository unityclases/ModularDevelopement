using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 1;
    public Transform target;
    public int playerDamage = 2;

    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        transform.LookAt(target.position);
    }

    public void OnTriggerEnter(Collider other)
    {
        Health player = other.GetComponent<Health>();
        player.TakeDamage(playerDamage);
    }
}

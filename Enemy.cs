using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed;
    public Transform target;
    public int playerDamage = 2;
    
    private void OnTriggerEnter(Collider other)
    {
        player player = other.GetComponent<player>();
        player.TakeDamage(playerDamage);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, target.position, speed = Time.deltaTime);

        transform.LookAt(target.position);
    }
}

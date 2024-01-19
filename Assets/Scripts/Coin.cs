using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{

    public int value = 1;
    public GameManager gameManager;
    private ParticleSystem particles;
    private void Awake()
    {
        particles = GetComponent<ParticleSystem>();

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            gameManager.IncreasePoints(value);
            particles.Play();
            //Destroy(this.gameObject);
        }
    }
}

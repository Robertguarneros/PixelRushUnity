using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpMashroom : MonoBehaviour
{
    // Start is called before the first frame update
    
    public GameManager gameManager;
    private ParticleSystem particles;
    private void Awake()
    {
        particles = GetComponent<ParticleSystem>();

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {

            particles.Play();
           
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class megaman : MonoBehaviour
{
    public GameObject pixel;
    public GameObject bulletprefab;
    SpriteRenderer sprite;
    private Animator animator;
    private float cadencia = 0.0f;
    public AudioClip audioClip1; //disparo
    public AudioClip audioClip2; //muerte
    public AudioManager audioManager;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direccion = pixel.transform.position-transform.position;
        if (direccion.x >= 0f) { transform.localScale = new Vector3(1.0f, 1.0f,1.0f); }
        else { transform.localScale = new Vector3(-1.0f,1.0f,1.0f);}
        float rango = Mathf.Abs(pixel.transform.position.x - transform.position.x);
        
        if (rango < 5f && Time.time > cadencia + 1.5f)
        {
            
            animator.SetBool("disparar", true);
            Shoots();      
            cadencia = Time.time;
        }
        
        else
        {
            animator.SetBool("disparar", false);
        }

    }
    private void Shoots()
    {
        //audioManager.PlaySS(audioClip1);
        Vector3 direccion;
        if(transform.localScale.x == 1.0f) { direccion = Vector3.right; }
        else direccion= Vector3.left;

        GameObject bullet = Instantiate(bulletprefab, transform.position + direccion * 0.1f, Quaternion.identity);
        bullet.GetComponent<Bullet>().SetDirection(direccion);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            //audioManager.PlaySS(audioClip2);
            Destroy(this.gameObject);
        }
    }
}

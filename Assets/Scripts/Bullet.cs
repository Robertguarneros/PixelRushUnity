using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private Rigidbody2D Rigidbody2D;
    public float speed;
    private Vector2 direction;
    Transform spawnPoint;
    private GameObject DeadMenu;
    // Start is called before the first frame update
    void Start()
    {
        Rigidbody2D = GetComponent<Rigidbody2D>();
        Invoke("DestroyB", 2f);
    }

    // Update is called once per frame
    void Update()
    {
        Rigidbody2D.velocity = direction * speed;
    }
    public void SetDirection(Vector2 direction)
    {
       this.direction = direction;
    }
    public void DestroyB()
    {
        Destroy(gameObject);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Time.timeScale = 0f;
            DeadMenu.SetActive(true);
        }
    }
}

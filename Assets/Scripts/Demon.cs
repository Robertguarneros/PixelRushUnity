using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Demon : MonoBehaviour
{
    public float velocity;
    private Rigidbody2D rigidBody;
    [SerializeField] Transform spawnPoint;
    [SerializeField] private GameObject DeadMenu;
    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rigidBody.velocity = new Vector2(velocity , rigidBody.velocity.y);
        
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

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Undead : MonoBehaviour
{
    public GameObject pixel;
    private Animator animator;
    public float velocidad;
    [SerializeField] Transform spawnPoint;
    [SerializeField] private GameObject DeadMenu;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 direccion = pixel.transform.position - transform.position;
        if (direccion.x >= 0f) { transform.localScale = new Vector2(1.0f, 1.0f); }
        else { transform.localScale = new Vector2(-1.0f, 1.0f); }
        float rango = Mathf.Abs(pixel.transform.position.x - transform.position.x);

        if (rango < 13f)
        {

            animator.SetBool("atack", true);
            pixel.GetComponent<DriveKart>().SetVelocity(5f);
            Vector2 nuevaPosicion = (Vector2)transform.position + direccion.normalized * Time.deltaTime;
            transform.position = new Vector3(nuevaPosicion.x, nuevaPosicion.y, transform.position.z);
        }
        else
        {
            animator.SetBool("atack", false);
        }
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

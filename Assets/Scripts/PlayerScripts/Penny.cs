using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Penny : MonoBehaviour
{
    private Rigidbody2D rb;
    [SerializeField] float angle = 22.5f;
    [SerializeField] float speed = 10f;
    private void Update()
    {
        
    }
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        float radians = angle * Mathf.Deg2Rad;
        Vector2 velocity = new Vector2(speed * Mathf.Cos(radians) * (transform.right.x > 0 ? 1 : -1), speed * Mathf.Sin(radians));
        rb.velocity = velocity;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            return;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            return;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bench : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private SpriteRenderer sprRend;
    [SerializeField] private Sprite b;

    private void Start()
    {
        sprRend = gameObject.GetComponent<SpriteRenderer>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Destroy(player);
            sprRend.sprite = b;
        }
    }
}

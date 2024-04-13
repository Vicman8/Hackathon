using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Penny : MonoBehaviour
{
    private float throwSpeed = 15;
    private void Update()
    {
        transform.position = new Vector2(transform.position.x + (throwSpeed * Time.deltaTime), (-Mathf.Pow(transform.position.x, 2))/7);   
    }
}

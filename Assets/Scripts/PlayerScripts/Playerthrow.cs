using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playerthrow : MonoBehaviour
{
    [SerializeField] private GameObject coinPrefab;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(coinPrefab, transform.position, Quaternion.identity);
        }
    }
}

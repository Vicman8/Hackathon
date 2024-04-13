using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class note : MonoBehaviour
{
    private void Update()
    {
        transform.position += new Vector3(0, .01f, 0);
        if (transform.position.y > 1)
        {
            Destroy(gameObject);
        }
    }
}

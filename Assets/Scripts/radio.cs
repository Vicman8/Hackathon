using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class radio : MonoBehaviour
{
    [SerializeField] private GameObject note1;
    [SerializeField] private GameObject note2;
    [SerializeField] private GameObject note3;

    private void Update()
    {
        int randNum = Random.Range(0, 100000);
        if (randNum < 300)
        {
            int randNote = Random.Range(1, 4);
            switch (randNote)
            {
                case 1:
                    Instantiate(note1, transform.position, Quaternion.identity);
                    break;
                case 2:
                    Instantiate(note2, transform.position, Quaternion.identity);
                    break;
                case 3:
                    Instantiate(note3, transform.position, Quaternion.identity);
                    break;
            }
        }
    }
}

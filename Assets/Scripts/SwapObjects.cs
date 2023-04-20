using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwapObjects : MonoBehaviour
{
    public GameObject sphere1;
    public GameObject sphere2;
    private bool isSphere1Selected = false;

    void SwapPositions()
    {
        Vector3 tempPosition = sphere1.transform.position;
        sphere1.transform.position = sphere2.transform.position;
        sphere2.transform.position = tempPosition;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == sphere1)
        {
            isSphere1Selected = true;
        }
        else if (other.gameObject == sphere2 && isSphere1Selected)
        {
            SwapPositions();
            isSphere1Selected = false;
        }
    }
}
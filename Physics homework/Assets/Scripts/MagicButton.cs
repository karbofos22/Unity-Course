using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagicButton : MonoBehaviour
{
    public GameObject car;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            car.SetActive(true);
            Debug.Log("Magic!");
        }
    }
}

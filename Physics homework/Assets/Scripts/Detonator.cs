using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Detonator : MonoBehaviour
{
    public GameObject bomb;
    public float power = 10f;
    public float radius = 5f;
    public float upForce = 1f;

    private void OnTriggerEnter(Collider other)
    {
        if (bomb.activeInHierarchy)
        {
            Debug.Log("Boom!");
            Detonate();
        }
    }
    void Detonate()
    {
        Vector3 explosionPos = bomb.transform.position;
        Collider[] colliders = Physics.OverlapSphere(explosionPos, radius);
        foreach (Collider hit in colliders)
        {
            Rigidbody brick = hit.GetComponent<Rigidbody>();
            if (brick != null)
            {
                brick.AddExplosionForce(power, explosionPos, radius, upForce, ForceMode.Impulse);
            }
        }
        bomb.SetActive(false);
    }
}

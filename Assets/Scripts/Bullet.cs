using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    float speed = 10;
    Vector3 direction;

    int damage = 20;
    public void SetDirection(Vector3 dir)
    {
        direction = dir;
    }

    void FixedUpdate()
    {
        transform.position += direction * speed * Time.deltaTime;
        speed += 1f;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            other.GetComponent<Animator>().SetTrigger("Death");
            other.GetComponent<PredatorNoVision>().enabled = false;
            Destroy(other.gameObject, 10);
        }
    }


    private void Start()
    {
        Destroy(gameObject, 10);
    }
}

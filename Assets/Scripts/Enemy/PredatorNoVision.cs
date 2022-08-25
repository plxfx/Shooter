using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PredatorNoVision : Enemy
{
    [SerializeField] int speed = 5;
    [SerializeField] int area = 10;
    [SerializeField] float cooldown = 1;
    float time;
    [SerializeField] GameObject bulletPrefab;
    [SerializeField] GameObject rifleStart;


    public override void Move()
    {


        //GetComponent<Rigidbody>().MovePosition(transform.forward * Time.deltaTime);
        GetComponent<Rigidbody>().MovePosition(transform.position + transform.forward * speed * Time.fixedDeltaTime);
        transform.LookAt(player.transform.position);
    }
    public override void Attack()
    {
        if (Vector3.Distance(player.transform.position, transform.position) < area)
        {
            transform.LookAt(player.transform);
            time += Time.deltaTime;
            if (time >= cooldown)
            {
               
            }
        }

    }



}

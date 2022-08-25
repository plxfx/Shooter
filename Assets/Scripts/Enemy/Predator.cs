using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Predator : Enemy
{

    [SerializeField] int area = 10;
    [SerializeField] float cooldown = 1;
    float time;
    [SerializeField] GameObject bulletPrefab;
    [SerializeField] GameObject rifleStart;

    public override void Attack()
    {
        if (Vector3.Distance(player.transform.position, transform.position) < area)
        {
            transform.LookAt(player.transform);
            time += Time.deltaTime;
            if (time >= cooldown)
            {
                GameObject buf = Instantiate(bulletPrefab);
                buf.GetComponent<Bullet>().SetDirection(transform.forward);
                buf.transform.position = rifleStart.transform.position;
                buf.transform.rotation = transform.rotation;
                time = 0;
            }
        }

    }



}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pistol : Gun
{

    protected override void OnShoot()
    {
        print("pistol");
        GameObject buf = Instantiate(bullet);
        buf.transform.position = rifleStart.transform.position;
        buf.transform.rotation = transform.rotation;
        buf.GetComponent<Bullet>().setDirection(transform.forward);
    }
 

    void Start()
    {
        cooldown = 0;
        auto = false;
    }

    // Update is called once per frame
   
}

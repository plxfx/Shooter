using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pistol : Gun
{



    protected override void OnShoot()
    {
        
        GameObject buf = Instantiate(bullet);
        buf.transform.position = rifleStart.transform.position;
        buf.transform.rotation = transform.rotation;
        buf.GetComponent<Bullet>().SetDirection(transform.forward);
    }
 

    void Start()
    {
        ammoCurrent = 10;
        ammoMax = 10;
        ammoAll = 30;

        cooldown = 0;
        auto = false;

        AmmoTextUpdate();
    }



    // Update is called once per frame
   
}

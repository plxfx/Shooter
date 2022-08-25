using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    [SerializeField] protected Transform rifleStart;
    [SerializeField] protected GameObject bullet;

    protected bool auto = false;
    protected float cooldown = 0;

    float timer = 0;

    private void Start()
    {
        print("start");
    }

    public void Shoot()
    {
        print("hello4");
        if (Input.GetMouseButtonDown(0) || auto)
        {
            if (timer > cooldown)
            {
                OnShoot();
                timer = 0;
                
            }
        }
    }
    protected virtual void OnShoot()
    {

    }

    

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
    }
}

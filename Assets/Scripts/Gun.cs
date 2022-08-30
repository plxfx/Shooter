using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Gun : MonoBehaviour
{
    [SerializeField] protected int ammoCurrent;
    [SerializeField] protected int ammoMax;
    [SerializeField] protected int ammoAll;
    [SerializeField] protected Text ammoText;




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
        if (Input.GetMouseButtonDown(0) || auto)
        {
            if (timer > cooldown)
            {
                if (ammoCurrent > 0)
                {
                    OnShoot();
                    timer = 0;
                    ammoCurrent--;
                    AmmoTextUpdate();
                }
                else
                {
                    GetComponent<AudioSource>().Play();
                }


            }
        }
    }
    protected virtual void OnShoot()
    {

    }

    public void AmmoTextUpdate()
    {
        ammoText.text = ammoCurrent + " / " + ammoAll;
    }

    void Update()
    {
        timer += Time.deltaTime;
    }
}

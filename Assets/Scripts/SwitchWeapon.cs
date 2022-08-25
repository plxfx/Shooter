using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchWeapon : MonoBehaviour
{
    [SerializeField] GameObject pistol;

    public enum Weapon { pistol, shotgun, rifle }

    public Weapon weapon = Weapon.pistol;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {

            switch (weapon)
            {
                case Weapon.pistol:
                    pistol.GetComponent<Gun>().Shoot();
                    break;
            }
        }
    }
}

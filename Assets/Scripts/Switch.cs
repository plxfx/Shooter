using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour
{
    int level = 1;

    [SerializeField] GameObject pistol;
    [SerializeField] GameObject shotgun;
    [SerializeField] GameObject rifle;

    public enum Weapon { pistol, shotgun, rifle}

    public Weapon weapon = Weapon.pistol;
    // Start is called before the first frame update
    void Start()
    {
        switch (level)
        {
            case 1:
                ChooseWeapon(Weapon.pistol);
                break;

            case 2:
                ChooseWeapon(Weapon.shotgun);
                break;

            case 3:
                ChooseWeapon(Weapon.rifle);
                break;

            default: 
                print("Для этого уровня не подготовлено оружие");
                break;
        }
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
                    print("hello2");
                    break;

                case Weapon.shotgun:
                    shotgun.GetComponent<Gun>().Shoot();
                    print("hello");
                    break;
                case Weapon.rifle:
                    rifle.GetComponent<Gun>().Shoot();
                    break;
                default:
                    break;
            }
        }



        if (Input.GetKeyDown(KeyCode.Alpha1)) 
        {
            weapon = Weapon.pistol;
            ChooseWeapon(weapon);
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            weapon = Weapon.shotgun;
            ChooseWeapon(weapon);
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            weapon = Weapon.rifle;
            ChooseWeapon(weapon);
        }
    }


    public void ChooseWeapon( Weapon weaponName)
    {
        switch (weaponName)
        {
            case Weapon.pistol:
                pistol.SetActive(true);
                shotgun.SetActive(false);
                rifle.SetActive(false);
                break;

            case Weapon.shotgun:
                pistol.SetActive(false);
                shotgun.SetActive(true);
                rifle.SetActive(false);
                break;

            case Weapon.rifle:
                pistol.SetActive(false);
                shotgun.SetActive(false);
                rifle.SetActive(true);
                break;

            default:
                break;
        }
    }
}

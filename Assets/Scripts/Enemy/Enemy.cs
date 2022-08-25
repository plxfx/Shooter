using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    protected int damage; //урон который враг наносит
    protected int health; //здоровье врага
    protected GameObject player; //Информация о игроке
    bool dead = false; //Мертвый ли враг

    // Start is called before the first frame update
    void Start()
    {
        player = FindObjectOfType<PlayerController>().gameObject; //Находим игрока
    }

    // Update is called once per frame
    void Update()
    {
        if (!dead)
        {
            Move();
            Attack();
        }
    }

    public virtual void Move() //Враг может как-то двигаться
    {

    }
    public virtual void Attack() //Враг может как-то атаковать
    {

    }
    public void OnDeath() //Умирают враги одинаково
    {
        dead = true;
        GetComponent<Animator>().SetTrigger("Death"); //изменили параметр анимации
        GetComponent<CharacterController>().enabled = false; //отключили коллайдер
    }
}


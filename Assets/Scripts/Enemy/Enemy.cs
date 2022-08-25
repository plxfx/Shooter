using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    protected int damage; //���� ������� ���� �������
    protected int health; //�������� �����
    protected GameObject player; //���������� � ������
    bool dead = false; //������� �� ����

    // Start is called before the first frame update
    void Start()
    {
        player = FindObjectOfType<PlayerController>().gameObject; //������� ������
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

    public virtual void Move() //���� ����� ���-�� ���������
    {

    }
    public virtual void Attack() //���� ����� ���-�� ���������
    {

    }
    public void OnDeath() //������� ����� ���������
    {
        dead = true;
        GetComponent<Animator>().SetTrigger("Death"); //�������� �������� ��������
        GetComponent<CharacterController>().enabled = false; //��������� ���������
    }
}


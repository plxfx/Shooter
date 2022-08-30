using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    int health;
    [SerializeField] Text textHealth;

    // Start is called before the first frame update
    void Start()
    {
        ChangeHealth(100);
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void ChangeHealth(int count)
    {
        health = health + count;
        textHealth.text = health.ToString();
    }
}

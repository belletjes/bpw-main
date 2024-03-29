using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hitbox : MonoBehaviour
{
    public bool activated = false;
    public GameObject secondworld;
    public GameObject wall;
    public GameObject player;
    
    
    void OnTriggerEnter(Collider other)
    {
        if (activated == false)
        {
            print("hitbox onn");
            secondworld.SetActive(true);
            wall.SetActive(false);
            activated = true;
        }
        else
        {
            print("hitbox off");
            secondworld.SetActive(false);
            wall.SetActive(true);
            activated = false;
        }
    }
    //void OnCollisionEnter(Collision other)
    //{
    //    //print("hitbox");
    //    wall.SetActive(false);
    //}
}

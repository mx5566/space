using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Enemy1
{
    public int health;

    public GameObject Projectile;

    public GameObject destructionVFX;
    public GameObject hitEffect;

    public int shotChance; //probability of 'Enemy's' shooting during tha path
    public float shotTimeMin, shotTimeMax; //max and min time for shooting from the beginning of the path

}


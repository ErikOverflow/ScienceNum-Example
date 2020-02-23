using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInfo : MonoBehaviour
{
    [SerializeField] int health = 100;
    [SerializeField] int attackDamage = 1;
    [SerializeField] float attackFrequency = 0.5f; //Seconds between attacks
    
    public int AttackDamage { get => attackDamage; }
    public int Health { get => health; }

    public void ChangeHealth(int newHealth)
    {
        Health = newHealth;
    }
}

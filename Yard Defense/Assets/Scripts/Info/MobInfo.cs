using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ErikOverflow
{
    public class MobInfo : MonoBehaviour
    {
        [SerializeField] int health = 10;
        [SerializeField] int attackDamage = 1;
        [SerializeField] float attackFrequency = 1f; //seconds between attacks

        public int Health { get => health; }
        public float AttackFrequency { get => attackFrequency; }
        public int AttackDamage { get => attackDamage; }

        public void ChangeHealth(int newHealth)
        {
            health = newHealth;
        }
    }
}
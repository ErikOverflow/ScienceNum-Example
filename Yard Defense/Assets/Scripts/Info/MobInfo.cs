using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#pragma warning disable 649
namespace YardDefense.Mob
{
    public class MobInfo : MonoBehaviour
    {
        [SerializeField] int currentHealth = 10;
        [SerializeField] int maxHealth = 10;
        [SerializeField] int attackDamage = 1;
        [SerializeField] float attackFrequency = 1f; //seconds between attacks

        public int CurrentHealth { get => currentHealth; }
        public float AttackFrequency { get => attackFrequency; }
        public int AttackDamage { get => attackDamage; }
        public int MaxHealth { get => maxHealth; }

        public void ChangeHealth(int newHealth)
        {
            currentHealth = newHealth;
            EventManager.Instance.MobHealthChanged();
        }
    }
}
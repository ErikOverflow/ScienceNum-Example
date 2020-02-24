using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace YardDefense.Player
{
    public class PlayerInfo : MonoBehaviour
    {
        [SerializeField] int currentHealth = 100;
        [SerializeField] int maxHealth = 100;
        [SerializeField] int attackDamage = 1;
        [SerializeField] float attackFrequency = 0.5f; //Seconds between attacks

        public int AttackDamage { get => attackDamage; }
        public int CurrentHealth { get => currentHealth; }
        public int MaxHealth { get => maxHealth; }
        public float AttackFrequency { get => attackFrequency; }

        public void ChangeHealth(int newHealth)
        {
            currentHealth = newHealth;
            EventManager.Instance.PlayerHealthChanged();
        }
    }
}
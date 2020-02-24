using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace YardDefense.Player
{
    public class PlayerInfo : MonoBehaviour
    {
        [SerializeField] ScienceNum currentHealth;
        [SerializeField] ScienceNum maxHealth;
        [SerializeField] ScienceNum attackDamage;
        [SerializeField] float attackFrequency = 0.5f; //Seconds between attacks

        public ScienceNum AttackDamage { get => attackDamage; }
        public ScienceNum CurrentHealth { get => currentHealth; }
        public ScienceNum MaxHealth { get => maxHealth; }
        public float AttackFrequency { get => attackFrequency; }

        public void ChangeHealth(ScienceNum newHealth)
        {
            currentHealth = newHealth;
            EventManager.Instance.PlayerHealthChanged();
        }
    }
}
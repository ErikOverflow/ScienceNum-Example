using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#pragma warning disable 649
namespace YardDefense.Mob
{
    public class MobInfo : MonoBehaviour
    {
        [SerializeField] string mobName = "Mob";
        [SerializeField] int currentHealth = 10;
        [SerializeField] int maxHealth = 10;
        [SerializeField] int attackDamage = 1;
        [SerializeField] float attackFrequency = 1f; //seconds between attacks

        public int CurrentHealth { get => currentHealth; }
        public float AttackFrequency { get => attackFrequency; }
        public int AttackDamage { get => attackDamage; }
        public int MaxHealth { get => maxHealth; }
        public string MobName { get => mobName; }

        public void Initialize(
            string _name, 
            int _maxHealth, 
            int _attackDamage, 
            float _attackFrequency
            )
        {
            mobName = _name;
            maxHealth = _maxHealth;
            attackDamage = _attackDamage;
            attackFrequency = _attackFrequency;
            ChangeHealth(maxHealth);
        }

        public void ChangeHealth(int newHealth)
        {
            currentHealth = newHealth;
            EventManager.Instance.MobHealthChanged();
        }
    }
}
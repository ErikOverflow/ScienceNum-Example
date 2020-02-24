using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#pragma warning disable 649
namespace YardDefense.Mob
{
    public class MobHealth : MonoBehaviour
    {
        [SerializeField] MobInfo mobInfo;
        private void Awake()
        {
            EventManager.Instance.OnPlayerAttack += TakeDamage;
        }

        private void TakeDamage(int damageAmount)
        {
            mobInfo.ChangeHealth(mobInfo.CurrentHealth - damageAmount);
        }
    }
}
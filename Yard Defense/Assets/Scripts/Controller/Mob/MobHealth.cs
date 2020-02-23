using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ErikOverflow
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
            mobInfo.ChangeHealth(mobInfo.Health - damageAmount);
        }
    }
}
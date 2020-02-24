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

        private void OnEnable()
        {
            EventManager.Instance.OnPlayerAttack += TakeDamage;
            EventManager.Instance.OnMobDied += DisableHealth;
        }

        private void OnDisable()
        {
            EventManager.Instance.OnPlayerAttack -= TakeDamage;
            EventManager.Instance.OnMobDied -= DisableHealth;
        }

        private void DisableHealth(MobInfo _mobInfo)
        {
            if(mobInfo == _mobInfo)
            {
                this.enabled = false;
            }
        }

        private void TakeDamage(int damageAmount)
        {
            mobInfo.ChangeHealth(mobInfo.CurrentHealth - damageAmount);
        }
    }
}
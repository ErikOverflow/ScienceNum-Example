using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#pragma warning disable 649
namespace YardDefense.Mob
{
    public class MobAttack : MonoBehaviour
    {
        [SerializeField] MobInfo mobInfo;
        float timer;

        private void OnEnable()
        {
            timer = 0f;
            EventManager.Instance.OnMobDied += DisableAttacking;
        }

        private void OnDisable()
        {
            EventManager.Instance.OnMobDied -= DisableAttacking;
        }

        private void DisableAttacking(MobInfo _mobInfo)
        {
            if (mobInfo == _mobInfo)
                this.enabled = false;
        }

        private void Update()
        {
            timer += Time.deltaTime;
            if (timer > mobInfo.AttackFrequency)
            {
                timer -= mobInfo.AttackFrequency;
                EventManager.Instance.MobAttack(mobInfo.AttackDamage);
            } 
        }
    }
}
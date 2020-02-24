using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#pragma warning disable 649
namespace YardDefense.Mob
{
    public class MobDeath : MonoBehaviour
    {
        [SerializeField] MobInfo mobInfo;

        private void Awake()
        {
            EventManager.Instance.OnMobHealthChanged += CheckForDeath;
        }

        private void CheckForDeath()
        {
            if(mobInfo.CurrentHealth.baseValue <= 0)
            {
                EventManager.Instance.MobDied(mobInfo);
            }
        }
    }
}
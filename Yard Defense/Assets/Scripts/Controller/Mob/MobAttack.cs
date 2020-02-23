﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ErikOverflow
{
    public class MobAttack : MonoBehaviour
    {
        [SerializeField] MobInfo mobInfo;
        float timer;

        private void Awake()
        {
            timer = 0f;
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
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace ErikOverflow
{
    public class EventManager : MonoBehaviour
    {
        public static EventManager Instance;

        private void Awake()
        {
            Instance = this;
        }

        public event Action<int> OnPlayerAttack;
        public void PlayerAttack(int damage)
        {
            OnPlayerAttack?.Invoke(damage);
        }

        public event Action<int> OnMobAttack;
        public void MobAttack(int damage)
        {
            OnMobAttack?.Invoke(damage);
        }

    }
}
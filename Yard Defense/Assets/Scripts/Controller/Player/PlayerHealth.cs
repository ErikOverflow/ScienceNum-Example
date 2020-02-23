using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ErikOverflow
{
    public class PlayerHealth : MonoBehaviour
    {
        [SerializeField] PlayerInfo playerInfo;
        private void Awake()
        {
            EventManager.Instance.OnMobAttack += TakeDamage;
        }

        private void TakeDamage(int damageAmount)
        {
            playerInfo.ChangeHealth(playerInfo.Health - damageAmount);
        }
    }
}
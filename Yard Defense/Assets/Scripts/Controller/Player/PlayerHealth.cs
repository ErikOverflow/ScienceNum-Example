using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#pragma warning disable 649
namespace YardDefense.Player
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
            playerInfo.ChangeHealth(playerInfo.CurrentHealth - damageAmount);
        }
    }
}
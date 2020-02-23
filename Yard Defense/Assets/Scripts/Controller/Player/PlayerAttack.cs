using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ErikOverflow
{
    public class PlayerAttack : MonoBehaviour
    {
        [SerializeField] PlayerInfo playerInfo;
        private void Update()
        {
#if !UNITY_IOS && !UNITY_ANDROID
            if (Input.GetMouseButtonDown(0))
            {
                EventManager.Instance.PlayerAttack(playerInfo.AttackDamage);
            }
#endif
        }
    }
}
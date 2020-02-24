using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace YardDefense.Mob
{
    public class MobInitializer : MonoBehaviour
    {
        [SerializeField] MobInfo mobInfo;
        [SerializeField] SpriteRenderer spriteRenderer;
        [SerializeField] MobSO _mobSO;

        private void Awake()
        {
            Initialize(_mobSO);
        }

        public void Initialize(MobSO mobSO)
        {
            spriteRenderer.sprite = mobSO.sprite;
            mobInfo.Initialize(
                mobSO.name,
                mobSO.health,
                mobSO.attackDamage,
                mobSO.attackFrequency
                );
        }
    }
}
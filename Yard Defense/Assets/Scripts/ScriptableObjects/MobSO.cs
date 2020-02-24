using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace YardDefense.Mob
{
    [CreateAssetMenu(fileName = "New mob", menuName = "Create new mob", order = 1)]
    public class MobSO : SpriteableObject
    {
        public ScienceNum health;
        public ScienceNum attackDamage;
        public float attackFrequency = 0.5f;
    }
}
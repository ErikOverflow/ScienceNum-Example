using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace YardDefense.Mob
{
    [CreateAssetMenu(fileName = "New mob", menuName = "Create new mob", order = 1)]
    public class MobSO : SpriteableObject
    {
        public int health = 10;
        public int attackDamage = 1;
        public float attackFrequency = 0.5f;
    }
}
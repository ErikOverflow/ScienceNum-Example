using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace YardDefense
{
    public abstract class SpriteableObject : ScriptableObject
    {
        [Header("Graphics and Animations")]
        public Sprite sprite;
    }
}
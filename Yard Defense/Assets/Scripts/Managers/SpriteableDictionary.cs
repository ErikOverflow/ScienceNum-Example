using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace YardDefense
{
    public class SpriteableDictionary : MonoBehaviour
    {
        public static SpriteableDictionary Instance;
        [SerializeField] SpriteableObject[] spriteableObjects;
        Dictionary<string, Sprite> spriteDictionary;
        private void Awake()
        {
            Instance = this;
            spriteDictionary = new Dictionary<string, Sprite>();
            spriteableObjects = Resources.FindObjectsOfTypeAll<SpriteableObject>();
            foreach (SpriteableObject so in spriteableObjects)
            {
                spriteDictionary.Add(so.name, so.sprite);
            }
        }

        public Sprite GetSprite(string name)
        {
            Sprite itemSprite;
            spriteDictionary.TryGetValue(name, out itemSprite);
            return itemSprite;
        }
    }
}

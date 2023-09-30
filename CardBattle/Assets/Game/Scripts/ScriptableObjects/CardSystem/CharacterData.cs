using UnityEngine;

namespace Game.Scripts.ScriptableObjects.CardSystem
{
    [CreateAssetMenu(fileName = "CharacterData", menuName = "ScriptableObjects/Characters/CharacterData", order = 0)]
    public class CharacterData : ScriptableObject
    {
        [Header("Character Specific Data")]
        [Space(4)]
        
        [SerializeField] private int health;
        [SerializeField] private int attack;
        
        [Header("Character Visual")]
        [Space(4)]
        
        [SerializeField] private Sprite characterSprite;
        
        public int Health => health;
        public int Attack => attack;
        public Sprite CharacterSprite => characterSprite;
    }
}
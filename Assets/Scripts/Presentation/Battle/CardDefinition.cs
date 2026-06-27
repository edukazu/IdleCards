using UnityEngine;

namespace IdleCards.Domain.Cards
{
    [CreateAssetMenu(
        fileName = "NewCard",
        menuName = "Idle Cards/Cards/Card Definition")]
    public sealed class CardDefinition : ScriptableObject
    {
        [Header("Identity")]
        [SerializeField] private string cardId;
        [SerializeField] private string displayNameKey;

        [Header("Prototype Localization")]
        [SerializeField] private string defaultDisplayName;

        public string CardId => cardId;
        public string DisplayNameKey => displayNameKey;
        public string DefaultDisplayName => defaultDisplayName;
    }
}
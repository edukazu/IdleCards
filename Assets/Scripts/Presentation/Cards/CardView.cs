using IdleCards.Domain.Cards;
using TMPro;
using UnityEngine;

namespace IdleCards.Presentation.Cards
{
    public sealed class CardView : MonoBehaviour
    {
        [SerializeField] private TMP_Text characterName;

        public void Bind(CardDefinition card)
        {
            if (card == null)
            {
                Clear();
                return;
            }

            characterName.text = card.DefaultDisplayName;
        }

        public void Clear()
        {
            characterName.text = string.Empty;
        }
    }
}
using TMPro;
using UnityEngine;

namespace IdleCards.Presentation.Battle
{
    public sealed class PlayerSlotView : MonoBehaviour
    {
        [SerializeField] private GameObject cardView;
        [SerializeField] private TMP_Text characterName;

        public bool IsOccupied => cardView != null && cardView.activeSelf;

        public void ShowCard(string displayName)
        {
            if (cardView == null)
            {
                Debug.LogError($"{name}: CardView reference is missing.", this);
                return;
            }

            cardView.SetActive(true);

            if (characterName != null)
            {
                characterName.text = displayName;
            }
        }

        public void Clear()
        {
            if (cardView != null)
            {
                cardView.SetActive(false);
            }

            if (characterName != null)
            {
                characterName.text = string.Empty;
            }
        }
    }
}
using System;
using IdleCards.Domain.Cards;
using IdleCards.Presentation.Cards;
using UnityEngine;
using UnityEngine.EventSystems;

namespace IdleCards.Presentation.Battle
{
    public sealed class PlayerSlotView : MonoBehaviour, IPointerClickHandler
    {
        [SerializeField] private GameObject cardViewObject;
        [SerializeField] private CardView cardView;

        public event Action<PlayerSlotView> Clicked;

        public bool IsOccupied => cardViewObject != null && cardViewObject.activeSelf;

        public void ShowCard(CardDefinition card)
        {
            if (cardViewObject == null || cardView == null)
            {
                Debug.LogError($"{name}: CardView references are missing.", this);
                return;
            }

            cardViewObject.SetActive(true);
            cardView.Bind(card);
        }

        public void Clear()
        {
            if (cardView != null)
            {
                cardView.Clear();
            }

            if (cardViewObject != null)
            {
                cardViewObject.SetActive(false);
            }
        }

        public void OnPointerClick(PointerEventData eventData)
        {
            Clicked?.Invoke(this);
        }
    }
}
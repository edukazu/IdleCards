using IdleCards.Domain.Cards;
using UnityEngine;

namespace IdleCards.Presentation.Battle
{
    public sealed class BattlePrototypeController : MonoBehaviour
    {
        [Header("Prototype Data")]
        [SerializeField] private CardDefinition startingCard;

        [Header("Player Slots")]
        [SerializeField] private PlayerSlotView slotNorth;
        [SerializeField] private PlayerSlotView slotWest;
        [SerializeField] private PlayerSlotView slotEast;
        [SerializeField] private PlayerSlotView slotSouth;

        private PlayerSlotView currentSlot;

        private void Start()
        {
            slotNorth.Clear();
            slotWest.Clear();
            slotEast.Clear();
            slotSouth.Clear();

            currentSlot = slotNorth;
            ShowStartingCard();

            slotNorth.Clicked += MoveCardTo;
            slotWest.Clicked += MoveCardTo;
            slotEast.Clicked += MoveCardTo;
            slotSouth.Clicked += MoveCardTo;
        }

        private void OnDestroy()
        {
            slotNorth.Clicked -= MoveCardTo;
            slotWest.Clicked -= MoveCardTo;
            slotEast.Clicked -= MoveCardTo;
            slotSouth.Clicked -= MoveCardTo;
        }

        private void MoveCardTo(PlayerSlotView destinationSlot)
        {
            if (destinationSlot == currentSlot || startingCard == null)
            {
                return;
            }

            currentSlot.Clear();
            destinationSlot.ShowCard(startingCard);
            currentSlot = destinationSlot;
        }

        private void ShowStartingCard()
        {
            if (startingCard == null)
            {
                Debug.LogError("Starting Card reference is missing.", this);
                return;
            }

            currentSlot.ShowCard(startingCard);
        }
    }
}
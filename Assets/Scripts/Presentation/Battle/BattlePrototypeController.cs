using System.Collections;
using UnityEngine;

namespace IdleCards.Presentation.Battle
{
    public sealed class BattlePrototypeController : MonoBehaviour
    {
        [SerializeField] private PlayerSlotView slotNorth;
        [SerializeField] private PlayerSlotView slotWest;
        [SerializeField] private PlayerSlotView slotEast;
        [SerializeField] private PlayerSlotView slotSouth;

        private IEnumerator Start()
        {
            slotNorth.ShowCard("Dimensional Traveler");
            slotWest.Clear();
            slotEast.Clear();
            slotSouth.Clear();

            yield return new WaitForSeconds(2f);

            slotNorth.Clear();
            slotEast.ShowCard("Dimensional Traveler");
        }
    }
}
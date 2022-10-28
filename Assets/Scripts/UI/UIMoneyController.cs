using UnityEngine;
using TMPro;

namespace TKOU.SimAI.UI
{
    /// <summary>
    /// Menu controller.
    /// </summary>
    public class UIMoneyController : MonoBehaviour
    {
        #region Variables

        [SerializeField]
        private GameContents Contents;

        [SerializeField]
        private TextMeshProUGUI cashText;

        [SerializeField]
        private TextMeshProUGUI spentText;

        [SerializeField]
        private TextMeshProUGUI incomeText;

        #endregion Variables

        #region Unity methods

        private void Update()
        {
            cashText.text = Contents.player.cash.ToString() +" $ ";
            spentText.text = " - " + Contents.player.spentMoney.ToString() + " $ ";
            incomeText.text = " + " + (Contents.player.ownedBuildings*10).ToString() + " $ / 5s";
        }

        #endregion Unity methods
    }
}

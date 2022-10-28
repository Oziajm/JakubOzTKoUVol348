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

        #endregion Variables

        #region Unity methods

        private void Update()
        {
            cashText.text = Contents.player.cash.ToString() +"$";
        }

        #endregion Unity methods

        #region Private methods



        #endregion Private methods

        #region Event callbacks



        #endregion Event callbacks
    }
}

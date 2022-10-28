using System.Collections;
using UnityEngine;

namespace TKOU.SimAI
{

    public class BuildingController : MonoBehaviour
    {
        [SerializeField]
        private GameContents contents;

        private void Start()
        {
            StartCoroutine(IncomeCoroutine());
        }

        private IEnumerator IncomeCoroutine()
        {
            while (true)
            {
                contents.player.cash += 10;
                yield return new WaitForSeconds(5f);
            }
        }
    }
}

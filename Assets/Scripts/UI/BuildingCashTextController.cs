using System.Collections;
using UnityEngine;
using TMPro;


public class BuildingCashTextController : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI incomeText;

    private bool shownCosts = false;

    public void StartPriceAnimation(int buildingPrice)
    {
        StartCoroutine(IncomeCoroutine(buildingPrice));
    }

    private IEnumerator IncomeCoroutine(int buildingPrice)
    {
        while (true)
        {
            incomeText.color = shownCosts ? Color.green : Color.red;
            incomeText.text = shownCosts ? "+10" : "-" + buildingPrice.ToString();
            incomeText.gameObject.SetActive(false);
            yield return new WaitForSeconds(3.5f);
            incomeText.gameObject.SetActive(true);
            shownCosts = true;
            yield return new WaitForSeconds(0.5f);
        }
    }
}

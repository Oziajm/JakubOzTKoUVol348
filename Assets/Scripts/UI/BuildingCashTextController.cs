using System.Collections;
using UnityEngine;
using TMPro;


public class BuildingCashTextController : MonoBehaviour
{
    public int buildingPrice = 0;

    [SerializeField]
    private TextMeshProUGUI incomeText; 

    private bool shownCosts = false;

    private void Start()
    {
        StartCoroutine(IncomeCoroutine());
    }

    private IEnumerator IncomeCoroutine()
    {
        while (true)
        {
            incomeText.color = shownCosts ? Color.green : Color.red;
            incomeText.text = shownCosts ? "+10" : "-" + buildingPrice.ToString();
            incomeText.gameObject.SetActive(true);
            yield return new WaitForSeconds(0.5f);
            incomeText.gameObject.SetActive(false);
            shownCosts = true;
            yield return new WaitForSeconds(4.5f);
        }
    }
}

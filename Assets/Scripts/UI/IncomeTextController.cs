using System.Collections;
using UnityEngine;

public class IncomeTextController : MonoBehaviour
{
    [SerializeField]
    private GameObject incomeText;

    private void Start()
    {
        StartCoroutine(IncomeCoroutine());
    }

    private IEnumerator IncomeCoroutine()
    {
        while (true)
        {
            incomeText.SetActive(false);
            yield return new WaitForSeconds(5f);
            incomeText.SetActive(true);
            yield return new WaitForSeconds(0.5f);
        }
    }
}

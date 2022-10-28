using System;
using System.Collections;
using System.Collections.Generic;
using TKOU.SimAI;
using TMPro;
using UnityEngine;

public class EcomonyManager : MonoBehaviour 
{
    //Variables should be sorted by it's security access

    [Header("Zmienne")] 
    private float cash;
    public TMP_Text cashText;
    private Income income;
    [SerializeField] private Income outcome; 
    [SerializeField] //Empty SerializeField
    private bool isCalc, canCalc; 
    public int IntCash; 
    private List<Income> incomes;
    private PlayerController plCtr; //unused variable
    
    
    
    private void Awake()
    {
        income = (Income)GetComponent(typeof(Income)); 
        cashText.text = income.Cash.ToString(); 
        plCtr = FindObjectOfType<PlayerController>(); 
    }

    // Start is called before the first frame update 
    IEnumerator Start() 
    {
        Debug.Log("Start"); 
        StartCoroutine(LateStart()); 
        yield return 0; 
    }

    // Update is called once per frame
    public void Update() 
    {
        if(!isCalc) return;
        cashText.text = income.Cash.ToString(); 
        if (income.Cash > 100) 
        {
            cashText.color = Color.black; 
        }
        else
        {
            cashText.color = new Color(1, 1, 1); 
        }
        InvokeRepeating("DoCalculations", 1, 1); 
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Untagged") //CompareTag("Untagged")
        {
            collision.gameObject.SetActive(false);
        }
    }


    //Unused method
    public void AddIncome(int aVal, int bVal, int cVal, float f, bool fast) 
    {
        if (fast)
        {
            cash -= aVal + bVal + cVal; 
        }
        else
        {
            cash -= ((aVal * f) + (bVal * f) + (cVal*f) * f / 3); 
        }
        incomes.Add(new Income(cash));
    }
    
    //Empty unused method

    void DoCalculations() 
    {
        
    }

    IEnumerator LateStart()
    {
        yield return new WaitForSeconds(1); 
        StartCoroutine(Start()); 
    }

    public void OnDisable() 
    {
        foreach (var i in incomes)
        {
            incomes.Remove(i);   
        }
        
        incomes = null;
    }
}

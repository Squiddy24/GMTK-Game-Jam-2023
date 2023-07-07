using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Logic : MonoBehaviour
{
    public bool sold;
    public int value;
    public int cash_money;
    public Text wallet;
    public int drugstash;
    public Text canabis;
    // Start is called before the first frame update
    void Start()
    {
        value = Random.Range(10, 15);
    }

    // Update is called once per frame
    void Update()
    {
        wallet.text = cash_money.ToString();
        canabis.text = drugstash.ToString(); 
    }
    public void sell()
    {
        if (drugstash > 0)
        {
            cash_money = cash_money + value;
            value = Random.Range(10, 15);
            drugstash = drugstash - 1;
        }
    }
    public void make_drugs()
    {
        drugstash = drugstash + 1;
    }
}

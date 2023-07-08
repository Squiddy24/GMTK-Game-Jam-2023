using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Furnace_AI : MonoBehaviour
{
    public int amount_of_ore;
    public Text amount_of_ore_UI;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        amount_of_ore_UI.text = amount_of_ore.ToString();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        amount_of_ore = amount_of_ore + 1;
    }
}

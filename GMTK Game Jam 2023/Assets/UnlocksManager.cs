using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnlocksManager : MonoBehaviour
{
    public int DisplayLevel = 0;
    public static int Level;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Level = DisplayLevel;
    }
}

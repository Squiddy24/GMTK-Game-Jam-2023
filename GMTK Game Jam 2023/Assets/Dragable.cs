using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dragable : MonoBehaviour
{
    public Transform self;
    public bool Draging = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {     
           Draging = true;
           self.localScale += new Vector3(0.5f, 0.5f, 0);

        }
        if (Input.GetMouseButtonUp(0))
        {
            Draging = false;
            self.localScale -= new Vector3(0.5f, 0.5f, 0);

        }

        if (Draging)
        {
            self.position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }

    }
}

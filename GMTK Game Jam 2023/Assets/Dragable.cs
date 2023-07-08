using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dragable : MonoBehaviour
{
    public Transform self;
    public bool Draging = false;
    private Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    
        if (Draging)
        {
            self.position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }

    }

    private void OnMouseDown()
    {
        offset = transform.position - Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Draging = true;
        self.localScale += new Vector3(0.5f, 0.5f, 0);

    }

    private void OnMouseUp()
    {
        Draging = false;
        self.localScale -= new Vector3(0.5f, 0.5f, 0);
    }
}

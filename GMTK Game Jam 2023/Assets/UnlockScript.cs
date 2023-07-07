using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnlockScript : MonoBehaviour
{
    public int LevelThreshold;
    public SpriteRenderer spriteRender;

    // Start is called before the first frame update
    void Start()
    {
        spriteRender.color = new Color32(0, 0, 0, 255);
    }

    // Update is called once per frame
    void Update()
    {
        if (UnlocksManager.Level >= LevelThreshold)
        {
            spriteRender.color = new Color32(255, 255, 255, 255);
        }
        else
        {
            spriteRender.color = new Color32(0, 0, 0, 255);
        }
    }
}

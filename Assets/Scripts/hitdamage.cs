using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Security.Cryptography;
using UnityEngine;

public class hitdamage : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Color hitColor = Color.red;
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void OnCollisionStay2D(Collision2D collision)
    {
        spriteRenderer.color = hitColor;
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        spriteRenderer.color = Color.white;
    }
}

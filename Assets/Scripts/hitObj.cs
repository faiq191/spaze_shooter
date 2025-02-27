using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hitObj : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Color hitColor = Color.red;
    public float delay = 0.5f;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void OnCollisionStay2D(Collision2D collision)
    {
        spriteRenderer.color = hitColor;
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        StartCoroutine(ResetColor());
    }

    IEnumerator ResetColor()
    {
        yield return new WaitForSeconds(delay);
        spriteRenderer.color = Color.gray;
    }
}
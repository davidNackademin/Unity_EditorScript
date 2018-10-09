using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(BoxCollider2D))]
public class ClickSquare : MonoBehaviour {


    public int points;

    public int Level {
        get { return points / 35; }
    }

    [HideInInspector]
    public SpriteRenderer spriteRenderer;

    private void Reset()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void OnMouseDown()
    {
        spriteRenderer.color = Color.red;
        Debug.Log("click");
    }

   
}

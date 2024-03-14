using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Change : MonoBehaviour
{
    public Color defaultColor = Color.white; // Default color of the sprite
    public Color touchedColor = Color.red; // Color when player touches the sprite

    private SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.color = defaultColor; // Set the default color when the script starts
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player")) // Assuming the player has a tag "Player"
        {
            spriteRenderer.color = touchedColor; // Change color when player touches the sprite
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player")) // Assuming the player has a tag "Player"
        {
            spriteRenderer.color = defaultColor; // Change color back to default when player stops touching
        }
    }

}

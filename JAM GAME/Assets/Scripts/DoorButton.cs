using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorButton : MonoBehaviour
{ 
    public Animator animator;
    public string Name;

    void Start()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player")) // Assuming the player has a tag "Player"
        {
            //animator.Play("Doorone"); // Crossfade to the specified animation state
            PlayAnimation(Name);
        }
    }
    void PlayAnimation(string animName)
    {
        animator.Play(animName);
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        animator.Play("New State");
    }



}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OnTrigger : MonoBehaviour
{
    private Animator anim;
    private int points = 0;
    [SerializeField] private Text pointsText;
    private void OnTriggerEnter2D(Collider2D collision) 
    {
        if (collision.gameObject.CompareTag("Collectible")) {
            anim = collision.gameObject.GetComponent<Animator>();
            anim.SetBool("isTriggered", true);
            points++;
            pointsText.text = "Points: " + points;
        }
    }
}
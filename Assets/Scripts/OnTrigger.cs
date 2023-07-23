using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class OnTrigger : MonoBehaviour
{
    [SerializeField] private Text pointsText;
    private Animator anim;
    private int points = 0;
    void Start()
    {
        pointsText.text = "Points: " + points;
    }

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
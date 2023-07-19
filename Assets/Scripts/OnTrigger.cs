using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class OnTrigger : MonoBehaviour
{
    void Start()
    {
        pointsText.text = "Points: " + points;
    }

    private Animator anim;
    private static int points = 0;
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
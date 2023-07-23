using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlimeAnimations : MonoBehaviour
{
    public Animator animator;
    private bool idle = true;
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void AnimationUpdate()
    {

    }
}

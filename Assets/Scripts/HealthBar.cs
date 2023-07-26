using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Slider slider;
    public HealthSystem healthSystem;
    void Start()
    {
        slider.maxValue = healthSystem.healthMax;
        slider.value = healthSystem.health;
    }

    // Update is called once per frame
    void Update()
    {
        slider.value = healthSystem.health;
    }
}

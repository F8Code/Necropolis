using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StaminaSystem : MonoBehaviour
{
    public float currentStamina;
    [SerializeField] private float maxStamina;
    [SerializeField] private float staminaRegen;
    public Slider slider;
    private void Start()
    {
        currentStamina = maxStamina;
        slider.maxValue = currentStamina;
        slider.value = currentStamina;
    }
    void Update()
    {
        if(currentStamina < maxStamina)
        {
            currentStamina += staminaRegen;
            if(currentStamina > maxStamina)
            {
                currentStamina = maxStamina;
            }
        }
        slider.value = currentStamina;
        Debug.Log("Stamina: " + currentStamina);
    }
}

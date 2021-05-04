using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Slider slider; // Calls to the slider on the UI.
    
    public void SetMaxHealth(int health) // Sets the max healthon the UI slider.
    {
        slider.maxValue = health; // Sets the maxvalue for slider.
        slider.value = health; // Sets the interchangable slider.
    }

    public void SetHealth(int health) // Sets the health value on the sldier.
    {
        slider.value = health; // Changes the slider for the health bar to current health. Used in Player script.
    }
}

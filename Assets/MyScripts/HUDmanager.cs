using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUDmanager : MonoBehaviour
{
    public Slider healthSlider;

    public void UpdateHealthBar(float value)
    {
        healthSlider.value = value;
    }
}

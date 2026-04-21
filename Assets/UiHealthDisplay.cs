using System;
using TMPro;
using UnityEngine;

public class UiHealthDisplay : MonoBehaviour
{

    public TextMeshProUGUI healthText;
    public PlayerHealth PlayerHealth;



    void Start()
    {
        PlayerHealth.OnHealthChanged += OnHealthChanged;
        PlayerHealth.OnHealthInitialised += OnHealthInit;
    }

    private void OnHealthInit(float newHealth)
    {
        healthText.text = newHealth.ToString();
    }

    public void OnHealthChanged(float newHealth, float amountChanged)
    {
        //Debug.Log("On Health Changed Event");
        healthText.text = newHealth.ToString();
    }

}


using System;
using System.Collections;
using UnityEngine;

public class PlayerHealth : MonoBehaviour

{

    public float maxHealth = 100;
    private float health;
    private bool canReceiveDamage = true;
    public float invicibilityTimer = 2;



    public delegate void HealthChangedHandler(float newHealth, float amountChanged);
    public event HealthChangedHandler OnHealthChanged;
    public delegate void HealthInitHandler(float newHealth);
    public event HealthInitHandler OnHealthInitialised;

    void Start()
    {
        health = maxHealth;
        OnHealthInitialised?.Invoke(health);
    }

    // Update is called once per frame

    void Update()

    {

    }


    public void AddDamage(float damage)

    {

        if (canReceiveDamage)
        {
            health -= damage;
            OnHealthChanged?.Invoke(health, -damage);
            canReceiveDamage = false;
            StartCoroutine(InvincibilityTimer(invicibilityTimer, ResetInvincibility));
        }

        //Debug.Log(health);

    }

    IEnumerator InvincibilityTimer(float time, Action callback)

    {

        yield return new WaitForSeconds(time);
        callback.Invoke();
    }

    private void ResetInvincibility()
    {
        canReceiveDamage = true;
    }


    public void AddHealth(float healthToAdd)

    {
        health += healthToAdd;
        OnHealthChanged?.Invoke(health, healthToAdd);
        //Debug.Log(health);
    }

}


using System;
using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;

public class playerHealth : MonoBehaviour
{
    public float maxHealth = 100;
    private float health;
    private bool canReceiveDamage = true;
    public float invicibilityTimer = 2;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        health = maxHealth;
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
            canReceiveDamage = false;
            StartCoroutine(InvincibilityTimer(invicibilityTimer, ResetInvicibility));

        }
        Debug.Log(health);
    }

    IEnumerator InvincibilityTimer(float time, Action callback)
    {
        yield return new WaitForSeconds(time);
        callback.Invoke();
    }

    private void ResetInvicibility()
    {
        canReceiveDamage = true;
    }

    public void AddHealth(float healthToAdd)
    {
        health += healthToAdd;
        Debug.Log(health);
    }
}

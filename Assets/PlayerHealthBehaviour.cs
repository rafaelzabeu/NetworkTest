using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

public class PlayerHealthBehaviour : NetworkBehaviour {

    public const int MAX_HEALTH = 100;

    public RectTransform healthBar;

    [SyncVar(hook = "OnChangeHealth")]
    public int currentHealth = MAX_HEALTH;

    public void TakeDamage(int amount)
    {
        if (!isServer)
            return;
        currentHealth -= amount;
        if (currentHealth <= 0)
        {
            currentHealth = 0;
            Debug.Log("Dead!");
        }
    }

    void OnChangeHealth(int currentHealth)
    {
        healthBar.sizeDelta = new Vector2(currentHealth, healthBar.sizeDelta.y);
    }
}

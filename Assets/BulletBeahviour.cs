using UnityEngine;
using System.Collections;

public class BulletBeahviour : MonoBehaviour {

    void OnCollisionEnter(Collision col)
    {
        var hit = col.gameObject;
        var health = hit.GetComponent<PlayerHealthBehaviour>();
        if (health != null)
        {
            health.TakeDamage(10);
        }
        Destroy(gameObject);
    }
	
}

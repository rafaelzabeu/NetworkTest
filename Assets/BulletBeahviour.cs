using UnityEngine;
using System.Collections;

public class BulletBeahviour : MonoBehaviour {

    void OnCollisionEnter(Collision col)
    {
        Destroy(gameObject);
    }
	
}

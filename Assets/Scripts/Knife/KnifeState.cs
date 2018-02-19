using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnifeState : MonoBehaviour {
    KnifeProvider knifeProvider;
    void Start () {
        knifeProvider = GetComponent<KnifeProvider>();        
    }

    public void OnTriggerEnter2D(Collider2D coll) {
        if (coll.tag == "Knife") return;

        knifeProvider.Stop();
        gameObject.SetActive(false);
    }
}

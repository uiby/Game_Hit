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
    }

    public void Hide(float duration) {
        StartCoroutine(PlayHide(duration));
    }

    IEnumerator PlayHide(float duration) {
        yield return new WaitForSeconds(duration);

        gameObject.SetActive(false);
    }
}

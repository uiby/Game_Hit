using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class KnifeProvider : MonoBehaviour {
    KnifeMover KnifeMover;
    //[Inject] KnifeManager knifeManager;

	// Use this for initialization
	void Start () {
        KnifeMover = GetComponent<KnifeMover>();		
	}

    public void Throw() {
        KnifeMover.Throw();
    }

    public void Stop() {
        KnifeMover.Stop();
    }

    public void Translate(Vector2 pos, float deg) {
        transform.position = pos;
        transform.localRotation = Quaternion.Euler(new Vector3(0, deg, 0));
    }
}

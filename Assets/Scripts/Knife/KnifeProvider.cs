using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class KnifeProvider : MonoBehaviour {
    KnifeMover knifeMover;
    KnifeState knifeState;
    //[Inject] KnifeManager knifeManager;

	// Use this for initialization
	void Start () {
        knifeMover = GetComponent<KnifeMover>();
        knifeState = GetComponent<KnifeState>();
	}

    public void Throw() {
        knifeMover.Throw();
    }

    public void Translate(Vector2 pos, float deg) {
        transform.position = pos;
        transform.localRotation = Quaternion.Euler(new Vector3(0, deg, 0));
    }

    public void HitTarget() {
        knifeMover.Stop();
        knifeState.Hide(0.2f);
    }
}

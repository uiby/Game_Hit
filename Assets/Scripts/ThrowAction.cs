using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class ThrowAction : MonoBehaviour {
    [Inject] KnifeManager knifeManager;
	
	// Update is called once per frame
	void Update () {
        Throw();
	}

    void Throw() {
        if (Input.GetMouseButtonDown(0) || Input.GetMouseButtonDown(1)) {
            knifeManager.Throw();
        }
    }

    public void Remove() {
        this.enabled = false;
    }
}

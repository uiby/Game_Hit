using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetProvider : MonoBehaviour {
    TargetEffect targetEffect;

	// Use this for initialization
	void Start () {
        targetEffect = GetComponent<TargetEffect>();		
	}

    public void PlayHitEffect(HitResultType type) {
        targetEffect.PlayHitEffect(type);
    }
}

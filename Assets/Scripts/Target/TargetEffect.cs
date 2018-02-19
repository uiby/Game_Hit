using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetEffect : MonoBehaviour {
    [SerializeField] HitResultEffect hitResultEffect;

    public void PlayHitEffect(HitResultType type) {
        hitResultEffect.PlayEffect(type);
    }

}

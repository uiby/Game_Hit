using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class TargetProvider : MonoBehaviour {
    TargetEffect targetEffect;
    NecessaryKnife necessaryKnife;
    [Inject] GameManager gameManager;

	// Use this for initialization
	void Awake() {
        targetEffect = GetComponent<TargetEffect>();		
        necessaryKnife = GetComponent<NecessaryKnife>();
	}

    public void PlayHitEffect(HitResultType type) {
        targetEffect.PlayHitEffect(type);
    }

    public void SetRequireKnife(int amount) {
        necessaryKnife.SetRequireKnife(amount);
    }

    public void DecreaseRequireKnife() {
        necessaryKnife.Decrease();
        if (!necessaryKnife.NoRequireKnife()) return;

        gameManager.StageClear();
    }
}

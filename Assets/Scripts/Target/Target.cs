using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour {
    [SerializeField] float comboDuration = 0.25f;
    float timer = 0;
    float comboCount = 0;
    TargetProvider targetProvider;

    void Awake() {
        targetProvider = GetComponent<TargetProvider>();
    }

    void Update() {
        if (comboCount == 0) return;
        timer += Time.deltaTime;
        if (timer > comboDuration) comboCount = 0;
    }

    void OnTriggerEnter2D(Collider2D coll) {
        if (coll.tag != "Knife") return;
        timer = 0;

        targetProvider.PlayHitEffect((HitResultType)Mathf.Clamp(comboCount, 0, 2));
        targetProvider.DecreaseRequireKnife();
        comboCount++;
        coll.GetComponent<KnifeProvider>().HitTarget();
    }
}

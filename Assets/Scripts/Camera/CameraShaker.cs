using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShaker : MonoBehaviour {
    float maxShakeMargin = 0.15f;
    Vector3 center;
    Coroutine shakeCor;
    bool shaking = false;

    void Awake() {
        center = transform.position;
    }

    public void Shake(float duration) {
        if (shaking) StopCoroutine(shakeCor);
        shakeCor = StartCoroutine(PlayShakeToVerical(duration));
    }

    IEnumerator PlayShakeToVerical(float duration) {
        var timer = 0f;
        var rate = 0f;
        int upDown = 1;

        shaking = true;
        while(rate < 1) {
            timer += Time.deltaTime;
            rate = Mathf.Clamp01(timer/duration);

            transform.position = center + Vector3.up * Mathf.Lerp(maxShakeMargin, 0, rate) * upDown;
            upDown *= -1;
            yield return null;
        }
        shaking = false;
    }

}

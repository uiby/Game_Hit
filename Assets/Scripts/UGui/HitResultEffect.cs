using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitResultEffect : TextParts {

    [SerializeField] AnimationCurve scaleCurve;
    bool playingEffect = false;
    Coroutine effectCol;
    [SerializeField, Range(1.5f, 2.5f)] float maxScale;
    [SerializeField, Range(0.1f, 0.5f)] float effectDuration;

    public void PlayEffect(HitResultType type) {
        ChangeText(type.ToString());
        if (playingEffect) {
            StopCoroutine (effectCol);
        }

        effectCol = StartCoroutine(PlayEffect(effectDuration, ((int)type * 2 + 11)/10f, maxScale * ((int)type * 2 + 11)/10f));
        RotateInTheMoment(Random.Range(0, 15f) * -1);
    }

    /// <summary>
    /// 演出.テキストの大きさを大→小にする.
    /// </summary>
    /// <param name="duration">期間(sec)</param>
    IEnumerator PlayEffect(float duration, float minScale, float maxScale) {
        var timer = 0f;
        var rate = 0f;

        playingEffect = true;
        ShowText();
        while (rate < 1) {
            timer += Time.deltaTime;
            rate = Mathf.Clamp01(timer / duration);
            var curvePos = scaleCurve.Evaluate(rate);
            ChangeFontSize(Mathf.Lerp(minScale, maxScale, curvePos));
            yield return null;
        }

        yield return new WaitForSeconds(0.25f);

        HideText();
        playingEffect = false;
    }
}

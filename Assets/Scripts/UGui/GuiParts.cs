﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GuiParts : MonoBehaviour {
    [HideInInspector] public float width{get; private set;}
    [HideInInspector] public float height{get; private set;}
    RectTransform rectTrans;

    protected virtual void Awake () {
        rectTrans = GetComponent<RectTransform>();
        var size = GetComponent<RectTransform>().sizeDelta;
        width = size.x;
        height = size.y;
    }

    public void MovePosition(Vector2 pos, float duration) {
        StartCoroutine(Move(pos, duration));
    }
    public void MovePositionInTheMoment(Vector2 pos) {
        rectTrans.localPosition = pos;
    }

    public void TransParent(Transform parent) {
        transform.SetParent(parent);
    }

    IEnumerator Move(Vector2 idealPos, float duration) {
        var startPos = (Vector2)rectTrans.localPosition;
        var endPos = idealPos;
        var timer = 0f;
        var rate = 0f;

        while (rate < 1) {
            timer += Time.deltaTime;
            rate = Mathf.Clamp(timer/duration, 0f, 1f);

            rectTrans.localPosition = Vector2.Lerp(startPos, endPos, rate);
            yield return null;
        }
    }

    public void RotateInTheMoment(float deg) {
        rectTrans.localRotation = Quaternion.Euler(0, 0, deg);
    }
    public void ChangeScale(float scale) {
        rectTrans.localScale = Vector3.one * scale;
    }
}

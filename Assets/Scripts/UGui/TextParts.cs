using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class TextParts : GuiParts {
    [SerializeField] bool hideOnAwake = true;
    Text text;
    float initFontSize;

    protected override void Awake () {
        base.Awake();
        text = GetComponent<Text>();
        initFontSize = text.fontSize;
        if (hideOnAwake) HideText();
    }

    public void ChangeText(string str) {
        text.text = str;
    }

    public void ChangeFontSize(float scale) {
        text.fontSize = (int)(initFontSize * scale);
    }

    public void ShowText() {
        text.enabled = true;
    }

    public void HideText() {
        text.enabled = false;
    }
}

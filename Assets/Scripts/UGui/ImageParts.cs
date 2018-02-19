using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
public class ImageParts : GuiParts {
    Image image;

    protected override void Awake () {
        base.Awake();
        image = GetComponent<Image>();
    }

    public void ChangeColor(Color color) {
        image.color = color;
    }

    public void ShowImage() {
        image.enabled = true;
    }

    public void HideImage() {
        image.enabled = false;
    }
}

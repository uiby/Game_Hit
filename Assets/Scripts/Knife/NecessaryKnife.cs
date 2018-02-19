using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class NecessaryKnife : MonoBehaviour {
    int necessaryKnifeCount = 0;
    [SerializeField] List<ImageParts> knifeList;

    void Awake() {
        knifeList.ForEach(knife => knife.HideImage());
    }

    public void SetRequireKnife(int amount) {
        necessaryKnifeCount = amount;
        foreach(var item in knifeList.Select((value, index) => new {value, index})) {
            if (item.index < amount) {
                item.value.ChangeColor(Color.white);
                item.value.ShowImage();
            }
            else item.value.HideImage();
        }
    }

    public void Decrease() {
        if (necessaryKnifeCount == 0) return;
        necessaryKnifeCount--;
        knifeList[necessaryKnifeCount].ChangeColor(new Color(0.3f, 0.3f, 0.3f, 1));
    }

    public bool NoRequireKnife() {
        return necessaryKnifeCount == 0;
    }
}

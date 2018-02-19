using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageCounter : TextParts {
    public void UpdateCounter(int num) {
        var str = (num + 1).ToString();
        if (num + 1 >= 10) str = "FINAL";
        ChangeText(str);
    }
}

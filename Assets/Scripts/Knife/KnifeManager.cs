using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnifeManager : MonoBehaviour {
    [SerializeField] KnifePool knifePool;
    KnifeProvider nowKnife;

	void Start () {
		SetNewKnife();
	}

    public void SetNewKnife() {
        nowKnife = knifePool.Pop();
        SetInitPos();
    }

    public void Throw() {
        nowKnife.Throw();
        SetNewKnife();
    }
	
    void SetInitPos() {
        nowKnife.Translate(new Vector2(0, -4), 0);
    }
}

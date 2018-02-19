using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
    [SerializeField] TargetProvider targetProvider;
    [SerializeField] CameraProvider cameraProvider;
    [SerializeField] ThrowAction throwAction;
    [SerializeField] StageCounter stageCounter;

    int stageCount = 0;
    bool stageClear = false;
	// Use this for initialization
	void Start () {
        StartCoroutine(PlayGameLoop());
	}

    IEnumerator PlayGameLoop() {
        SetFirstStage();
        yield return null;

        while(stageCount < 10) {
            if (stageClear) {
                if (stageCount == 9) {
                    //game clear
                    GameClear();
                    break;
                }
                NextStage();
            }
            yield return null;
        }
    }

    public void StageClear() {
        stageClear = true;
        cameraProvider.Shake(0.2f);
    }

    void SetFirstStage() {
        stageCount = 0;
        targetProvider.SetRequireKnife(4);
        stageCounter.UpdateCounter(stageCount);
    }

    void NextStage() {
        stageCount++;
        targetProvider.SetRequireKnife(Random.Range(2, 11));
        stageCounter.UpdateCounter(stageCount);
        stageClear = false;
    }

    void GameClear() {
        throwAction.Remove();
    }
}

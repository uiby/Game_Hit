using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnifePool : MonoBehaviour {
    [SerializeField] GameObject knifePrefab;
    List<GameObject> pool = new List<GameObject>();

    void Awake() {
        Prepare();
    }

    void Prepare() {
        for (int n = 0; n < 20; n++) {
            var obj = (GameObject)Instantiate(knifePrefab, Vector3.zero, Quaternion.identity);
            obj.transform.SetParent(transform);
            pool.Add(obj);
        }
        pool.ForEach(n => n.SetActive(false));
    }

    public KnifeProvider Pop() {
        var obj = pool.Find(n => n.activeSelf == false);
        if (obj == null) {
            Debug.LogError("error. hasn't knife");
            return null;
        }
        obj.SetActive(true);

        return obj.GetComponent<KnifeProvider>();
    }
}

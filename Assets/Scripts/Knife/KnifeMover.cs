using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnifeMover : MonoBehaviour {
    [SerializeField, Range(5, 20)] int speed;
    Rigidbody2D rigidbody2D;

    // Use this for initialization
    void Start () {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }
    
    void FixedUpdate() {
    }

    public void Throw() {
        rigidbody2D.velocity = transform.up * speed;
    }

    public void Stop() {
        rigidbody2D.velocity = Vector2.zero;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clouds : MonoBehaviour {
    [Range(0f, 30f)]
    public float movementSpeed = 20f;

    public float startPosition = 40;
    public float endPosition = -40;

    void Start() {}

    void Update() {
        transform.position = new Vector2(transform.position.x - movementSpeed * Time.deltaTime, transform.position.y);
        if (transform.position.x < endPosition) {
            if (gameObject.tag == "cactus")
                Destroy(gameObject);
            else    
                transform.position = new Vector2(startPosition, transform.position.y);
        }
    } 
}
 
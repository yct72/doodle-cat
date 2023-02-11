using UnityEngine;

public class Motion : MonoBehaviour
{
    // public float movingSpeed = GameManager.Instance.gameSpeed;
    public float leftEnd;
    // public float rightEnd;
    private float buffer = 10f;

    private void Start() {
        leftEnd = Camera.main.ScreenToWorldPoint(Vector3.zero).x - buffer;
    }


    private void Update() {
        transform.position += Vector3.left * GameManager.Instance.gameSpeed * Time.deltaTime;
        if (transform.position.x < leftEnd) {
            if (gameObject.tag == "obstacle")
                Destroy(gameObject);
        }
    }
}

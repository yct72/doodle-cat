using UnityEngine;

public class GameManager : MonoBehaviour {
    public static GameManager Instance { get; private set; }

    public float gameSpeed { get; private set; }
    public float initialGameSpeed = 30f;
    public float increaseGameSpeed = 0.1f;

    private void Awake() {
        if (Instance == null) 
            Instance = this;
        else DestroyImmediate(gameObject);
    }

    private void OnDestroy() {
        if (Instance == this) 
            Instance = null;
    }

    private void Start() {
        gameSpeed = initialGameSpeed;
    }

    private void Update() {
        gameSpeed += increaseGameSpeed * Time.deltaTime;
    }
}

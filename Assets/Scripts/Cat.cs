using UnityEngine;

public class Cat : MonoBehaviour {
    
    private CharacterController character;
    private Vector3 direction;
    public float gravity = 9.81f * 6f;
    public float jumpUnit = 30f;

    private void Awake() {
        character = GetComponent<CharacterController>();
    }

    private void OnEnable() {
        direction = Vector3.zero;    
    }

    private void Update() {
        direction += Vector3.down * gravity * Time.deltaTime;

        if (character.isGrounded) {
            direction = Vector3.down;
            if (Input.GetKeyDown(KeyCode.Space)) {
                direction = Vector3.up * jumpUnit;
            }
        }

        character.Move(direction * Time.deltaTime);
    }
}

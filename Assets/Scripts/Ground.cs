using UnityEngine;

public class Ground : MonoBehaviour {
    
    [Range(0f, 10f)]
    public float scrollSpeed = 3f;
    
    private float offset;
    private Material mat;

    void Start() {
        // grab the material
        mat = GetComponent<Renderer>().material;
    }

    void Update() {
        offset += (Time.deltaTime * scrollSpeed) / 10f;
        mat.SetTextureOffset("_MainTex", new Vector2(offset, 0));
    }
}
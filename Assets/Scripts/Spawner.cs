using UnityEngine;

public class Spawner : MonoBehaviour
{
    [System.Serializable]
    public struct SpawnedObject {
        public GameObject prefab;
        [Range(0f, 1f)]  
        public float spawnChance;
    }

    public SpawnedObject[] objects;
    public float minSpawnRate = 1f;
    public float maxSpawnRate = 3f;


    private void OnEnable() {
        Invoke(nameof(Spawn), Random.Range(minSpawnRate, maxSpawnRate));
    }

    private void OnDisable() {
        CancelInvoke();
    }

    private void Spawn() {
        float spawnChance = Random.Range(0f, 1f);

        foreach (var obj in objects) {
            if (spawnChance < obj.spawnChance) {
                GameObject go = Instantiate(obj.prefab);
                go.transform.position += transform.position;
                break;
            } else {
                spawnChance -= obj.spawnChance;
            }
        }

        Invoke(nameof(Spawn), Random.Range(minSpawnRate, maxSpawnRate));
    }

    void Start() {
        
    }

    void Update() {
        
    }
}

using System.Collections.Generic;
using UnityEngine;

public class CarSpawner : MonoBehaviour {
    private List<Transform> _spawnPoints;
    [SerializeField] private List<GameObject> carPrefabs;

    private void Awake() {
        _spawnPoints = new List<Transform>();
        foreach (Transform child in transform) {
            _spawnPoints.Add(child);
        }
    }
    
    private void Start() {
        InvokeRepeating(nameof(SpawnCar), 0, 5);
    }
    
    private void SpawnCar() {
        var spawnPosition = Random.Range(0, _spawnPoints.Count);
        var prefabs = spawnPosition % 2 == 0 ? 1 : 0;
        
        Instantiate(carPrefabs[prefabs],  _spawnPoints[spawnPosition].position, Quaternion.identity);
    }
}

using System.Collections.Generic;
using UnityEngine;

public class NobreakSpawner : MonoBehaviour {
    private List<Transform> _spawnPoints;
    [SerializeField] private GameObject nobreakPrefab;

    private void Awake() {
        _spawnPoints = new List<Transform>();
        foreach (Transform child in transform) {
            _spawnPoints.Add(child);
        }
    }

    private void Start() {
        InvokeRepeating(nameof(SpawnNobreak), 0, 5);
    }

    private void SpawnNobreak() {
        var spawnPosition = Random.Range(0, _spawnPoints.Count);
        Instantiate(nobreakPrefab,  _spawnPoints[spawnPosition].position, Quaternion.identity);
    }

}

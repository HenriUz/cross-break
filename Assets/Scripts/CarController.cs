using UnityEngine;

public class CarController : MonoBehaviour {
    private Rigidbody2D _rigidbody;

    private int _direction = 1;

    private GameObject _player;
    private Vector3 _playerSpawn;
    
    private void Awake() {
        _rigidbody = transform.GetComponent<Rigidbody2D>();
        
        if (transform.GetComponentInChildren<SpriteRenderer>().transform.rotation.z > 0) {
            _direction = -1;
        }
    }

    private void Start() {
        _player = GameObject.Find("Player");
        _playerSpawn = new Vector3(0f, -4.45f, 0f);
    }
    
    private void FixedUpdate() {
        _rigidbody.linearVelocityX = 1.4f * _direction;
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.name == "Player") {
            _player.transform.position = _playerSpawn;   
        }
    }
}

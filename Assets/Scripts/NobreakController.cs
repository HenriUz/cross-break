using UnityEngine;

public class NobreakController : MonoBehaviour {
    private Animator _animator;

    private float _timer;
    [SerializeField] private float explosionTime;

    private Player _player;

    private void Awake() {
        _animator = transform.GetComponentInChildren<Animator>();
        _timer = Time.time;
    }

    private void Start() {
        _player = GameObject.Find("Player").GetComponent<Player>();
    }

    private void Update() {
        if (Time.time > _timer + explosionTime) {
            _animator.enabled = true;
            Destroy(gameObject, 0.5f);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision) {
        _player.AddPoint();
        Destroy(gameObject);
    }
}

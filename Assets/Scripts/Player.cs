using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour {
    private Rigidbody2D _rigidbody;

    private Vector2 _direction;
    [SerializeField]  private float speed;

    private int _points;

    private void Awake() {
        _rigidbody = transform.GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate() {
        Movement();
    }

    private void OnInteract(InputValue inputValue) {
        Application.Quit();
    }

    private void OnMove(InputValue inputValue) {
        _direction = inputValue.Get<Vector2>();
    }

    private void Movement() {
        _rigidbody.linearVelocity = _direction * (speed * Time.deltaTime);
    }

    public void AddPoint() {
        _points++;
    }

    public int GetPoint() {
        return _points;
    }
}

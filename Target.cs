using UnityEngine;

namespace Tarodev {
    public class Target : MonoBehaviour, IExplode {
        [SerializeField] private Rigidbody _rb;
        [SerializeField] private float _size = 10;
        [SerializeField] private float _speed = 10;
        public Rigidbody Rb => _rb;

        void Update() {
            var dir = new Vector3(Mathf.Cos(Time.time * _speed) * _size, Mathf.Sin(Time.time * _speed) * _size);

            _rb.velocity = dir;
        }

        public void Explode() => Destroy(gameObject);
    }
}
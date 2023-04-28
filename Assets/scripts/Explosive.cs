using UnityEngine;
public class Explosive : MonoBehaviour
{

    [SerializeField] private float _triggerForce = 0.5f;
    [SerializeField] private float _explosionRadius = 5;
    [SerializeField] private float _explosionForce = 500;
    [SerializeField] private GameObject _particles;
    [SerializeField] private bool _broken;
    [SerializeField] public float _collisionMultiplier = 100;
    [SerializeField] public GameObject _replacement;

    private void OnCollisionEnter(Collision collision)
    {
        if (_broken) return;
        
        if (collision.relativeVelocity.magnitude >= _triggerForce)
        {
            _broken = true;
            //
            var replacement = Instantiate(_replacement, transform.position, transform.rotation);
            var rbs = replacement.GetComponentsInChildren<Rigidbody>();
            //
            var surroundingObjects = Physics.OverlapSphere(transform.position, _explosionRadius);

            foreach (var rb in rbs)
            {
                rb.AddExplosionForce(collision.relativeVelocity.magnitude * _collisionMultiplier, collision.contacts[0].point, 2);
            }
            //explosion
            foreach (var obj in surroundingObjects)
            {
                var rb = obj.GetComponent<Rigidbody>();
                if (rb == null) continue;

                rb.AddExplosionForce(_explosionForce, transform.position, _explosionRadius, 1);
            }
          

            Instantiate(_particles, transform.position, Quaternion.identity);

            Destroy(gameObject);
        }
    }
}
using UnityEngine;

public class Breakable : MonoBehaviour
{
    [SerializeField] public GameObject _replacement;
    [SerializeField] public float _breakForce = 2;
    [SerializeField] public float _collisionMultiplier = 100;
    [SerializeField] private bool _broken;
    
    void OnCollisionEnter(Collision collision)
    {
        if(_broken) return;
        if (collision.relativeVelocity.magnitude >= _breakForce)
        {
            _broken = true;

            var replacement = Instantiate(_replacement, transform.position, transform.rotation);

            var rbs = replacement.GetComponentsInChildren<Rigidbody>();
            foreach (var rb in rbs)
            {
                rb.AddExplosionForce(collision.relativeVelocity.magnitude * _collisionMultiplier, collision.contacts[0].point,2);
            }

            Destroy(gameObject);
        }
    }
}

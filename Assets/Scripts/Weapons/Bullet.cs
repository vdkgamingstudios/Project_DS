using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 20f;
    public float lifetime = 5f;
    public int damage = 10;

    private void Start()
    {
        Destroy(gameObject, lifetime); // Destroy projectile after set time
    }

    private void Update()
    {
        transform.position += transform.forward * speed * Time.deltaTime;
    }

    //private void OnTriggerEnter(Collider other)
    //{
    //    // Example: Damage the target if it has a Health script
    //    Health targetHealth = other.GetComponent<Health>();
    //    if (targetHealth != null)
    //    {
    //        targetHealth.TakeDamage(damage);
    //    }

    //    Destroy(gameObject); // Destroy projectile on impact
    //}
}

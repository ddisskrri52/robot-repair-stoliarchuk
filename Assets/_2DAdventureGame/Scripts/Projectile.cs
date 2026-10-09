using UnityEngine;
public class Projectile : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        PlayerController controller =
        other.GetComponent<PlayerController>();
        if (controller != null
        && controller.health < controller.maxHealth)
        {
            controller.ChangeHealth(2);
            Destroy(gameObject);
        }
    }
}
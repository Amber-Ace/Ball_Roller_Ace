using UnityEngine;

public class Jump_Pad : MonoBehaviour
{
    public float jumpforce;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.TryGetComponent(out Rigidbody rb))
        {
            rb.AddForce(transform.up * jumpforce);
          }
    }
}

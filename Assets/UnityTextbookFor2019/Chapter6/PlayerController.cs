using UnityEngine;

namespace UnityTextbookFor2019.Chapter6
{
    [RequireComponent(typeof(Rigidbody2D))]
    public class PlayerController : MonoBehaviour
    {
        float jumpForce = 680.0f;
        [SerializeField] Rigidbody2D rigid2D;

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                rigid2D.AddForce(transform.up * jumpForce);
            }
        }

        void OnValidate()
        {
            rigid2D = GetComponent<Rigidbody2D>();
        }
    }
}

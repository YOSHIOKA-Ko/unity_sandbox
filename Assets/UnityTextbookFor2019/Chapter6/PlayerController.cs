using UnityEngine;

namespace UnityTextbookFor2019.Chapter6
{
    [RequireComponent(typeof(Rigidbody2D))]
    public class PlayerController : MonoBehaviour
    {
        [SerializeField] Rigidbody2D rigid2D;
        [SerializeField] SpriteRenderer sprite;
        [SerializeField] Animator anim;
        float jumpForce = 680.0f;
        float walkForce = 30.0f;
        float maxWalkSpeed = 2.0f;

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                rigid2D.AddForce(transform.up * jumpForce);
            }

            int key = 0;
            if (Input.GetKey(KeyCode.RightArrow)) key = 1;
            if (Input.GetKey(KeyCode.LeftArrow)) key = -1;

            float speedx = Mathf.Abs(rigid2D.velocity.x);

            if (speedx < maxWalkSpeed)
            {
                rigid2D.AddForce(transform.right * key * walkForce);
            }

            if (key == 1) sprite.flipX = false;
            if (key == -1) sprite.flipX = true;

            anim.speed = speedx / 2.0f;
        }

        void OnValidate()
        {
            rigid2D = GetComponent<Rigidbody2D>();
        }
    }
}

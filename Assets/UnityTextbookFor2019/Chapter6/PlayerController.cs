using UnityEngine;
using UnityEngine.SceneManagement;

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
            bool jump = anim.GetBool("Jump");

            if (!jump &&
                Input.GetKeyDown(KeyCode.Space) &&
                rigid2D.velocity.y == 0)
            {
                anim.SetBool("Jump", true);
                rigid2D.AddForce(transform.up * jumpForce);
            }

            if (jump &&
                rigid2D.velocity.y == 0)
            {
                anim.SetBool("Jump", false);
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

            if (jump)
            {
                anim.speed = 1.0f;
            }
            else
            {
                anim.speed = speedx / 2.0f;
            }

            if (transform.position.y < -10)
            {
                SceneManager.LoadScene("ClimbCloud");
            }
        }

        void OnTriggerEnter2D(Collider2D other)
        {
            SceneManager.LoadScene("UnityTextbookFor2019/Chapter6/Clear");
        }

        void OnValidate()
        {
            rigid2D = GetComponent<Rigidbody2D>();
        }
    }
}

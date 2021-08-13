using UnityEngine;

namespace Assets
{
    public class Player : MonoBehaviour
    {
        private BoxCollider2D boxCollider;
        private Vector3 moveDelta;

        private void Start()
        {
            boxCollider = GetComponent<BoxCollider2D>();
        }

        private void FixedUpdate()
        {
            moveDelta = Vector3.zero;

            var x = Input.GetAxisRaw("Horizontal");
            var y = Input.GetAxisRaw("Vertical");

            Debug.Log(x);
            Debug.Log(y);
        }
    }
}

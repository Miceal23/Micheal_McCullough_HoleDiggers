using UnityEngine;

public class PickSwing : MonoBehaviour
{
    [SerializeField] Animator animator;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            animator.SetBool("IsMining", true);
            Debug.Log("Mining");
        }

        if (Input.GetMouseButtonUp(0))
        {
            animator.SetBool("IsMining", false);
        }

    }
}

using UnityEngine;

public class Jump : MonoBehaviour
{
    Rigidbody rigidbody;
    public float jumpStrength = 2;
    public event System.Action Jumped;
    private bool doubleJump;

    [SerializeField, Tooltip("Prevents jumping when the transform is in mid-air.")]
    GroundCheck groundCheck;


    void Reset()
    {
        // Try to get groundCheck.
        groundCheck = GetComponentInChildren<GroundCheck>();
    }

    void Awake()
    {
        // Get rigidbody.
        rigidbody = GetComponent<Rigidbody>();
    }

    void LateUpdate()
    {
        if (groundCheck.isGrounded && !Input.GetButton("Jump"))
        {
            doubleJump = false;
        }
        // Jump when the Jump button is pressed and we are on the ground.
        if (Input.GetButtonDown("Jump"))
        {
            if (!groundCheck || groundCheck.isGrounded || doubleJump)
            {
                rigidbody.AddForce(Vector3.up * 100 * jumpStrength);
                Jumped?.Invoke();
                doubleJump = !doubleJump;
            }
        }
    }
}

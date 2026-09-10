using UnityEngine;

public class Moving1 : MonoBehaviour
{
    [SerializeField] private KeyCode upkey = KeyCode.W;

    [SerializeField] private KeyCode downkey = KeyCode.S;

    public float Velocity1 = 1.0f;

    private void Update()
    {
        GetComponent<Rigidbody2D>().linearVelocity = Vector2.zero;

        if (Input.GetKey(upkey))
        {
            GetComponent<Rigidbody2D>().linearVelocity = new Vector2(0, Velocity1);
        }
        if (Input.GetKey(downkey))
        {
            GetComponent<Rigidbody2D>().linearVelocity = new Vector2(0, -Velocity1);
        }
    }

}

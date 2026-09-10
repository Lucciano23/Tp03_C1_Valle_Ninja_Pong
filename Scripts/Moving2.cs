using UnityEngine;

public class Moving2 : MonoBehaviour
{
    [SerializeField] private KeyCode upkey = KeyCode.UpArrow;

    [SerializeField] private KeyCode downkey = KeyCode.DownArrow;

    public float Velocity2 = 1.0f;

    private void Update()
    {
        GetComponent<Rigidbody2D>().linearVelocity = Vector2.zero;

        if (Input.GetKey(upkey))
        {
            GetComponent<Rigidbody2D>().linearVelocity = new Vector2(0, Velocity2);
        }
        if (Input.GetKey(downkey))
        {
            GetComponent<Rigidbody2D>().linearVelocity = new Vector2(0, -Velocity2);
        }
    }
}

using UnityEngine;

public class Moving1 : MonoBehaviour
{
    [SerializeField] private KeyCode upkey = KeyCode.W;

    [SerializeField] private KeyCode downkey = KeyCode.S;

    public float Velocity1 = 1.0f;

    private void Update()
    {
        if (Input.GetKey(upkey))
        {
            transform.position += new Vector3(0, Velocity1 * Time.deltaTime, 0);
        }
        if (Input.GetKey(downkey))
        {
            transform.position += new Vector3(0, -Velocity1 * Time.deltaTime, 0);
        }
    }

}

using UnityEngine;

public class Moving2 : MonoBehaviour
{
    [SerializeField] private KeyCode upkey = KeyCode.UpArrow;

    [SerializeField] private KeyCode downkey = KeyCode.DownArrow;

    public float Velocity2 = 1.0f;

    private void Update()
    {
        if (Input.GetKey(upkey))
        {
            transform.position += new Vector3(0, Velocity2 * Time.deltaTime, 0);
        }
        if (Input.GetKey(downkey))
        {
            transform.position += new Vector3(0, -Velocity2 * Time.deltaTime, 0);
        }
    }
}

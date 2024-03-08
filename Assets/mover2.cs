using UnityEngine;

public class MoverByClickWASD : MonoBehaviour
{
    public float speed = 10f;
    public float dist = 0.7f;
    public float zeroMove = 0;

    private void Update()
    {
        if (Vector3.Distance(transform.position, GameObject.Find("player1").transform.position) < dist)
        {
            Destroy(GameObject.Find("player2"));
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3(speed * Time.deltaTime, zeroMove, zeroMove);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position -= new Vector3(speed * Time.deltaTime, zeroMove, zeroMove);
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += new Vector3(zeroMove, speed * Time.deltaTime, zeroMove);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position -= new Vector3(zeroMove, speed * Time.deltaTime, zeroMove);
        }
    }
}

using UnityEngine;

public class MoverByClick : MonoBehaviour
{
    public float speed = 10f;
    public float zeroMove = 0f;

    private void Update()
    {

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += new Vector3(speed * Time.deltaTime, zeroMove, zeroMove);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position -= new Vector3(speed * Time.deltaTime, zeroMove, zeroMove);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += new Vector3(0f, speed * Time.deltaTime, zeroMove);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position -= new Vector3(zeroMove, speed * Time.deltaTime, zeroMove);
        }
    }
}

using UnityEngine;

public class Bullet : MonoBehaviour
{
    private Vector3 myAngle;
    private Rigidbody2D rigbod;
    public float speed;

    public void FireMe(Vector3 angle)
    {
        rigbod = GetComponent<Rigidbody2D>();
        myAngle = angle;
        rigbod.velocity = myAngle.normalized * speed;
    }

}
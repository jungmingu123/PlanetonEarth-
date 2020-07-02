using UnityEngine;

public class Rotate : MonoBehaviour
{
    public GameObject Planet;       //기준행성 (토성)
    float speed;             //회전 속도
    Vector3 targetPosition = new Vector3(1,2,3);

    private void Update()
    {
        speed = 10f;
        OrbitAround();
    }

    void OrbitAround()
    {
        transform.RotateAround(targetPosition, Vector3.back, speed * Time.deltaTime);
        transform.RotateAround(targetPosition, Vector3.up, speed * Time.deltaTime);
    }
    //RotateAround(Vector3 point, Vector3 axis, float angle)
}


using UnityEngine;

public class CamFollow : MonoBehaviour
{
    public Transform player;
    public Vector3 offset = new Vector3(0, 5, -10);

    void Update()
    {
        transform.position = player.position + offset;
        transform.LookAt(player);
    }
}

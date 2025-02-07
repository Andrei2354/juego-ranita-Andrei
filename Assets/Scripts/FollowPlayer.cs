using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public GameObject player;
    private Vector3 offset = new Vector3(8, 6, 0);
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}

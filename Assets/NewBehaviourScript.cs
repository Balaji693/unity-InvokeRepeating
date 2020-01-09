
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject player;


    void Start()
    {
        Invoke("players", 2);
    }

    void players()
    {
        float x = Random.Range(-6.0f, 6.0f);
        float z = Random.Range(-6.0f, 6.0f);
        Instantiate(player, new Vector3(x, 2, z), Quaternion.identity);
        Destroy(player, 2f);
    }
}


using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject player;


    void Start()
    {
        InvokeRepeating("players", 2, 1);
    }

    void players()
    {
        float x = Random.Range(-2.0f, 2.0f);
        float z = Random.Range(-2.0f, 2.0f);
        Instantiate(player, new Vector3(x, 2, z), Quaternion.identity);
    }
}

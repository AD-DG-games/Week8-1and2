using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSpeed : MonoBehaviour
{
    public TerrainManager terrinManager;
    public PlayerMovement playerMovement;
    // Start is called before the first frame update
    void Start()
    {
        playerMovement = GetComponent<PlayerMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;
        int index = terrinManager.GetTerrainAtPosition(pos);
        Debug.Log(index);
        switch (index)
        {
            case 0: // Red
                playerMovement.speed = 3;
                break;
            case 1: // Blue
                playerMovement.speed = 5;
                break;
            case 2: // Green
                playerMovement.speed = 7;
                break;

            default:
                playerMovement.speed = 5;
                break;
        }
    }
}

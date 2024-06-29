using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow_Player : MonoBehaviour
{

    public GameObject Player;
    public Vector3 offset = new Vector3(0, 8, -29);

    
    void LateUpdate()
    {
        // posição pra apreciar a bunda do ricardo!
        transform.position = Player.transform.position + offset;
    }
}

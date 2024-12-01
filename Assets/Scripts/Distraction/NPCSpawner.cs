using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCSpawner : MonoBehaviour
{
    public GameObject[] NPCObject;
    // Start is called before the first frame update
    public void DestroyNPC()
    {
        for (int i = 0; i < NPCObject.Length; i++){
            Destroy(NPCObject[i]);
        }
    }
}

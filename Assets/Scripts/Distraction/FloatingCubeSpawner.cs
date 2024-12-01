using UnityEngine;

public class FloatingCubeSpawner : MonoBehaviour
{
    public GameObject cube;
    public void DestroyCube()
    {
        Destroy(cube);
    }
}

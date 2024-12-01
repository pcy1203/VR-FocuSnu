using UnityEngine;
using System.Collections;

public class LightBlinker : MonoBehaviour
{
    public Light blinkingLight; // Reference to the Light component
    public Transform playerTransform; // Reference to the player's transform
    public Vector3 offset = new Vector3(1f, 0f, 0f); // Offset from the player's position
    public float blinkDuration = 0.5f; // Duration of each blink
    public int blinkCount = 3; // Number of blinks
    public float intensity = 2.0f; // Intensity of the light

    private void Start()
    {
        if (blinkingLight == null)
        {
            blinkingLight = GetComponent<Light>();
        }
        blinkingLight.intensity = intensity;
    }

    private void Update()
    {
        if (playerTransform != null)
        {
            // Update the light's position to follow the player with an offset
            blinkingLight.transform.position = playerTransform.position + offset;
        }
    }

    public void StartBlinking()
    {
        StartCoroutine(BlinkLight());
        Update();
    }

    private IEnumerator BlinkLight()
    {
        for (int i = 0; i < blinkCount; i++)
        {
            blinkingLight.enabled = true;
            yield return new WaitForSeconds(blinkDuration);
            blinkingLight.enabled = false;
            yield return new WaitForSeconds(blinkDuration);
        }
    }
}
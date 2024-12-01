using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class DistractionController : MonoBehaviour
{
    public AudioController audioController;
    public FloatingCubeSpawner floatingCubeSpawner;
    public NPCSpawner NPCSpawner;
    public HapticFeedback2 hapticFeedback;
    public XRBaseController controller;

    public bool distractMusic = false;
    public bool distractFloating = false;
    public bool distractNPC = false;
    public bool distractHaptic = false;
    public int musicthreshold = 50;
    public int hapticThreshold = 90;

    private int randNum;

    private void Awake()
    {
        // audioController = GetComponent<AudioController>();
    }
    // Start is called before the first frame update
    void Start()
    {
        if (distractMusic)
        {
            audioController.PlayMusic();
        }

        if (distractFloating)
        {
        }else{
            floatingCubeSpawner.DestroyCube();
        }

        if (distractNPC)
        {
        }else{
            NPCSpawner.DestroyNPC();
        }
        if (distractHaptic)
        {
            hapticFeedback.TriggerHaptic(isLeftHand: true, amplitude: 0.5f, duration: 0.2f);

            // hapticFeedback.TriggerHapticFeedback(controller);
        }
    }

    // Update is called once per frame
    void Update()
    {
        randNum = Random.Range(0, 100);
        if (randNum > musicthreshold)
        {
            audioController.PlayMusic();
        }
        randNum = Random.Range(0, 100);
        // if (randNum > hapticThreshold)
        // {
        //     hapticFeedback.TriggerHapticFeedback(controller);
        // }

    }
}

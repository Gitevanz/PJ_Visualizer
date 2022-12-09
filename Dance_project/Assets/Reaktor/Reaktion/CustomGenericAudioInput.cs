
using UnityEngine;
using System.Collections;

namespace Reaktion {

[AddComponentMenu("Reaktion/Utility/Custom Generic Audio Input")]
public class CustomGenericAudioInput : MonoBehaviour
{
    public int deviceIndex;
    AudioSource audioSource;

    public float estimatedLatency { get; protected set; }

    void Awake()
    {
        // Create an audio source.
        audioSource = gameObject.AddComponent<AudioSource>();
        audioSource.playOnAwake = false;
        audioSource.loop = true;

        StartInput();
    }
    
    [ContextMenu("ShowDeviceNames")]
    private void ShowDeviceNames()
    {
        for(int i = 0; i < Microphone.devices.Length; i++)
        {
            Debug.Log("Device " + i + ": " + Microphone.devices[i]);
        }
    }
       void Update()
        {
            for (int i = 0; i < Microphone.devices.Length; i++)
            {
                Debug.Log("Device " + i + ": " + Microphone.devices[i]);
            }
        }
        void OnApplicationPause(bool paused)
    {
        if (paused)
        {
            audioSource.Stop();
            Microphone.End(Microphone.devices[deviceIndex]);
            audioSource.clip = null;
        }
        else
            StartInput();
    }

    void StartInput()
    {
        var sampleRate = AudioSettings.outputSampleRate;

        // Create a clip which is assigned to the default microphone.
        audioSource.clip = Microphone.Start(Microphone.devices[deviceIndex], true, 1, sampleRate);

        if (audioSource.clip != null)
        {
            // Wait until the microphone gets initialized.
            int delay = 0;
            while (delay <= 0) delay = Microphone.GetPosition(Microphone.devices[deviceIndex]);

            // Start playing.
            audioSource.Play();

            // Estimate the latency.
            estimatedLatency = (float)delay / sampleRate;
        }
        else
            Debug.LogWarning("GenericAudioInput: Initialization failed.");
    }
}
} // namespace Reaktion

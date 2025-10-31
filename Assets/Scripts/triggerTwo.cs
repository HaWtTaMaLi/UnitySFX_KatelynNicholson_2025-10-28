using UnityEngine;

public class triggerTwo : MonoBehaviour
{
    public AudioSource atmosphere; // if im in it's on, if im out it's off 2D audio
    public Collider atmosphereTrigger;

    private void Awake()
    {
        atmosphere = GetComponent<AudioSource>();
        atmosphereTrigger = GetComponent<Collider>();
    }
    private void OnTriggerEnter(Collider collider)
    {
        atmosphere.Play();

    }
    private void OnTriggerExit(Collider other)
    {
        atmosphere.Stop();
    }
}

using UnityEngine;

public class triggerOne : MonoBehaviour
{
    public AudioSource conversation; //pause and unpause 2D audio
    public Collider conversationTrigger;

    private void Awake()
    {
        conversation = GetComponent<AudioSource>();
        conversationTrigger = GetComponent<Collider>();
    }
    private void OnTriggerEnter(Collider collider)
    {
        conversation.Play();
    }
    private void OnTriggerExit(Collider other)
    {
        conversation.Stop();
    }
}

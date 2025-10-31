using UnityEngine;
using UnityEngine.ProBuilder.MeshOperations;

public class Pause_UnPause : MonoBehaviour
{
    public AudioSource radio; //pause and unpause 3D audio 
    public Collider radioTrigger;
    public bool isPaused = true;

    private void Awake()
    {
        radio = GetComponent<AudioSource>();
        radio.Play();
        radio.Pause();
        GetComponent<Collider>().isTrigger = true;
    }
    private void OnTriggerEnter(Collider collider)
    {
        if (collider.CompareTag("Player")) 
        {
            if (isPaused)
            {
                radio.UnPause();
                isPaused = false;
            }
            else
            {
                radio.Pause();
                isPaused = true;
            }
        }
        
    } 
}

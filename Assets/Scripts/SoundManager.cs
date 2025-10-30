using UnityEngine;
using UnityEngine.Audio;

public class SoundManager : MonoBehaviour
{
    [Header("3D AudioSource")]
    [SerializeField] public AudioSource firePlace; //always awake 3D audio
    [SerializeField] public AudioSource radio; //pause and unpause 3D audio 

    [Header("2D AudioSource")]
    [SerializeField] public AudioSource atmosphere; // if im in it's on, if im out it's off 2D audio
    [SerializeField] public AudioSource something; //pause and unpause 2D audio


    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {

        if (!other.CompareTag("Player")) 
            return;

        if (other.gameObject.CompareTag("RaidoZone"))
        {
            if(radio != null)
            {
                radio.UnPause();
            }
        }

        if (other.gameObject.CompareTag("AtmosphereZone"))
        {
            if (atmosphere != null && !atmosphere.isPlaying)
            {
                atmosphere.Play();
            }
        }

        if (other.gameObject.CompareTag("SomethingZone"))
        {
            if (something != null)
            {
                something.PlayOneShot(something.clip);
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (!other.CompareTag("Player"))
            return;

        if (other.gameObject.CompareTag("RaidoZone"))
        {
            if(radio != null)
            {
                radio.Pause();
            }
        }

        if (other.gameObject.CompareTag("AtmosphereZone"))
        {
            if (atmosphere != null)
            {
                atmosphere.Stop();
            }
        }
    }
}

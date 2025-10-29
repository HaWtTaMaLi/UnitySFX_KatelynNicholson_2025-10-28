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

    void Update()
    {
        
    }
}

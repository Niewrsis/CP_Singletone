using UnityEngine;

namespace AudioSystem
{
    [RequireComponent (typeof (AudioSource))]
    public class AudioPlayerSingleton : MonoBehaviour
    {
        [Header("References")]
        [SerializeField] private AudioClip audioClip;
        public static AudioPlayerSingleton Instance { get; private set; }

        private AudioSource _audioSource;

        private void Awake()
        {
            InitializtaionInstance();

            BackgroundMusic();
        }
        private void InitializtaionInstance()
        {
            if (Instance == null)
            {
                Instance = this;
                DontDestroyOnLoad(gameObject);
                return;
            }

            Destroy(gameObject);
        }
        private void BackgroundMusic()
        {
            _audioSource = GetComponent<AudioSource>();

            _audioSource.clip = audioClip;
            _audioSource.playOnAwake = true;
            _audioSource.loop = true;
        }
    }
}
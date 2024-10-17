using UnityEngine;
using SceneSystem;

namespace InputSystem
{
    public class InputListener : MonoBehaviour
    {
        [Header("Attrubtes")]
        [SerializeField] private KeyCode restartKey;

        private SceneManagment _restart;
        private void Start()
        {
            _restart = new();
        }
        private void Update()
        {
            RestartInput();
        }
        public void RestartInput()
        {
            if (Input.GetKeyDown(restartKey))
            {
                _restart.RestartCurrentScene();
            }
        }
    }
}
using UnityEngine.SceneManagement;

namespace SceneSystem
{
    public class SceneManagment
    {
        public void RestartCurrentScene()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
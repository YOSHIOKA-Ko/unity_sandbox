using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace UnityTextbookFor2019.Chapter6
{
    public class ClearDirector : MonoBehaviour
    {
        [SerializeField] Button restartButton;

        public void Restart ()
        {
            SceneManager.LoadScene("UnityTextbookFor2019/Chapter6/ClimbCloud");
        }
    }
}

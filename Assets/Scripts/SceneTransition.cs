using UnityEngine;
using UnityEngine.SceneManagement;

namespace InterfaceA2 {
    internal sealed class SceneTransition: MonoBehaviour {
        #region Fields

        [SerializeField] private string sceneName;

        #endregion

        #region Properties
        #endregion

        #region Ctors and Dtor

        private SceneTransition() {
            sceneName = string.Empty;
        }

        #endregion

        #region Unity User Callback Event Funcs
        #endregion

        public void ChangeScene() {
            SceneManager.LoadScene(sceneName, LoadSceneMode.Single);
        }
    }
}
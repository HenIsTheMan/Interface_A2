using UnityEngine;

namespace InterfaceA2 {
    internal sealed class PauseButton: MonoBehaviour {
        #region Fields

        [SerializeField] private GameObject WIP;

        #endregion

        #region Properties
        #endregion

        #region Ctors and Dtor

        public PauseButton() {
            WIP = null;
        }

        #endregion

        #region Unity User Callback Event Funcs

        private void Awake() {
            UnityEngine.Assertions.Assert.IsNotNull(WIP);
        }

        public void OnButtonClick() {
            WIP.SetActive(true);
        }

        #endregion
    }
}
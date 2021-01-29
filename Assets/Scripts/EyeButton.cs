using UnityEngine;

namespace InterfaceA2 {
    internal sealed class EyeButton: MonoBehaviour {
        #region Fields

        [SerializeField] private GameObject driverGO;

        #endregion

        #region Properties
        #endregion

        #region Ctors and Dtor

        public EyeButton() {
            driverGO = null;
        }

        #endregion

        #region Unity User Callback Event Funcs

        private void Awake() {
            UnityEngine.Assertions.Assert.IsNotNull(driverGO);
        }

        public void OnButtonClick() {
            driverGO.SetActive(!driverGO.activeSelf);
        }

        #endregion
    }
}
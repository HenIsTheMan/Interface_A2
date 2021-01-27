using UnityEngine;
using UnityEngine.UI;

namespace InterfaceA2 {
    internal sealed class RedLine: MonoBehaviour {
        #region Fields

        [SerializeField] private Image imgComponent;

        #endregion

        #region Properties
        #endregion

        #region Ctors and Dtor

        public RedLine() {
            imgComponent = null;
        }

        #endregion

        #region Unity User Callback Event Funcs

        private void Awake() {
            UnityEngine.Assertions.Assert.IsNotNull(imgComponent);
        }

        #endregion

        public void OnButtonClick() {
            imgComponent.enabled = !imgComponent.enabled;
        }
    }
}
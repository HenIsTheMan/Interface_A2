using TMPro;
using UnityEngine;

namespace InterfaceA2{
    internal sealed class CustomizeTextMeshPro: MonoBehaviour {
        #region Fields

        [SerializeField] private TextMeshProUGUI tmpComponent;
        [SerializeField] private string text;

        #endregion

        #region Properties
        #endregion

        #region Ctors and Dtor

        public CustomizeTextMeshPro() {
            tmpComponent = null;
            text = null;
        }

        #endregion

        #region Unity User Callback Event Funcs

        private void Awake() {
            UnityEngine.Assertions.Assert.IsNotNull(tmpComponent);
            UnityEngine.Assertions.Assert.IsNotNull(text);
        }

        private void Start() {
            tmpComponent.text = text;
        }

        #endregion
    }
}
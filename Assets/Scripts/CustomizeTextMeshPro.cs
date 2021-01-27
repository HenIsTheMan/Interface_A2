using UnityEngine;
using TMPro;

namespace InterfaceA2 {
    internal sealed class CustomizeTextMeshPro: MonoBehaviour {
        #region Fields

        [SerializeField] private TextMeshProUGUI tmpComponent;
        [SerializeField] private string text;
        [SerializeField] private float posMultiplierX;
        [SerializeField] private float posMultiplierY;

        #endregion

        #region Properties
        #endregion

        #region Ctors and Dtor

        public CustomizeTextMeshPro() {
            tmpComponent = null;
            text = string.Empty;
            posMultiplierX = 0.0f;
            posMultiplierY = 0.0f;
        }

        #endregion

        #region Unity User Callback Event Funcs

        private void Awake() {
            UnityEngine.Assertions.Assert.IsNotNull(tmpComponent);
        }

        private void Start() {
            tmpComponent.text = text;

            tmpComponent.rectTransform.localPosition = new Vector3(Screen.width * posMultiplierX, Screen.height * posMultiplierY, 0.0f);
        }

        #endregion
    }
}
using UnityEngine;
using TMPro;

namespace InterfaceA2 {
    internal sealed class Customization1: MonoBehaviour {
        #region Fields

        [SerializeField] private TextMeshProUGUI tmpComponent;
        [SerializeField] private string text;
        [SerializeField] private float posMultiplierX;
        [SerializeField] private float posMultiplierY;

        #endregion

        #region Properties
        #endregion

        #region Ctors and Dtor

        public Customization1() {
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
            tmpComponent.rectTransform.localScale = new Vector3(
                tmpComponent.rectTransform.localScale.x * Screen.width / 800.0f,
                tmpComponent.rectTransform.localScale.y * Screen.height / 600.0f,
                1.0f
            );
        }

        #endregion
    }
}
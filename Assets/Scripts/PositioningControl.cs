using TMPro;
using UnityEngine;

namespace InterfaceA2 {
    internal sealed class PositioningControl: MonoBehaviour {
        #region Fields

        [SerializeField] private TextMeshProUGUI tmpComponent;
        [SerializeField] private float posMultiplierX;
        [SerializeField] private float posMultiplierY;

        #endregion

        #region Properties
        #endregion

        #region Ctors and Dtor

        public PositioningControl() {
            tmpComponent = null;
            posMultiplierX = 0.0f;
            posMultiplierY = 0.0f;
        }

        #endregion

        #region Unity User Callback Event Funcs

        private void Awake() {
            UnityEngine.Assertions.Assert.IsNotNull(tmpComponent);
        }

        private void Update() {
            //Vector2 renderedVals = tmpComponent.GetRenderedValues(false);
            //tmpComponent.rectTransform.localPosition = new Vector3(Screen.width * posMultiplierX + renderedVals.x * 0.5f, Screen.height * posMultiplierY + renderedVals.y * 0.5f, 0.0f);
            tmpComponent.rectTransform.localPosition = new Vector3(Screen.width * posMultiplierX, Screen.height * posMultiplierY, 0.0f);
        }

        #endregion
    }
}
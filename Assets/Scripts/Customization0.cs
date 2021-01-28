using UnityEngine;

namespace InterfaceA2 {
    internal sealed class Customization0: MonoBehaviour {
        #region Fields

        [SerializeField] private float posMultiplierX;
        [SerializeField] private float posMultiplierY;
        [SerializeField] private float scaleX;
        [SerializeField] private float scaleY;

        #endregion

        #region Properties
        #endregion

        #region Ctors and Dtor

        public Customization0() {
            posMultiplierX = 0.0f;
            posMultiplierY = 0.0f;
            scaleX = 1.0f;
            scaleY = 1.0f;
        }

        #endregion

        #region Unity User Callback Event Funcs

        private void Start() {
            float HCF = MathHelpers.GCD(Screen.width, Screen.height);
            float simplestTermScreenWidth = Screen.width / HCF;
            float simplestTermScreenHeight = Screen.height / HCF;

            RectTransform myRectTransform = (RectTransform)gameObject.transform;
            myRectTransform.localPosition = new Vector3(Screen.width * posMultiplierX, Screen.height * posMultiplierY, 0.0f);
            myRectTransform.localScale = new Vector3(scaleX * Screen.width / (simplestTermScreenWidth * 200.0f), scaleY * Screen.height / (simplestTermScreenHeight * 200.0f), 1.0f);
        }

        #endregion
    }
}
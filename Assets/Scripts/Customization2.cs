using UnityEngine;
using UnityEngine.UI;

namespace InterfaceA2 {
    internal sealed class Customization2: MonoBehaviour {
        #region Fields

        [SerializeField] private float posMultiplierX;
        [SerializeField] private float posMultiplierY;
        [SerializeField] private float gapMultiplierX;
        [SerializeField] private float gapMultiplierY;
        [SerializeField] private float scaleX;
        [SerializeField] private float scaleY;

        #endregion

        #region Properties
        #endregion

        #region Ctors and Dtor

        public Customization2() {
            posMultiplierX = 0.0f;
            posMultiplierY = 0.0f;
            gapMultiplierX = 0.0f;
            gapMultiplierY = 0.0f;
            scaleX = 1.0f;
            scaleY = 1.0f;
        }

        #endregion

        #region Unity User Callback Event Funcs

        private void Start() {
            float aspectRatio = Screen.width / Screen.height;
            float gapX = 1.0f / Screen.width;
            float gapY = 1.0f / Screen.height;

            RectTransform myRectTransform = (RectTransform)gameObject.transform;
            myRectTransform.localPosition = new Vector3(Screen.width * posMultiplierX + gapX * gapMultiplierX, Screen.height * posMultiplierY + gapY * gapMultiplierY, 0.0f);
            myRectTransform.localScale = new Vector3(
                scaleX * aspectRatio,
                scaleY * aspectRatio,
                1.0f
            );
        }

        #endregion
    }
}
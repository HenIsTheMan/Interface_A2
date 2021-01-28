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
            float aspectRatio = Screen.width / Screen.height;

            RectTransform myRectTransform = (RectTransform)gameObject.transform;
            myRectTransform.localPosition = new Vector3(Screen.width * posMultiplierX, Screen.height * posMultiplierY, 0.0f);
            myRectTransform.localScale = new Vector3(
                scaleX * aspectRatio,
                scaleY * aspectRatio,
                1.0f
            );
        }

        #endregion
    }
}
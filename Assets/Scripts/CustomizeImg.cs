using UnityEngine;

namespace InterfaceA2 {
    internal sealed class CustomizeImg: MonoBehaviour {
        #region Fields

        [SerializeField] private float posMultiplierX;
        [SerializeField] private float posMultiplierY;
        [SerializeField] private float scaleX;
        [SerializeField] private float scaleY;

        #endregion

        #region Properties
        #endregion

        #region Ctors and Dtor

        public CustomizeImg() {
            posMultiplierX = 0.0f;
            posMultiplierY = 0.0f;
            scaleX = 1.0f;
            scaleY = 1.0f;
        }

        #endregion

        #region Unity User Callback Event Funcs

        private void Start() {
            RectTransform myRectTransform = (RectTransform)gameObject.transform;
            myRectTransform.localPosition = new Vector3(Screen.width * posMultiplierX, Screen.height * posMultiplierY, 0.0f);
            myRectTransform.localScale = new Vector3(scaleX, scaleY, 1.0f);
        }

        #endregion
    }
}
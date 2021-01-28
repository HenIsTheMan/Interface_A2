using UnityEngine;

namespace InterfaceA2 {
    internal sealed class Customization2: MonoBehaviour {
        #region Fields

        [SerializeField] private float posOffsetX;
        [SerializeField] private float posOffsetY;
        [SerializeField] private float scaleX;
        [SerializeField] private float scaleY;

        #endregion

        #region Properties
        #endregion

        #region Ctors and Dtor

        public Customization2() {
            posOffsetX = 0.0f;
            posOffsetY = 0.0f;
            scaleX = 1.0f;
            scaleY = 1.0f;
        }

        #endregion

        #region Unity User Callback Event Funcs

        private void Start() {
            float aspectRatio = Screen.width / Screen.height;

            RectTransform myRectTransform = (RectTransform)gameObject.transform;
            RectTransform parentRectTransform = (RectTransform)gameObject.transform.parent;
            myRectTransform.localPosition = new Vector3(parentRectTransform.localPosition.x + posOffsetX, parentRectTransform.localPosition.y + posOffsetY, 0.0f);
            myRectTransform.localScale = new Vector3(
                scaleX * aspectRatio,
                scaleY * aspectRatio,
                1.0f
            );
        }

        #endregion
    }
}
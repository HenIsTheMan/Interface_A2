using UnityEngine;

namespace InterfaceA2 {
    internal sealed class UpAndDownAnim: MonoBehaviour {
        #region Fields

        private float elapsedTime;
        [SerializeField] private float mag;
        [SerializeField] private float spd;
        [SerializeField] private float localPosX;
        [SerializeField] private float localPosY;

        #endregion

        #region Properties
        #endregion

        #region Ctors and Dtor

        public UpAndDownAnim() {
            elapsedTime = 0.0f;
            mag = 0.0f;
            spd = 0.0f;
            localPosX = 0.0f;
            localPosY = 0.0f;
        }

        #endregion

        #region Unity User Callback Event Funcs

        private void Update() {
            elapsedTime += Time.deltaTime;

            ((RectTransform)gameObject.transform).localPosition = new Vector3(localPosX, localPosY + Mathf.Cos(elapsedTime * spd) * mag, 0.0f);
        }

        #endregion
    }
}
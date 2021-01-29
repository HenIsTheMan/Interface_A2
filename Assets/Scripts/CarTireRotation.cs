using UnityEngine;

namespace InterfaceA2 {
    internal sealed class CarTireRotation: MonoBehaviour {
        #region Fields

        private float angle;

        #endregion

        #region Properties

        public float AngleChange {
            get;
            set;
        }

        #endregion

        #region Ctors and Dtor

        public CarTireRotation() {
            angle = 0.0f;
        }

        #endregion

        #region Unity User Callback Event Funcs

        private void Update() {
            angle += AngleChange * Time.deltaTime;
            ((RectTransform)gameObject.transform).eulerAngles = new Vector3(0.0f, 0.0f, angle);
        }

        #endregion
    }
}
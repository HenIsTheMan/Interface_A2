using UnityEngine;

namespace InterfaceA2 {
    internal sealed class MathHelpers: MonoBehaviour { //Static class
        #region Fields
        #endregion

        #region Properties
        #endregion

        #region Ctors and Dtor

        private MathHelpers() {
        }

        #endregion

        #region Unity User Callback Event Funcs
        #endregion

        public static float GCD(float a, float b) {
            return !Mathf.Approximately(b, 0.0f) ? GCD(b, a % b) : a;
        }
    }
}
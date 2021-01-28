using UnityEngine;

namespace InterfaceA2 {
    internal sealed class RotationAccelerometerPart1: MonoBehaviour {
        #region Fields

        [SerializeField] private float startAngle;
        [SerializeField] private float endAngle;
        [SerializeField] private LoadingPercentage loadingPercentageScript;
        private RectTransform myRectTransform;

        #endregion

        #region Properties
        #endregion

        #region Ctors and Dtor

        public RotationAccelerometerPart1() {
            startAngle = 0.0f;
            endAngle = 0.0f;
            loadingPercentageScript = null;
        }

        #endregion

        #region Unity User Callback Event Funcs

        private void Awake() {
            UnityEngine.Assertions.Assert.IsNotNull(loadingPercentageScript);
            myRectTransform = (RectTransform)gameObject.transform;
        }

        private void Update() {
            float lerpFactor = (float)loadingPercentageScript.Percentage / 100.0f;
            myRectTransform.eulerAngles = new Vector3(0.0f, 0.0f, (1.0f - lerpFactor) * startAngle + lerpFactor * endAngle);
        }

        #endregion
    }
}
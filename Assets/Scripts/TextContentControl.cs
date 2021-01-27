using UnityEngine;

namespace InterfaceA2 {
    internal sealed class TextContentControl: MonoBehaviour {
        #region Fields

        private float BT;
        private float elapsedTime;
        [SerializeField] private float delay;
        [SerializeField] private string[] loadingTexts;
        private int loadingTextsLen;

        #endregion

        #region Properties
        #endregion

        #region Ctors and Dtor

        public TextContentControl() {
            BT = 0.0f;
            elapsedTime = 0.0f;
            delay = 0.0f;
            loadingTexts = null;
            loadingTextsLen = 0;
        }

        #endregion

        #region Unity User Callback Event Funcs

        private void Awake() {
            UnityEngine.Assertions.Assert.IsNotNull(loadingTexts);
            loadingTextsLen = loadingTexts.Length;
        }

        private void Update() {
            elapsedTime += Time.deltaTime;

            if(BT <= elapsedTime) {
                for(int i = 0; i < loadingTextsLen; ++i) {
                }

                BT = elapsedTime + delay;
            }
        }

        #endregion
    }
}
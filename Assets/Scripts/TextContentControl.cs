using UnityEngine;

namespace InterfaceA2 {
    internal sealed class TextContentControl: MonoBehaviour {
        #region Fields

        private float BT;
        private float elapsedTime;
        [SerializeField] private float minDelay;
        [SerializeField] private float maxDelay;
        [SerializeField] private string[] loadingTexts;
        private int loadingTextsLen;

        [SerializeField] private EllipsesControl ellipsesControlScript;

        #endregion

        #region Properties
        #endregion

        #region Ctors and Dtor

        public TextContentControl() {
            BT = 0.0f;
            elapsedTime = 0.0f;
            minDelay = 0.0f;
            maxDelay = 0.0f;
            loadingTexts = null;
            loadingTextsLen = 0;

            ellipsesControlScript = null;
        }

        #endregion

        #region Unity User Callback Event Funcs

        private void Awake() {
            UnityEngine.Assertions.Assert.IsNotNull(loadingTexts);
            loadingTextsLen = loadingTexts.Length;

            UnityEngine.Assertions.Assert.IsNotNull(ellipsesControlScript);
        }

        private void Update() {
            elapsedTime += Time.deltaTime;

            if(BT <= elapsedTime) {
                int dotCount = ellipsesControlScript.DotCount;
                ellipsesControlScript.TmpComponent.text = loadingTexts[Random.Range(0, loadingTextsLen - 1)];
                for(int i = 0; i < dotCount; ++i) {
                    ellipsesControlScript.TmpComponent.text += '.';
                }

                BT = elapsedTime + Random.Range(minDelay, maxDelay);
            }
        }

        #endregion
    }
}
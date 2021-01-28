using TMPro;
using UnityEngine;

namespace InterfaceA2 {
    internal sealed class TipTextContentControl: MonoBehaviour {
        #region Fields

        private float BT;
        private float elapsedTime;
        [SerializeField] private float delay;
        [SerializeField] private string[] tipTexts;
        private int tipTextsLen;
        private static int randIndex = -1;

        [SerializeField] private TextMeshProUGUI tmpComponent;

        #endregion

        #region Properties
        #endregion

        #region Ctors and Dtor

        public TipTextContentControl() {
            BT = 0.0f;
            elapsedTime = 0.0f;
            delay = 0.0f;
            tipTexts = null;
            tipTextsLen = 0;

            tmpComponent = null;
        }

        #endregion

        #region Unity User Callback Event Funcs

        private void Awake() {
            UnityEngine.Assertions.Assert.IsNotNull(tipTexts);
            tipTextsLen = tipTexts.Length;

            UnityEngine.Assertions.Assert.IsNotNull(tmpComponent);
        }

        private void Update() {
            elapsedTime += Time.deltaTime;

            if(BT <= elapsedTime) {
                randIndex = Random.Range(0, tipTextsLen);
            }
        }

        private void LateUpdate() {
            if(BT <= elapsedTime) {
                tmpComponent.text = tipTexts[randIndex];
                BT = elapsedTime + delay;
            }
        }

        #endregion
    }
}
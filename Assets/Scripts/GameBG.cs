using UnityEngine;

namespace InterfaceA2 {
    internal sealed class GameBG: MonoBehaviour {
        #region Fields

        const float resetTime = 0.2f;
        private float currTime = 0.0f;
        private int clickCount;
        [SerializeField] private Nitro nitroScript;

        #endregion

        #region Properties
        #endregion

        #region Ctors and Dtor

        public GameBG() {
            clickCount = 0;
            nitroScript = null;
        }

        #endregion

        #region Unity User Callback Event Funcs

        private void Awake() {
            UnityEngine.Assertions.Assert.IsNotNull(nitroScript);
        }

        private void Update() {
            if(clickCount == 1) {
                currTime += Time.deltaTime;
            } else if(clickCount == 2) {
                nitroScript.IsUsingNitro = true;
                clickCount = 0;
                currTime = 0.0f;
            }

            if(currTime >= resetTime) {
                clickCount = 0;
                currTime = 0.0f;
            }
        }

        #endregion

        public void OnButtonClick() {
            ++clickCount;
        }
    }
}
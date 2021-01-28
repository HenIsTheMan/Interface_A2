using UnityEngine;
using UnityEngine.UI;

namespace InterfaceA2 {
    internal sealed class ImgControl: MonoBehaviour {
        #region Fields

        private float BT;
        private float elapsedTime;
        [SerializeField] private float minDelay;
        [SerializeField] private float maxDelay;
        [SerializeField] private Image imgBG;
        [SerializeField] private Image imgFG;

        [SerializeField] private Sprite[] sprites;
        [SerializeField] private Sprite[] blurredSprites;
        private int arrLen;
        private int currIndex;

        #endregion

        #region Properties
        #endregion

        #region Ctors and Dtor

        public ImgControl() {
            BT = 0.0f;
            elapsedTime = 0.0f;
            minDelay = 0.0f;
            maxDelay = 0.0f;
            imgBG = null;
            imgFG = null;

            sprites = null;
            blurredSprites = null;
            arrLen = 0;
            currIndex = 0;
        }

        #endregion

        #region Unity User Callback Event Funcs

        private void Awake() {
            UnityEngine.Assertions.Assert.IsNotNull(imgBG);
            UnityEngine.Assertions.Assert.IsNotNull(imgFG);

            UnityEngine.Assertions.Assert.IsNotNull(sprites);
            UnityEngine.Assertions.Assert.IsNotNull(blurredSprites);

            arrLen = sprites.Length;
            UnityEngine.Assertions.Assert.AreEqual(arrLen, blurredSprites.Length);
        }

        private void Start() {
            //imgBG.preserveAspect = false;
            //imgFG.preserveAspect = false;
        }

        private void Update() {
            elapsedTime += Time.deltaTime;

            if(BT <= elapsedTime) {
                currIndex = Random.Range(0, arrLen);
            }
        }

        private void LateUpdate() {
            if(BT <= elapsedTime) {
                imgBG.sprite = blurredSprites[currIndex];
                imgFG.sprite = sprites[currIndex];

                BT = elapsedTime + Random.Range(minDelay, maxDelay);
            }
        }

        #endregion
    }
}
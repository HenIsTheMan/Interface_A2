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
        private int spritesLen;
        private Sprite currSprite;

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
            spritesLen = 0;
            currSprite = null;
        }

        #endregion

        #region Unity User Callback Event Funcs

        private void Awake() {
            UnityEngine.Assertions.Assert.IsNotNull(imgBG);
            UnityEngine.Assertions.Assert.IsNotNull(imgFG);
            UnityEngine.Assertions.Assert.IsNotNull(sprites);
            spritesLen = sprites.Length;
        }

        private void Update() {
            elapsedTime += Time.deltaTime;

            if(BT <= elapsedTime) {
                currSprite = sprites[Random.Range(0, spritesLen)];
            }
        }

        private void LateUpdate() {
            if(BT <= elapsedTime) {
                imgBG.sprite = imgFG.sprite = currSprite;

                BT = elapsedTime + Random.Range(minDelay, maxDelay);
            }
        }

        #endregion
    }
}
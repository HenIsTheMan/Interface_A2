using UnityEngine;

namespace InterfaceA2 {
    internal sealed class Nitro: MonoBehaviour {
        #region Fields

        private bool isUsingNitro;
        private float nitroAmt;
        [SerializeField] private float maxNitroAmt;
        [SerializeField] private float nitroIncreaseFactor;
        [SerializeField] private float nitroDecreaseFactor;
        [SerializeField] private float yPosOG;

        #endregion

        #region Properties

        public float NitroAmt {
            get {
                return nitroAmt;
            }
            set {
                nitroAmt = value;
            }
        }

        #endregion

        #region Ctors and Dtor

        public Nitro() {
            isUsingNitro = false;
            nitroAmt = 0.0f;
            maxNitroAmt = 0.0f;
            nitroIncreaseFactor = 0.0f;
            nitroDecreaseFactor = 0.0f;
            yPosOG = 0.0f;
        }

        #endregion

        #region Unity User Callback Event Funcs

        private void Update() {
            nitroAmt += (isUsingNitro ? nitroDecreaseFactor : nitroIncreaseFactor) * Time.deltaTime;
            if(nitroAmt > maxNitroAmt) {
                nitroAmt = maxNitroAmt;
            }

            float ratio = nitroAmt / maxNitroAmt;

            Vector3 localPos = ((RectTransform)gameObject.transform).localPosition;
            ((RectTransform)gameObject.transform).localPosition = new Vector3(localPos.x, yPosOG - (1.0f - ratio) * 0.5f * ((RectTransform)gameObject.transform).rect.height, localPos.z);

            Vector3 localScale = ((RectTransform)gameObject.transform).localScale;
            ((RectTransform)gameObject.transform).localScale = new Vector3(localScale.x, ratio, localScale.z);
        }

        #endregion
    }
}
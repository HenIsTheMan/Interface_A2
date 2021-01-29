using UnityEngine;
using UnityEngine.UI;

namespace InterfaceA2 {
    internal sealed class BubbleControl: MonoBehaviour {
        #region Fields

        private float BT;
        private float elapsedTime;
        [SerializeField] private float delay;
        [SerializeField] private Image missileImg;
        [SerializeField] private Image refMissileImg;

        #endregion

        #region Properties
        #endregion

        #region Ctors and Dtor

        public BubbleControl() {
            BT = 0.0f;
            elapsedTime = 0.0f;
            delay = 0.0f;
            missileImg = null;
            refMissileImg = null;
        }

        #endregion

        #region Unity User Callback Event Funcs

        private void Awake() {
            UnityEngine.Assertions.Assert.IsNotNull(missileImg);
        }

        private void Update() {
            elapsedTime += Time.deltaTime;

            if((refMissileImg == null || (refMissileImg != null && refMissileImg.enabled))
                && !missileImg.enabled
                && BT <= elapsedTime
                && Random.Range(1, 101) >= 99
            ) {
                missileImg.enabled = true;
                BT = elapsedTime + delay;
            }
        }

        #endregion
    }
}
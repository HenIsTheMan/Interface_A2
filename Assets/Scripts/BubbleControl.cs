using UnityEngine;
using UnityEngine.UI;

using Random = UnityEngine.Random;

namespace InterfaceA2 {
    internal sealed class BubbleControl: MonoBehaviour {
        #region Fields

        private float timeBeforeSpawning;
        [SerializeField] private float maxTimeBeforeSpawning;
        [SerializeField] private Image missileImg;

        #endregion

        #region Properties
        #endregion

        #region Ctors and Dtor

        public BubbleControl() {
            timeBeforeSpawning = 0.0f;
            maxTimeBeforeSpawning = 0.0f;
            missileImg = null;
        }

        #endregion

        #region Unity User Callback Event Funcs

        private void Awake() {
            UnityEngine.Assertions.Assert.IsNotNull(missileImg);
        }

        private void Update() {
            if(timeBeforeSpawning > 0.0f) {
                timeBeforeSpawning -= Time.deltaTime;
            } else if(!missileImg.enabled) {
                missileImg.enabled = true;
            }
        }

        #endregion

        public void OnButtonClick() {
            missileImg.enabled = false;
            timeBeforeSpawning = maxTimeBeforeSpawning;
        }
    }
}
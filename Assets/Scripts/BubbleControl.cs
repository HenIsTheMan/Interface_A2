using UnityEngine;
using UnityEngine.UI;

namespace InterfaceA2 {
    internal sealed class BubbleControl: MonoBehaviour {
        #region Fields

        private float timeBeforeShowing;
        [SerializeField] private float maxTimeBeforeShowing;
        [SerializeField] private GameObject missilePrefab;
        [SerializeField] private Image missileImg;
        [SerializeField] private Vector3 missileStartPos;

        #endregion

        #region Properties
        #endregion

        #region Ctors and Dtor

        public BubbleControl() {
            timeBeforeShowing = 0.0f;
            maxTimeBeforeShowing = 0.0f;
            missilePrefab = null;
            missileImg = null;
        }

        #endregion

        #region Unity User Callback Event Funcs

        private void Awake() {
            UnityEngine.Assertions.Assert.IsNotNull(missilePrefab);
            UnityEngine.Assertions.Assert.IsNotNull(missileImg);
        }

        private void Update() {
            if(timeBeforeShowing > 0.0f) {
                timeBeforeShowing -= Time.deltaTime;
            } else if(!missileImg.enabled) {
                missileImg.enabled = true;
            }
        }

        #endregion

        public void OnButtonClick() {
            if(missileImg.enabled) {
                missileImg.enabled = false;
                timeBeforeShowing = maxTimeBeforeShowing;

                GameObject missile = Instantiate(missilePrefab, missileStartPos, Quaternion.identity);
                missile.transform.SetParent(gameObject.transform.parent, false);
            }
        }
    }
}
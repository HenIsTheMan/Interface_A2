using UnityEngine;

namespace InterfaceA2 {
    internal sealed class MissileTravel: MonoBehaviour {
        #region Fields

        [SerializeField] private float spd;
        [SerializeField] private float yPosMax;

        #endregion

        #region Properties
        #endregion

        #region Ctors and Dtor

        private MissileTravel() {
            spd = 0.0f;
            yPosMax = 0.0f;
        }

        #endregion

        #region Unity User Callback Event Funcs

        private void Start() {
        }

        private void FixedUpdate() {
            if(((RectTransform)gameObject.transform).localPosition.y > yPosMax) {
                Destroy(gameObject);
                return;
            }

            transform.Translate(spd * Vector3.up * Time.deltaTime, Space.World);
        }

        #endregion
    }
}
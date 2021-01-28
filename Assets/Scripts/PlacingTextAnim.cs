using UnityEngine;

namespace InterfaceA2 {
    internal sealed class PlacingTextAnim: MonoBehaviour {
        #region Fields

        private float timeAlive;

        #endregion

        #region Properties

        public float AnimDuration {
            get;
            set;
        }

        public float StartPosX {
            get;
            set;
        }

        public float EndPosX {
            get;
            set;
        }

        #endregion

        #region Ctors and Dtor

        public PlacingTextAnim() {
            timeAlive = 0.0f;
        }

        #endregion

        #region Unity User Callback Event Funcs

        private void Update() {
            timeAlive += Time.deltaTime;

            if(timeAlive <= AnimDuration) {
                float lerpFactor = EaseInSine(Mathf.Cos(timeAlive) * 0.5f + 0.5f);
                Vector3 localPos = ((RectTransform)gameObject.transform).localPosition;
                ((RectTransform)gameObject.transform).localPosition = new Vector3((1.0f - lerpFactor) * StartPosX + lerpFactor * EndPosX, localPos.y, localPos.z);
            }
        }

        #endregion

        private float EaseInSine(float x) {
            return 1.0f - Mathf.Cos((x * Mathf.PI) * 0.5f);
        }
    }
}
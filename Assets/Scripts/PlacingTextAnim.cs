using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace InterfaceA2 {
    internal sealed class PlacingTextAnim: MonoBehaviour {
        #region Fields

        private bool shldAnimate;
        private float timeAlive;
        [SerializeField] private TMP_FontAsset localPlayerFont;

        #endregion

        #region Properties

        public bool ShldSetAsLocalPlayer {
            get;
            set;
        }

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

        public GameObject MyGrayBar {
            get;
            set;
        }

        #endregion

        #region Ctors and Dtor

        public PlacingTextAnim() {
            shldAnimate = true;
            timeAlive = 0.0f;
            localPlayerFont = null;
        }

        #endregion

        #region Unity User Callback Event Funcs

        private void Awake() {
            UnityEngine.Assertions.Assert.IsNotNull(localPlayerFont);
        }

        private void Update() {
            timeAlive += Time.deltaTime;

            if(shldAnimate) {
                if(timeAlive > AnimDuration) {
                    timeAlive = AnimDuration;
                    shldAnimate = false;
                }

                float lerpFactor = EaseInExpo(timeAlive);
                Vector3 localPos = ((RectTransform)gameObject.transform).localPosition;
                ((RectTransform)gameObject.transform).localPosition = new Vector3((1.0f - lerpFactor) * StartPosX + lerpFactor * EndPosX, localPos.y, localPos.z);
            }
            
            if(ShldSetAsLocalPlayer) {
                gameObject.GetComponent<TextMeshProUGUI>().font = localPlayerFont;
                MyGrayBar.GetComponent<Image>().color = new Color(0.27f, 0.27f, 0.27f);
                ShldSetAsLocalPlayer = false;
            }
        }

        #endregion

        private float EaseInExpo(float x) {
            return Mathf.Approximately(x, 0.0f) ? 0.0f : Mathf.Pow(2.0f, 10.0f * x - 10.0f);
        }
    }
}
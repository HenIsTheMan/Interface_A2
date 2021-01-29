using TMPro;
using UnityEngine;

namespace InterfaceA2 {
    internal sealed class LoadingPercentage: MonoBehaviour {
        #region Fields

        private float BT;
        private float elapsedTime;
        [SerializeField] private float minShortDelay;
        [SerializeField] private float maxShortDelay;
        [SerializeField] private float minLongDelay;
        [SerializeField] private float maxLongDelay;
        [SerializeField] private int chanceForShortDelay;
        private int percentage;
        private TextMeshProUGUI tmpComponent;
        [SerializeField] private SceneTransition sceneTransitionScript;

        #endregion

        #region Properties

        public int Percentage {
            get {
                return percentage;
            }
        }

        #endregion

        #region Ctors and Dtor

        public LoadingPercentage() {
            BT = 0.0f;
            elapsedTime = 0.0f;
            minShortDelay = 0.0f;
            maxShortDelay = 0.0f;
            minLongDelay = 0.0f;
            maxLongDelay = 0.0f;
            chanceForShortDelay = 0;
            percentage = 0;
            tmpComponent = null;
            sceneTransitionScript = null;
        }

        #endregion

        #region Unity User Callback Event Funcs

        private void Awake() {
            tmpComponent = gameObject.GetComponent<TextMeshProUGUI>();

            UnityEngine.Assertions.Assert.IsNotNull(sceneTransitionScript);
        }

        private void Update() {
            elapsedTime += Time.deltaTime;

            if(BT <= elapsedTime) {
                if(percentage < 100) {
                    tmpComponent.text = (++percentage).ToString() + '%';
                    BT = elapsedTime + (Random.Range(1, 101) <= chanceForShortDelay ? Random.Range(minShortDelay, maxShortDelay) : Random.Range(minLongDelay, maxLongDelay));
                }

                if(percentage == 100) {
                    sceneTransitionScript.ChangeScene();
                    return;
                }
            }
        }

        #endregion
    }
}
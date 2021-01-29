using System;
using TMPro;
using UnityEngine;

namespace InterfaceA2 {
    internal sealed class RaceElapsedTime: MonoBehaviour {
        #region Fields

        private float elapsedTimeInMilliseconds;
        private TextMeshProUGUI tmpComponent;
        [SerializeField] private SceneTransition sceneTransitionScript;

        #endregion

        #region Properties
        #endregion

        #region Ctors and Dtor

        public RaceElapsedTime() {
            elapsedTimeInMilliseconds = 0.0f;
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
            elapsedTimeInMilliseconds += Time.deltaTime * 1000.0f;
            TimeSpan t = TimeSpan.FromMilliseconds(elapsedTimeInMilliseconds);
            tmpComponent.text = string.Format("{0:D2}:{1:D2}:{2:D3}",
                t.Minutes,
                t.Seconds,
                t.Milliseconds
            );

            if(t.Minutes == 1) {
                sceneTransitionScript.ChangeScene();
            }
        }

        #endregion
    }
}
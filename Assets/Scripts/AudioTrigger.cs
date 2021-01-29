using UnityEngine;

namespace InterfaceA2 {
    internal sealed class AudioTrigger: MonoBehaviour {
        #region Fields

        [SerializeField] private AudioSource audioSrcComponent;

        #endregion

        #region Properties
        #endregion

        #region Ctors and Dtor

        public AudioTrigger() {
            audioSrcComponent = null;
        }

        #endregion

        #region Unity User Callback Event Funcs

        private void Awake() {
            UnityEngine.Assertions.Assert.IsNotNull(audioSrcComponent);
        }

        #endregion

        public void PlayAudio() {
            audioSrcComponent.Play();
        }

        public void StopAudio() {
            audioSrcComponent.Stop();
        }
    }
}
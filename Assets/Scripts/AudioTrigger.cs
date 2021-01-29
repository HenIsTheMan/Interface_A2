using UnityEngine;

namespace InterfaceA2 {
    internal sealed class AudioTrigger: MonoBehaviour {
        #region Fields

        [SerializeField] private AudioSource audioSourceComponent;

        #endregion

        #region Properties
        #endregion

        #region Ctors and Dtor

        public AudioTrigger() {
            audioSourceComponent = null;
        }

        #endregion

        #region Unity User Callback Event Funcs

        private void Awake() {
            UnityEngine.Assertions.Assert.IsNotNull(audioSourceComponent);
        }

        #endregion

        public void PlayAudio() {
            audioSourceComponent.Play();
        }

        public void StopAudio() {
            audioSourceComponent.Stop();
        }
    }
}
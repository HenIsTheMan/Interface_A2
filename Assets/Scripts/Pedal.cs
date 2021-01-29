using TMPro;
using UnityEngine;

namespace InterfaceA2 {
    internal sealed class Pedal: MonoBehaviour {
        #region Fields

        private bool isHeldDown;
        private float vel;
        [SerializeField] private float maxVel;
        [SerializeField] private float accel;
        [SerializeField] private float decel;
        [SerializeField] private TextMeshProUGUI spdTmpComponent;

        #endregion

        #region Properties
        #endregion

        #region Ctors and Dtor

        public Pedal() {
            isHeldDown = false;
            vel = 0.0f;
            maxVel = 0.0f;
            accel = 0.0f;
            decel = 0.0f;
            spdTmpComponent = null;
        }

        #endregion

        #region Unity User Callback Event Funcs

        private void Awake() {
            UnityEngine.Assertions.Assert.IsNotNull(spdTmpComponent);
        }

        private void Update() {
            isHeldDown = true; //Pedal is being held down??
        }

        private void FixedUpdate() {
            vel += (isHeldDown ? accel : decel) * Time.deltaTime;
            vel = Mathf.Clamp(vel, 0.0f, maxVel);

            spdTmpComponent.text = (int)vel + " km/h"; //check lang??
        }

        #endregion
    }
}
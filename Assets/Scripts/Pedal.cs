using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace InterfaceA2 {
    internal sealed class Pedal: MonoBehaviour {
        #region Fields

        private bool isHeldDown;
        private float vel;
        [SerializeField] private float maxVel;
        [SerializeField] private float heldDownAccel;
        [SerializeField] private float notHeldDownAccel;
        [SerializeField] private TextMeshProUGUI spdTmpComponent;
        [SerializeField] private GameObject spdBar;
        [SerializeField] private GameObject spdBarPartPrefab;
        private GameObject[] spdBarParts;
        const int amtOfParts = 31;

        [SerializeField] private AudioSource audioSrcComponent;

        [SerializeField] private GameObject[] wheels;
        private CarTireRotation[] wheelRotations;

        #endregion

        #region Properties
        #endregion

        #region Ctors and Dtor

        public Pedal() {
            isHeldDown = false;
            vel = 0.0f;
            maxVel = 0.0f;
            heldDownAccel = 0.0f;
            notHeldDownAccel = 0.0f;
            spdTmpComponent = null;
            spdBar = null;
            spdBarPartPrefab = null;
            spdBarParts = null;

            audioSrcComponent = null;

            wheels = null;
            wheelRotations = null;
        }

        #endregion

        #region Unity User Callback Event Funcs

        private void Awake() {
            UnityEngine.Assertions.Assert.IsNotNull(spdBar);
            UnityEngine.Assertions.Assert.IsNotNull(spdBarPartPrefab);
            UnityEngine.Assertions.Assert.IsNotNull(spdTmpComponent);

            UnityEngine.Assertions.Assert.IsNotNull(audioSrcComponent);

            UnityEngine.Assertions.Assert.IsNotNull(wheels);
            int wheelsLen = wheels.Length;

            wheelRotations = new CarTireRotation[wheelsLen];
            for(int i = 0; i < wheelsLen; ++i) {
                wheelRotations[i] = wheels[i].GetComponent<CarTireRotation>();
            }
        }

        private void Start() {
            spdBarParts = new GameObject[amtOfParts];
            int val = (int)Mathf.Ceil(amtOfParts * 0.25f); //0.25f as 4 colors

            for(int i = 0; i < amtOfParts; ++i) {
				GameObject myGO = Instantiate(spdBarPartPrefab, new Vector3(-150.0f + i * 10.0f, 215.0f, 0.0f), Quaternion.identity);

				myGO.transform.SetParent(spdBar.transform, false);
                myGO.name = "SpdBarPart" + i;
                myGO.SetActive(false);

                Image imgComponent = myGO.GetComponent<Image>();
                if(i + 1 < val) {
                    imgComponent.color = new Color(0.0f, 1.0f, 0.0f);
                } else if(i + 1 < val * 2) {
                    imgComponent.color = new Color(1.0f, 1.0f, 0.0f);
                } else if(i + 1 < val * 3) {
                    imgComponent.color = new Color(1.0f, 0.5f, 0.0f);
                } else {
                    imgComponent.color = new Color(1.0f, 0.0f, 0.0f);
                }

                spdBarParts[i] = myGO;
            }
        }

        public void OnPointerDown() {
            isHeldDown = true;
            audioSrcComponent.Play();
        }

        public void OnPointerUp() {
            isHeldDown = false;
            audioSrcComponent.Play();
        }

        private void FixedUpdate() {
            vel += (isHeldDown ? heldDownAccel : notHeldDownAccel) * Time.deltaTime;
            vel = Mathf.Clamp(vel, 0.0f, maxVel);

            spdTmpComponent.text = (int)vel + " km/h";

            float velPiece = maxVel / amtOfParts;
            for(int i = 0; i < amtOfParts; ++i) {
                GameObject myGO = spdBarParts[i];
                myGO.SetActive(vel > velPiece * (i + 1) || Mathf.Approximately(vel , velPiece * (i + 1)));
            }

            audioSrcComponent.pitch = 1.0f + vel / maxVel * 0.4f;
            if(Mathf.Approximately(vel, 0.0f)) {
                audioSrcComponent.Stop();
            }

            int wheelRotationsLen = wheelRotations.Length;
            for(int i = 0; i < wheelRotationsLen; ++i) {
                wheelRotations[i].AngleChange = (~i & 1) == 1 ? vel * 16.0f : -vel * 16.0f;
            }
        }

        #endregion
    }
}
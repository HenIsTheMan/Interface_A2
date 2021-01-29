using UnityEngine;

namespace InterfaceA2 {
    internal sealed class MinimapCharControl: MonoBehaviour {
        #region Fields

        [SerializeField] float moveSpd;
        [SerializeField] Transform[] waypts;
        private int currWayptIndex;

        #endregion

        #region Properties
        #endregion

        #region Ctors and Dtor

        public MinimapCharControl() {
            moveSpd =  0.0f;
            waypts = null;
            currWayptIndex = 0;
        }

        #endregion

        #region Unity User Callback Event Funcs

        private void Awake() {
            UnityEngine.Assertions.Assert.IsNotNull(waypts);
        }

        private void Start() {
            ((RectTransform)transform).localPosition = ((RectTransform)waypts[currWayptIndex].transform).localPosition;
        }

        private void FixedUpdate() {
            ((RectTransform)transform).localPosition = Vector2.MoveTowards(
                ((RectTransform)transform).localPosition,
                ((RectTransform)waypts[currWayptIndex]).transform.localPosition, moveSpd * Time.deltaTime);

            if(currWayptIndex == waypts.Length - 1) {
                currWayptIndex = 0;
            } else if(((RectTransform)transform).localPosition == ((RectTransform)(waypts[currWayptIndex].transform)).localPosition) {
                ++currWayptIndex;
            }
        }

        #endregion
    }
}
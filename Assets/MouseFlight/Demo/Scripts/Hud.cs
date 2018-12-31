using UnityEngine;

namespace MFlight.Demo
{
    public class Hud : MonoBehaviour
    {
        [Header("Components")]
        [SerializeField] private MouseFlightController mouseFlight = null;

        [Header("HUD Elements")]
        [SerializeField] private RectTransform boresight = null;
        [SerializeField] private RectTransform mousePos = null;

        private void Update()
        {
            if (mouseFlight == null)
                return;

            UpdateGraphics();
        }

        private void UpdateGraphics()
        {
            if (boresight != null)
            {
                boresight.position = Camera.main.WorldToScreenPoint(mouseFlight.BoresightPos);
                //boresight.gameObject.SetActive(boresight.position.z > 1f);
            }

            if (mousePos != null)
            {
                mousePos.position = Camera.main.WorldToScreenPoint(mouseFlight.MouseAimPos);
                //mousePos.gameObject.SetActive(boresight.position.z > 1f);
            }
        }
    }
}

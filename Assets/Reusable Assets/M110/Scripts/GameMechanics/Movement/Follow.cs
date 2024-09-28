using UnityEngine;

namespace Assets.Scripts._Utils
{
    internal class Follow : MonoBehaviour
    {
        [SerializeField] Transform target;

        private void Update()
        {
            this.transform.position = target.position;
        }

    }
}

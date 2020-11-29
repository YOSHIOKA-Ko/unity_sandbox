using UnityEngine;

namespace AssistsUILayout
{
    public class DestroysObjectWhenStandalone: MonoBehaviour
    {
        void Start()
        {
#if UNITY_STANDALONE
            Destroy(this.gameObject);
            Debug.Log("Destroyed a " + this.gameObject.name + ".");
#endif
        }
    }
}

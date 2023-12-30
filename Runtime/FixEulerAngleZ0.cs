using UnityEngine;

namespace Kogane.Internal
{
    /// <summary>
    /// transform.eulerAngles.z を 0 に固定するコンポーネント
    /// </summary>
    [DisallowMultipleComponent]
    internal sealed class FixEulerAngleZ0 : MonoBehaviour
    {
        //================================================================================
        // 変数
        //================================================================================
        private Transform m_transformCache;

        //================================================================================
        // 関数
        //================================================================================
        private void OnEnable()
        {
            FixedUpdate();
        }

        private void FixedUpdate()
        {
            if ( m_transformCache == null )
            {
                m_transformCache = transform;
            }

            var eulerAngles = m_transformCache.eulerAngles;
            eulerAngles.z                = 0;
            m_transformCache.eulerAngles = eulerAngles;
        }
    }
}
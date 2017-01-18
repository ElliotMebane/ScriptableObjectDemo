/**
*   CONTRIBUTORS:                   
*   Sam Rivello - sam@UnityGameDeveloper.com       
*   -------------------------------------------------------------------------------------------------
*/

using UnityEngine;
using UnityEngine.Events;

namespace RMC.Core.Patterns.AssetObserver
{

    //  Namespace Properties ------------------------------------------------------------------------

    //  Class Attributes ----------------------------------------------------------------------------

    /// <summary>
    /// Replace with comments...
    /// </summary>
    public interface IAsset
    {
        //  Events ----------------------------------------------------------------------------------
       
        //  Properties ------------------------------------------------------------------------------
        AssetEvent OnValidated { get;}

        //  Methods ---------------------------------------------------------------------------------

        /// <summary>
        /// Manually Validate
        /// </summary>
        void Validate ();

    }


    //  Nested Classes  -----------------------------------------------------------------------------
    [System.Serializable]
    public class AssetEvent : UnityEvent<IAsset> {}
}

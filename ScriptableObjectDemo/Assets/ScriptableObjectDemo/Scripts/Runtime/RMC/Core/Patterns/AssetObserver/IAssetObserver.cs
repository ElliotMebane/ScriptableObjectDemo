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
    public interface IAssetObserver
    {

        //  Properties ------------------------------------------------------------------------------
        IAsset Asset {get;}

        //  Methods ---------------------------------------------------------------------------------
        void Validate ();

        //  Event Handlers --------------------------------------------------------------------------
        void Asset_OnValidated (AssetEvent assetEvent);

    }

}

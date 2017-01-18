/**
*   CONTRIBUTORS:                   
*   Sam Rivello - sam@UnityGameDeveloper.com       
*   -------------------------------------------------------------------------------------------------
*/

using UnityEngine;
using UnityEngine.UI;

namespace RMC.Core.Components
{

    //  Namespace Properties ------------------------------------------------------------------------

    //  Class Attributes ----------------------------------------------------------------------------

    /// <summary>
    /// Toggle isActive. Useful to ensure a GameObject is not active when scene runs.
    /// </summary>
    public class SetActiveComponent : MonoBehaviour 
    {

        //  Events ----------------------------------------------------------------------------------

        //  Properties ------------------------------------------------------------------------------

        //  Fields ----------------------------------------------------------------------------------
        [SerializeField]
        private bool _isActiveOnAwake;

        //  Initialization --------------------------------------------------------------------------

        //  Unity Methods ---------------------------------------------------------------------------
        protected void Awake () 
        {
            gameObject.SetActive(_isActiveOnAwake);
        }

        //  Methods ---------------------------------------------------------------------------------

        //  Event Handlers --------------------------------------------------------------------------
    }
}

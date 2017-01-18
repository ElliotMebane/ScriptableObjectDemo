/**
*   CONTRIBUTORS:                   
*   Sam Rivello - sam@UnityGameDeveloper.com       
*   -------------------------------------------------------------------------------------------------
*/

using UnityEngine;

namespace RMC.Core.Templates
{
	
    //  Namespace Properties ------------------------------------------------------------------------

    //  Class Attributes ----------------------------------------------------------------------------

    /// <summary>
    /// Replace with comments...
    /// </summary>
	public class TemplateComponent : MonoBehaviour 
	{
  
        //  Events ----------------------------------------------------------------------------------

        //  Properties ------------------------------------------------------------------------------
        public string SamplePublicText  {  get  {  return _samplePublicText;  } set  {  _samplePublicText = value;  } }
		
        //  Fields ----------------------------------------------------------------------------------
        private string _samplePublicText;
		
        //  Initialization --------------------------------------------------------------------------

        //  Unity Methods ---------------------------------------------------------------------------
        protected void Start () 
		{

		}

		protected void Update () 
		{
			
		}
		
        //  Methods ---------------------------------------------------------------------------------
        public string SamplePublicMethod (string message) 
		{
			return message;
		}
		
		
        //  Event Handlers --------------------------------------------------------------------------
        public void Target_OnEventOccurred (string message) 
		{
			
		}
	}
}

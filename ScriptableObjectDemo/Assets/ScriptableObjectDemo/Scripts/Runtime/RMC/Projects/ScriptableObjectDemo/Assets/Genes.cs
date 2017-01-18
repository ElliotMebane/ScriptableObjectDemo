/**
*   CONTRIBUTORS:                   
*   Sam Rivello - sam@UnityGameDeveloper.com       
*   -------------------------------------------------------------------------------------------------
*/

using UnityEngine;

namespace RMC.Core.Projects.ScriptableObjectDemo.Assets
{
	
    //  Namespace Properties ------------------------------------------------------------------------

    //  Class Attributes ----------------------------------------------------------------------------
    [CreateAssetMenu (fileName="New Gene", menuName="ScriptableObjectDemo/Create New Gene", order=0)]

    /// <summary>
    /// Replace with comments...
    /// </summary>
    public class Genes : ScriptableObject
	{
  
        //  Events ----------------------------------------------------------------------------------
        public Color EyeColor   {  get  {  return _eyeColor;  } set  {  _eyeColor = value;   } }

        //  Properties ------------------------------------------------------------------------------

        //  Fields ----------------------------------------------------------------------------------
        [SerializeField] private Color _eyeColor;

        //  Initialization --------------------------------------------------------------------------
		
        //  Methods ---------------------------------------------------------------------------------
        public override string ToString()
        {
            return string.Format("[Genes (EyeColor={0})]", ColorToHex(EyeColor));
        }

        public static string ColorToHex(Color32 color)
        {
            return color.r.ToString("X2") + color.g.ToString("X2") + color.b.ToString("X2");
        }

        //  Event Handlers --------------------------------------------------------------------------
	}
}

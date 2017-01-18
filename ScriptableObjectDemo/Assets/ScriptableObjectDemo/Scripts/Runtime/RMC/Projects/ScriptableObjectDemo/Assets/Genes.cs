/**
*   CONTRIBUTORS:                   
*   Sam Rivello - sam@UnityGameDeveloper.com       
*   -------------------------------------------------------------------------------------------------
*/

using UnityEngine;
using RMC.Core.Patterns.AssetObserver;
using UnityEngine.Events;

namespace RMC.Core.Projects.ScriptableObjectDemo.Assets
{
	
    //  Namespace Properties ------------------------------------------------------------------------

    //  Class Attributes ----------------------------------------------------------------------------
    [CreateAssetMenu (fileName="New Gene", menuName="ScriptableObjectDemo/Create New Gene", order=0)]

    /// <summary>
    /// Replace with comments...
    /// </summary>
    public class Genes : ScriptableObject, IAsset
	{

        //  Events ----------------------------------------------------------------------------------
        private AssetEvent _onValidated = new AssetEvent();

        //  Properties ------------------------------------------------------------------------------
        public Color EyeColor   {  get  {  return _eyeColor;  } set  {  _eyeColor = value;   } }
        public AssetEvent OnValidated   {  get  {  return _onValidated;  } }

        //  Fields ----------------------------------------------------------------------------------
        [SerializeField] private Color _eyeColor;

        //  Initialization --------------------------------------------------------------------------

        //  Unity Methods ---------------------------------------------------------------------------
        protected void OnValidate()
        {
            if (GUI.changed)
            {
                Validate();
            }
        }

		
        //  Methods ---------------------------------------------------------------------------------
        public override string ToString()
        {
            return string.Format("[Genes (EyeColor={0})]", ColorToHex(EyeColor));
        }

        public static string ColorToHex(Color32 color)
        {
            return color.r.ToString("X2") + color.g.ToString("X2") + color.b.ToString("X2");
        }

        public void Validate()
        {
            _onValidated.Invoke(this);
        }

        //  Event Handlers --------------------------------------------------------------------------

	}
}

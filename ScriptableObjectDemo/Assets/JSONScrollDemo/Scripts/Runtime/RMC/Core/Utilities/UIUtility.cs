/**
*   CONTRIBUTORS:                   
*   Sam Rivello - sam@UnityGameDeveloper.com       
*   -------------------------------------------------------------------------------------------------
*/

using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.EventSystems;

namespace RMC.Core.Utilities
{

    //  Namespace Properties ------------------------------------------------------------------------

    //  Class Attributes ----------------------------------------------------------------------------

    /// <summary>
    /// Replace with comments...
    /// </summary>
    public static class UIUtility  
    {

        //  Events ----------------------------------------------------------------------------------

        //  Properties ------------------------------------------------------------------------------

        //  Fields ----------------------------------------------------------------------------------

        //  Initialization --------------------------------------------------------------------------

        //  Methods ---------------------------------------------------------------------------------
        public static void AddListener(UIBehaviour uiBehaviour, EventTriggerType eventTriggerType, UnityAction unityAction)
        {
            EventTrigger eventTrigger = GetOrAddComponent<EventTrigger>(uiBehaviour.gameObject);

            UnityEngine.EventSystems.EventTrigger.TriggerEvent triggerEvent = new EventTrigger.TriggerEvent();
            triggerEvent.AddListener((eventData) => unityAction()); // ignore event data
            EventTrigger.Entry entry = new EventTrigger.Entry() 
                { 
                    callback = triggerEvent, 
                    eventID = eventTriggerType 
                };
            eventTrigger.triggers.Add(entry);
        }

        public static void RemoveAllListeners(UIBehaviour uiBehaviour, EventTriggerType eventTriggerType)
        {
            EventTrigger eventTrigger = GetOrAddComponent<EventTrigger>(uiBehaviour.gameObject);

            for (int index = eventTrigger.triggers.Count -1; index >= 0; index--)
            {
                EventTrigger.Entry entry = eventTrigger.triggers[index];
                if (entry.eventID == eventTriggerType)
                {
                    eventTrigger.triggers.RemoveAt(index);
                }
            }

        }

        public static T GetOrAddComponent<T> (GameObject gameObject) where T : Component
        {
            T t = gameObject.GetComponent<T>();
            if (t == null)
            {
                t = gameObject.AddComponent<T>();
            }
            return t;
        }

        //  Event Handlers --------------------------------------------------------------------------
    }
}

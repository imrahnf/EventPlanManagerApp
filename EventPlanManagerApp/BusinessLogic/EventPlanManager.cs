using System;
namespace EventPlanManagerApp.BusinessLogic
{
    public enum EventType
    {
        Corporate, Family, Sport
    }
    public class EventPlanManager
	{
        // variables
        private float totalDev = 0f;

        //Complete the code following the instructions in the print document
        List<EventPlan> _eventPlans;

		// return the list of eventplans
		public List<EventPlan> EventPlans
		{
			get { return _eventPlans; }
		}

		public EventPlan searchByID (EventPlan newPlan)
		{
			foreach(EventPlan Event in EventPlans)
			{
				if (Event.EventPlanId == newPlan.EventPlanId)
				{
					// There exists an event plan already
					return Event;
				}
			}
			return null;
        }
        

        public float calcTotalDeviation ()
		{
			totalDev = 0f; // reset whenever this is alled
            foreach (EventPlan Event in EventPlans)
            {
				// Assuming deviation will sometimes be negative if it is also ujnder budget
				totalDev += Event.DeviationFromBudget;
            }
			return totalDev;
        }

		public void AddEventPlan(EventPlan eventPlan)
		{
			// Check if there are duplicate IDs
			if (searchByID != null)
			{
				// There are not any matching IDs so we can make a new plan
				EventPlans.Add(eventPlan);
			}
		}
	}
}


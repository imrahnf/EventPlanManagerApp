using System;
namespace EventPlanManagerApp.BusinessLogic
{
	public class EventPlan
	{
		private int _eventPlanId;
		private string _eventName;
		private DateTime _startDate;
		private float _budget;
		private float _estimatedCost;
		private EventType _eventType;
		public float DeviationFromBudget;

		public string EventName 
		{
			get { return _eventName; }
		}

		public DateTime StartDate
		{
			get { return _startDate; }
			set {

                if (_startDate < DateTime.Today)
				{
					_startDate = value;
				}
    }
		}

        public override string ToString()
        {
            return _eventType.ToString();
        }

        public EventPlan(int eventPlanId, string eventName, DateTime startDate, float budget, float estimatedCost, EventType eventType)
		{
			_eventPlanId = eventPlanId;
			_eventName = eventName;
			_startDate = startDate;
			_budget = budget;
			_estimatedCost = estimatedCost;
			_eventType = eventType;

			DeviationFromBudget = _budget-_estimatedCost;
		}

		//Complete the code following the instructions in the print document
	}
}


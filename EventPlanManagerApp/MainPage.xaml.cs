using EventPlanManagerApp.BusinessLogic;
using Windows.Gaming.Input.ForceFeedback;

namespace EventPlanManagerApp;

public partial class MainPage : ContentPage
{
	EventPlanManager eventPlanManager = new EventPlanManager();

	public void populatePicker()
	{
		foreach (EventType EventType in Enum.GetValues(typeof(EventType)))
		{
			EventTypePicker.Items.Add(EventType.ToString());

        }
	}

    public MainPage()
	{
		InitializeComponent();
		populatePicker();
	}

    private void AddButton_Clicked(object sender, EventArgs e)
    {
		// Add a new class if all 6 fields are not empty
		int eventPlanID = 0;
		string eventPlanName = "";
		DateTime date = DateTime.Now;
		EventType eventType;
		float budget = 0.0f;
		float estCost = 0.0f;

        if (int.TryParse(EventPlanIdEntry.Text, out int newId))
        {
            eventPlanID = newId;
        }

        if (int.TryParse(BudgetEntry.Text, out int newbudget))
        {
            budget = newId;
        }

        if (int.TryParse(EstimatedCostEntry.Text, out int newcost))
        {
            estCost = newId;
        }

        if (!string.IsNullOrEmpty(EventPlanIdEntry.Text))
		{
			eventPlanName = EventNameEntry.Text;

        }

		if (EventTypePicker.SelectedIndex == -1)
		{
			// nothing is picked
		} else
		{
            string eventTypeName = EventTypePicker.SelectedItem.ToString();
            if (Enum.TryParse(eventTypeName, out EventType foundType))
            {
                eventType = foundType;
            }
        }

        if ((eventPlanID != 0) && (eventPlanName != null) && (eventType != null) && (budget != 0.0f) && (estCost != 0.0f) )
        {
            EventPlan plan = new EventPlan(eventPlanID, eventPlanName, eventType, budget, estCost);
            eventPlanManager.AddEventPlan(plan);
        }



        }
}



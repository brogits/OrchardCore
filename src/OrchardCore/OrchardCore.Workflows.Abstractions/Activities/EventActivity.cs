using OrchardCore.Workflows.Models;

namespace OrchardCore.Workflows.Activities
{
    public abstract class EventActivity : Activity, IEvent
    {
        public virtual bool CanStartWorkflow => true;

        public override ActivityExecutionResult Execute(WorkflowExecutionContext workflowContext, ActivityContext activityContext)
        {
            // Halt the workflow to wait for the event to occur.
            return Halt();
        }
    }
}
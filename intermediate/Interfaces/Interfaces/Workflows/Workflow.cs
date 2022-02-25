namespace Interfaces.Workflows
{
    public class Workflow
    {
        private List<IWorkflow> WorkflowItems { get; set; }
        public Workflow(List<IWorkflow> workflowItems)
        {
            WorkflowItems = workflowItems;
        }
        public void Run()
        {
            foreach (IWorkflow workflowItem in WorkflowItems)
            {
                workflowItem.Execute();
            }
        }
    }
}
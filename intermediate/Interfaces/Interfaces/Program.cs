using Interfaces.Workflows;

class Program
{
    static void Main()
    {
        List<IWorkflow> workflowItems = new List<IWorkflow>();
        workflowItems.Add(new UploadVideo());
        workflowItems.Add(new Encode());
        workflowItems.Add(new SendMessage());
        workflowItems.Add(new ProcessingVideo());

        Workflow workflow = new Workflow(workflowItems);
        workflow.Run();
    }
}

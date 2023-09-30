using System.Threading.Tasks.Dataflow;

public class Resume{

public string _name;
public List<Job> _Listofjobs = new List<Job>();
public void DisplayResumeDetails(){

     Console.WriteLine($"Name:Luna Shi\nJobs:");

    foreach (Job j in _Listofjobs){

      j.DisplayJobDetails();

    }
    
}




}

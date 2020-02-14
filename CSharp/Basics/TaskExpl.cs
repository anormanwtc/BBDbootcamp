using System;
using System.Threading.Tasks;
using System.Net.Http;


namespace CSharp
{
    public class TaskExpl
    {
        public void usingTask() {
            Task<int> t = Task.Run(() => { return 42; });

            t.ContinueWith((i) =>
            {
                Console.WriteLine("Canceled");
            }, TaskContinuationOptions.OnlyOnCanceled);

            t.ContinueWith((i) =>
            {
                Console.WriteLine("Faulted");
            }, TaskContinuationOptions.OnlyOnFaulted);

            var completedTask = t.ContinueWith((i) =>
            {
                Console.WriteLine("Completed");
            }, TaskContinuationOptions.OnlyOnRanToCompletion);

            completedTask.Wait();
            Console.WriteLine(t.Result);
        }

        public async Task<int> AccessTheWebAsync()  
        {   
            // You need to add a reference to System.Net.Http to declare client.  
            using (HttpClient client = new HttpClient())  
            {  
                // GetStringAsync returns a Task<string>. That means that when you await the  
                // task you'll get a string (urlContents).  
                Task<string> getStringTask = client.GetStringAsync("https://docs.microsoft.com");
                //string urlContents = await client.GetStringAsync("https://docs.microsoft.com");
                    //simplification if no independant work

                // You can do work here that doesn't rely on the string from GetStringAsync.  
                //DoIndependentWork();  

                // The await operator suspends AccessTheWebAsync.  
                //  - AccessTheWebAsync can't continue until getStringTask is complete.  
                //  - Meanwhile, control returns to the caller of AccessTheWebAsync.  
                //  - Control resumes here when getStringTask is complete.   
                //  - The await operator then retrieves the string result from getStringTask.  
                string urlContents = await getStringTask;  

                // The return statement specifies an integer result.  
                // Any methods that are awaiting AccessTheWebAsync retrieve the length value.  
                return urlContents.Length;  
            }
        } 
        
    }
}
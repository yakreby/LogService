# LogService
Simple Log Service for Winforms Application

In use

Get content
   LogService logService = new LogService();
   logService.ControlFile("SaleLogs.txt", "Satış Kayıtları");
   string[] list = File.ReadAllLines(logService.GetAppPath("SaleLogs.txt"));
   foreach (string line in list)
   {
      SaleLogsData.Items.Add(line);
   }
   
Set content
    LogService logService = new LogService();
    logService.ApplicationLogger($"{userName} adlı kullanıcı sisteme giriş yaptı");

Getting log file's content

![1](https://user-images.githubusercontent.com/55652632/204342619-5d838b78-d371-4679-acc7-a000f91493f2.PNG)

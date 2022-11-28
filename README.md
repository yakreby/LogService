# LogService
Simple Log Service for Winforms Application

<h2>In use</h2>
<br>
<h3>Get content</h3><br>
   LogService logService = new LogService();<br>
   logService.ControlFile("SaleLogs.txt", "Satış Kayıtları");<br>
   string[] list = File.ReadAllLines(logService.GetAppPath("SaleLogs.txt"));<br>
   foreach (string line in list)<br>
   {<br>
      SaleLogsData.Items.Add(line);<br>
   }<br>
   
<h3>Set content</h3><br>
    LogService logService = new LogService();<br>
    logService.ApplicationLogger($"{userName} adlı kullanıcı sisteme giriş yaptı");<br>

<br>
<h3>Getting log file's content</h3>

![1](https://user-images.githubusercontent.com/55652632/204342619-5d838b78-d371-4679-acc7-a000f91493f2.PNG)

# NeustarChallenge

DB Configuration: 
  1-Install sqlite Studio.
  2-Configure sqlite studio with your prefered settings. I used the following: 
    (localdb)\MSSQLLocalDB;
    Database=DBTest;    
    User ID=sa;
    Password=3389;
  3-Make sure to enable trusted connections. Trusted_Connection=True;
  4-In the solution (Neustar VS solution), under Data/ApplicationDbContext.cs, use the information used in the DB configuration to create the connection string. In the configuration used for this project I used 
  options.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=DBTest;Trusted_Connection=True;User ID=sa;Password=3389;MultipleActiveResultSets=true");
  
  5-Go to the appsettings.json file in the solution explorer, and use the following:
  "DefaultConnection": "Server=(localdb)\\MSSQLLocalDB;Database=DBTest;Trusted_Connection=True;User ID=sa;Password=3389;MultipleActiveResultSets=true"
  
  6-Deploy the project either using VS or using IIS for web server deployment. 
  
  

# FireBase_RealTimeDataBase_Write
<div>
        
        Example program for using FireBase Realtime DataBase   
</div>

# Using Library
<div>
        
        System.Net.Json.dll
</div>

# FireBase Realtime DataBase : Data Write
<div>
        
        private void FB_DB_Write(string name, string birth, string gender)
        {
            //Create a string of type JSON
            JsonObjectCollection col = new JsonObjectCollection();
            col.Name = "User";
            col.Add(new JsonStringValue("Name", name));
            col.Add(new JsonStringValue("Birth", birth));
            col.Add(new JsonStringValue("Gender", gender));


            JsonObjectCollection col2 = new JsonObjectCollection();
            col2.Add(col);

            JsonTextParser parser = new JsonTextParser();
            try
            {
                JsonObject NewObject = parser.Parse(col2.ToString());
                var request = WebRequest.CreateHttp("Address/.json");
                request.Method = "PATCH";
                request.ContentType = "JSON";
                var buffer = Encoding.UTF8.GetBytes(NewObject.ToString());
                request.ContentLength = buffer.Length;
                request.GetRequestStream().Write(buffer, 0, buffer.Length);
                var response = request.GetResponse();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
</div>

<div>
<img src="https://user-images.githubusercontent.com/58409497/70021766-2f0fbf80-15d5-11ea-893b-79d7805f7983.png">
</div>

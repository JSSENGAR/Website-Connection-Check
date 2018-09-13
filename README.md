# Website-Connection-Check
Function to check whether web site is connected or not
Below Function will return "1" when website connection would be exist.


        public string cn_check()
        {
            string url = "https://github.com/JSSENGAR";
            try
            {
                System.Net.WebRequest myRequest = System.Net.WebRequest.Create(url);
                System.Net.WebResponse myResponse = myRequest.GetResponse();                
                return "1";
            }
            catch (System.Net.WebException ex)
            {
                return ex.Message;
            }
        }

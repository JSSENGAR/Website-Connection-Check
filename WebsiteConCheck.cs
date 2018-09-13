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
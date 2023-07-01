using Newtonsoft.Json.Linq;

namespace selenium_csharep.utilities
{
	public class JsonReader
	{
		public JsonReader()
		{
		}

        public string extractData(String tokenName)
        {

            String myJsonString = File.ReadAllText("utilities/testData.json");

            var jsonObject = JToken.Parse(myJsonString);
            return jsonObject.SelectToken(tokenName).Value<string>();


        }

        public string[] extractDataArray(String tokenName)
        {

            String myJsonString = File.ReadAllText("utilities/testData.json");

            var jsonObject = JToken.Parse(myJsonString);
            List<String> productsList = jsonObject.SelectTokens(tokenName).Values<string>().ToList();
            return productsList.ToArray();
        }
    }
}


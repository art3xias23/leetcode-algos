 if(string.IsNullOrWhiteSpace(propertyValue))
 {
    listOfDetails.Add("PropertyValue", "0");
 }
 else
 {

    var noPound = propertyValue.Replace("£", string.Empty);
    if(!double.TryParse(noPound, out var parsedDouble))
    {
        listOfDetails.Add("PropertyValue", "0");
    }
    else{

        listOfDetails.Add("PropertyValue",  withDouble.ToString());
    }
 }
function DetectField() {

    if (document.getElementById("field").value == "Gender") {
        document.getElementById("query").innerHTML =
            "<input type='radio'; name='value'; value='male' checked='checked' />male &nbsp;&nbsp;" +
            "<input type='radio'; name='value'; value='female' />female";
    }
    else {
        if (document.getElementById("field").value == "YearBorn") {
            var yearStr = "<select name='value'>";
            var currYear = new Date().getFullYear();
            var fromYear = currYear - 60;
            var toYear = currYear - 10;

            for (var i = fromYear; i <= toYear; i++)
                yearStr += "<option value='" + i + "'>" + i + "</option>";

            document.getElementById("query").innerHTML = yearStr + "</select>";
        }
        else {
            if (document.getElementById("field").value == "Prefix") {
                var prefixStr = "<select name='value'>";

                prefixStr += "<option value='050'> 050 </option>";
                prefixStr += "<option value='051'> 051 </option>";
                prefixStr += "<option value='052'> 052 </option>";
                prefixStr += "<option value='053'> 053 </option>";
                prefixStr += "<option value='054'> 054 </option>";
                prefixStr += "<option value='055'> 055 </option>";
                prefixStr += "<option value='056'> 056 </option>";
                prefixStr += "<option value='057'> 057 </option>";
                prefixStr += "<option value='058'> 058 </option>";
                prefixStr += "<option value='059'> 059 </option>";

                document.getElementById("query").innerHTML = prefixStr + "</select>";
            }
            else {
                if (document.getElementById("field").value == "Hobby") {
                    var hobbyStr = "<select name='value'>";

                    hobbyStr += "<option value='1'> Football </option>";
                    hobbyStr += "<option value='2'> Basket Ball </option>";
                    hobbyStr += "<option value='3'> Swimming </option>";
                    hobbyStr += "<option value='4'> Programming </option>";
                    hobbyStr += "<option value='5'> Video Games </option>";

                    document.getElementById("query").innerHTML = hobbyStr + "</select>";
                }
                else {
                    if (document.getElementById("field").value == "City") {
                        var cityStr = "<select name='value'>";

                        cityStr += "<option value='Nazareth'> Nazareth </option>";
                        cityStr += "< option value = 'Safed' > Safed </option >";
                        cityStr += "<option value='Afula' > Afula </option>";
                        cityStr += "<option value='Haifa'> Haifa </option>";
                        cityStr += "<option value='Tiberias'> Tiberias </option>";
                        cityStr += "<option value='Karmiel'> Karmiel </option>";
                        cityStr += "<option value='Acre'> Acre </option>";
                        cityStr += "<option value='Netanya'> Netanya </option>";
                        cityStr += "<option value='Nablus'> Nablus </option>";
                        cityStr += "<option value='Tel Aviv'> Tel Aviv </option>";
                        cityStr += "<option value='Ramallah'> Ramallah </option>";
                        cityStr += "<option value='Jerusalem'> Jerusalem </option>";
                        cityStr += "<option value='Ashkelon'> Ashkelon </option>";
                        cityStr += "<option value='Gaza'> Gaza </option>";
                        cityStr += "<option value='Beer Sheva'> Beer Sheva </option>";
                        cityStr += "<option value='Eilat'> Eilat </option>";

                        document.getElementById("query").innerHTML = cityStr + "</select>";
                    }
                    else {

                        if (document.getElementById("field").value == "Phone")
                            document.getElementById("query").innerHTML = "<input type='number' name='value'/>";
                        else
                            document.getElementById("query").innerHTML = "<input type='text' name='value'/>";
                    }
                }
            }
        }
    }
}
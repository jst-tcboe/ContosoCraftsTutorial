foreach($p in $products)
{
    $makerId = Switch($p.Maker)
    {
        "jenlooper" {1}
        "sailorhg" {2}
        "selinazawacki" {3}
        "vogueandcode" {4}
    }

    $statement = "INSERT INTO Items (ImageUrl,ItemUrl,Title,Description,MakerId,ItemShortName) 
    VALUES (`
        '$($p.img)', `
        '$($p.Url)', `
        '$($p.Title)', `
        '$($p.Description.Replace('''',''''''))', `
        '$($makerId)', `
        '$($p.Id)');"
    $statement | Out-File ./Items.sql -Append
}


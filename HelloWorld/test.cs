//C# file to test my code for work

//Function for looping multiple foreach loops
foreach (DataRow row in featureCategoryDataTable.Rows)
{
    var featureName = row["featureName"].ToString();

    foreach(System.Web.UI.WebControls.ListItem item in List1.Items)
    {
        if(item.Text == featureName)
        {
            item.Selected = true;
        }
    }
    foreach(System.Web.UI.WebControls.ListItem item in List2.Items)
    {
        if(item.Text == featureName)
        {
            item.Selected = true;
        }
    }
    foreach(System.Web.UI.WebControls.ListItem item in List3.Items)
    {
        if(item.Text == featureName)
        {
            item.Selected = true;
        }
    }
    foreach(System.Web.UI.WebControls.ListItem item in List4.Items)
    {
        if(item.Text == featureName)
        {
            item.Selected = true;
        }
    }
    foreach(System.Web.UI.WebControls.ListItem item in List5.Items)
    {
        if(item.Text == featureName)
        {
            item.Selected = true;
        }
    }
    foreach(System.Web.UI.WebControls.ListItem item in List6.Items)
    {
        if(item.Text == featureName)
        {
            item.Selected = true;
        }
    }
}

//Optimized version
static IEnumerable<System.Web.UI.WebControls.ListItem> GetAllListItems(params System.Web.UI.WebControls.ListItemCollection[] lists)
{
    foreach (var list in lists)
    {
        foreach (System.Web.UI.WebControls.ListItem item in list)
        {
            yield return item;
        }
    }
}

// Calling funct
foreach (System.Web.UI.WebControls.ListItem item in GetAllListItems(List1, List2, List3, List4, List5, List6))
{
    if (featureNames.Contains(item.Text))
    {
        item.Selected = true;
    }
}
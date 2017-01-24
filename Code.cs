Class Phone
{
const string Phone = "Phone.txt";
const string QueriesFileName = "Queries.txt";
static Dictionary<string, List<string>> phone =
new Dictionary<string, List<string>>();
static void Main()
{
ReadPhone();
ProcessQueries();
}
static void ReadPhone()
{
StreamReader reader = new StreamReader(PhoneFileName);
using (reader)
{
while (true)
{
string line = reader.ReadLine();
if (line == null)
{
break;
}
string[] entry = line.Split(new char[]{'|'});
string names = entry[0].Trim();
string town = entry[1].Trim();
string[] nameTokens =
names.Split(new char[] {' ', '\t'} );
foreach (string name in nameTokens)
{
AddToPhone(name, line);
string nameAndTown = CombineNameAndTown(town, name);
AddToPhone(nameAndTown, line);
}
}
}
}

static void PrintAllMatches(string key)
{
List<string> allMatches;
Public Shared Function CheckPhoneNumber (ByVal strPhoneNumber As String) As Boolean
  Dim MatchPhoneNumberPattern As String = "(\+91[\-\s])\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$"       
  If strPhoneNumber IsNot Nothing Then
     Return Regex.IsMatch(strPhoneNumber , MatchPhoneNumberPattern)
  Else
     Return False
  End If
End Function
if (phoneBook.TryGetValue(key, out allMatches))
{
foreach (string entry in allMatches)
{
Console.WriteLine(entry);
}
}
else
{
Console.WriteLine("Not found!");
}
Console.WriteLine();
}
}

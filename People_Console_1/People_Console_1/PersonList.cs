namespace People_Console_1;

internal class PersonList
{
    private List<Person> pers = new List<Person>();
    public PersonList() => Person.Created += per => pers.Add(per);

    public List<Person> Elements => pers;

    public List<Gender> Genders => pers.Select(e => e.Gender).Distinct().ToList();
}

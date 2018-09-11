using System.Collections.Generic

namespace JobBoard.Models
{
  public class JobOpening
  {
    private string _title;
    private string _description;
    private string _contactInfo;

    public JobOpening (string title, string description, string contactInfo)
    {
      _title = title;
      _description = description;
      _contactInfo = contactInfo;
    }
    public string GetTitle()
    {
      return _title;
    }
    public string GetDescription()
    {
      return _description;
    }
    public string GetContactInfo()
    {
      return _contactInfo;
    }
    public void SetTitle(string title)
    {
      _title = title;
    }
    public void SetDescription(string description)
    {
      _description = description;
    }
    public void SetContactInfo(string contactInfo)
    {
      _contactInfo = contactInfo;
    }
    public static List<JobOpening> GetAll()
    {
      return _instances;
    }
    public void Save()
    {
      _instances.Add(this);
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}

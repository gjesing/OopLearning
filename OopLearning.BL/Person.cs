using System;

namespace OopLearning.BL
{
    public class Person : IComparable<Person>
    {
        private string name;
        private string cpr;
        public string Name
        {
            get { return name; }
            set
            {
                (bool isValid, string errMsg) = ValidateName(value);
                if (isValid)
                    name = value;
                else throw new ArgumentException(errMsg, nameof(Name));
            }
        }
        public DateTime Birthday
        {
            get
            {
                if (!string.IsNullOrWhiteSpace(cpr))
                {
                    DateTime.TryParse($"{cpr[0]}{cpr[1]}-{cpr[2]}{cpr[3]}-{cpr[4]}{cpr[5]}", out DateTime birthday);
                    return birthday;
                }
                else
                    throw new InvalidOperationException("CPR is not yet saved");
            }
        }
        public string Cpr
        {
            get { return cpr; }
            set
            {
                (bool isValid, string errMsg) = ValidateCpr(value);
                if (isValid)
                    cpr = value;
                else throw new ArgumentException(errMsg, nameof(Cpr));
            }
        }
        public bool IsWoman
        {
            get
            {
                if (!string.IsNullOrWhiteSpace(cpr))
                {
                    int.TryParse(cpr, out int cprNumber);
                    if (cprNumber % 2 == 0)
                        return true;
                    else
                        return false;
                }
                else
                    throw new InvalidOperationException("CPR is not yet saved");
            }
        }
        public static (bool isValid, string errMsg) ValidateName(string name)
        {
            if (name is null)
                return (false, "Name is null");
            name = name.Trim();
            if (string.IsNullOrWhiteSpace(name))
                return (false, "Name only contains white spaces");
            if (name.Length < 2)
                return (false, "Name must be at least 2 characters");
            if (!name.Contains(' '))
                return (false, "Name must contain spaces");
            return (true, "");
        }
        public static (bool isValid, string errMsg) ValidateCpr(string cpr)
        {
            if (cpr is null)
                return (false, "CPR is null");
            if (cpr.Length != 10)
                return (false, "CPR must be 10 characters");
            DateTime birthday;
            if (!DateTime.TryParse($"{cpr[0]}{cpr[1]}-{cpr[2]}{cpr[3]}-{cpr[4]}{cpr[5]}", out birthday))
                return (false, "CPR does not contain a valid birthdate");
            if (birthday > DateTime.Now)
                return (false, "Birthday is in the future");
            return (true, "");
        }
        public virtual string CreateIdentifier()
        {
            return Cpr;
        }

        public int CompareTo(Person other)
        {
            if (other is null) return 1;
            if (Name.ToLower() == other.Name.ToLower())
            {
                Birthday.CompareTo(other.Birthday);
            }
            return Name.ToLower().CompareTo(other.Name.ToLower());
        }
    }
}

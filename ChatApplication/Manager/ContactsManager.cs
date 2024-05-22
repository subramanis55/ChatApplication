using DatabaseLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ChatApplication.Manager
{
    public static class ContactsManager
    {
        public static Contact PCContact;
        public static DateTime pcContactLastOnlineTime;
        public static List<Contact> Contacts_list;
        public static Dictionary<string, Contact> ContactDictionary = new Dictionary<string, Contact>();
        public static List<Contact> MessagedContacts_list;
        public static bool ContactManagerSetup()
        {
            ContactManagerRefresh();
            MessagedContacts_list = GetMessagedContact();
            return true;
        }
        public static void ContactManagerRefresh()
        {
            ContactDictionary.Clear();
            Contacts_list = GetContacts();
            PCContact = getContactInList(NetworkManager.PcHostName);
            for (int i = 0; i < Contacts_list.Count; i++)
            {
                ContactDictionary.Add(Contacts_list[i].HostName, Contacts_list[i]);
                string ipaddress = NetworkManager.GetPcIPAddress(Contacts_list[i].HostName);
                if (ipaddress != "")
                {
                    if (ipaddress != Contacts_list[i].IpAddress)
                    {
                        Contacts_list[i].IpAddress = ipaddress;
                    }
                }
            }
            pcContactLastOnlineTime = GetLastOnlineTime(NetworkManager.PcHostName);
        }
        // contact Method
        public static bool ContactCreate(Contact contact)
        {
            var result = DatabaseManager.Manager.InsertData("CONTACTS", new ParameterData[] { new ParameterData("MACADDRESS", contact.MacAddress), new ParameterData("HOSTNAME", contact.HostName), new ParameterData("IPADDRESS", contact.IpAddress), new ParameterData("FIRSTNAME", contact.FirstName), new ParameterData("LASTNAME", contact.LastName), new ParameterData("DPPICTURE", contact.DpPicture), new ParameterData("LASTONLINETIME", contact.LastOnlineTime), new ParameterData("NEWMESSAGECOUNT", contact.NewMessageCount), new ParameterData("ISARCHIVED", contact.IsArchived) });
            return result.Result;
        }
        public static bool ChangeContactDppicture(string hostname, string dpPictureStringFormat)
        {
            var result = DatabaseManager.Manager.UpdateData("CONTACTS", $"HOSTNAME='{hostname}'", new ParameterData("DPPICTURE", dpPictureStringFormat));
            return result.Result;
        }
        public static bool UpdateLastOnlineTime(string hostName, DateTime lastOnlineTime)
        {
            var result = DatabaseManager.Manager.UpdateData("CONTACTS", $"HOSTNAME='{hostName}'", new ParameterData("LASTONLINETIME", lastOnlineTime));
            return result.Result;
        }
        public static Contact getContactInList(string hostName)
        {
            var value = DatabaseManager.Manager.FetchData("CONTACTS", $"HOSTNAME='{hostName}'").Value;
            for (int i = 0; i < Contacts_list.Count; i++)
            {
                if (Contacts_list[i].HostName == hostName)
                    return Contacts_list[i];
            }
            return null;
        }
        public static Contact getContactFromServerDatabase(string hostName)
        {
            var value = DatabaseManager.Manager.FetchData("CONTACTS", $"HOSTNAME='{hostName}'").Value;
            return new Contact(value["MACADDRESS"][0].ToString(), value["HOSTNAME"][0].ToString(), value["IPADDRESS"][0].ToString(), value["FIRSTNAME"][0].ToString(), value["LASTNAME"][0].ToString(), value["DPPICTURE"][0].ToString(), (DateTime)value["LASTONLINETIME"][0], (int)value["NEWMESSAGECOUNT"][0], Convert.ToBoolean(value["ISARCHIVED"][0]));

        }
        public static Contact getContactFromLocalDatabase(string hostName)
        {
            var value = DatabaseManager.Manager.FetchData("CONTACTS", $"HOSTNAME='{hostName}'").Value;
            return new Contact(value["MACADDRESS"][0].ToString(), value["HOSTNAME"][0].ToString(), value["IPADDRESS"][0].ToString(), value["FIRSTNAME"][0].ToString(), value["LASTNAME"][0].ToString(), FilesManager.SaveFilesInDirectoryFolder(FilesManager.FilesPath_D["CONTACTSDPPICTURE"], value["FIRSTNAME"][0].ToString() + "-" + value["IPADDRESS"][0].ToString(), value["DPPICTURE"][0].ToString()), (DateTime)value["LASTONLINETIME"][0], (int)value["NEWMESSAGECOUNT"][0], Convert.ToBoolean(value["ISARCHIVED"][0]));

        }
        public static List<Contact> GetContactsFromServer()
        {
            var result = DatabaseManager.Manager.FetchData("CONTACTS", "HOSTNAME IS NOT NULL");
            var value = result.Value;
            List<Contact> temp_Conatctlist = new List<Contact>();
            if (result.Value != null && result.Value.Count > 0)
            {
                for (int i = 0; i < result.Value["HOSTNAME"].Count; i++)
                {
                    try
                    {
                        temp_Conatctlist.Add(new Contact(value["MACADDRESS"][i].ToString(), value["HOSTNAME"][i].ToString(), value["IPADDRESS"][i].ToString(), value["FIRSTNAME"][i].ToString(), value["LASTNAME"][i].ToString(), value["DPPICTURE"][i].ToString(), (DateTime)value["LASTONLINETIME"][i], (int)value["NEWMESSAGECOUNT"][i], Convert.ToBoolean(value["ISARCHIVED"][i])));
                    }
                    catch
                    {
                    }
                }
            }
            return temp_Conatctlist;
        }
        public static void UpdateContactDetailsFromServer(List<Contact> contactsList)
        {
            for (int i = 0; i < contactsList.Count; i++)
            {
                if (DatabaseManager.Manager.ValueExists("Contacts", "HOSTNAME", contactsList[i].HostName))
                {
                    var result = DatabaseManager.Manager.UpdateData("Contacts", $"HOSTNAME='{contactsList[i].HostName}'", new ParameterData("FIRSTNAME", contactsList[i].FirstName), new ParameterData("LASTNAME", contactsList[i].LastName), new ParameterData("DPPICTURE", contactsList[i].DpPicture), new ParameterData("IPADDRESS", contactsList[i].IpAddress), new ParameterData("LASTONLINETIME", contactsList[i].LastOnlineTime));
                }
                else
                {
                    contactsList[i].NewMessageCount = 0;
                    contactsList[i].IsArchived = false;
                    ContactCreate(contactsList[i]);
                }
            }
        }
        public static bool ChangeNewMessageCount(string hostName, int newMessageCount)
        {
            var result = DatabaseManager.Manager.UpdateData("CONTACTS", $"HOSTNAME='{hostName}'", new ParameterData("NEWMESSAGECOUNT", newMessageCount));
            return result.Result;
        }
        public static bool ChangeIsArchived(string hostName, bool isArchived)
        {
            var result = DatabaseManager.Manager.UpdateData("CONTACTS", $"HOSTNAME='{hostName}'", new ParameterData("ISARCHIVED", isArchived));
            return result.Result;
        }
        public static bool ChangeContactFirstName(string hostName, string firstName)
        {
            var result = DatabaseManager.Manager.UpdateData("CONTACTS", $"HOSTNAME='{hostName}'", new ParameterData[] { new ParameterData("FIRSTNAME", firstName) });
            return result.Result;
        }
        public static bool ChangeContactLastName(string hostName, string lastName)
        {
            var result = DatabaseManager.Manager.UpdateData("CONTACTS", $"HOSTNAME='{hostName}'", new ParameterData[] { new ParameterData("LASTNAME", lastName) });
            return result.Result;
        }
        public static string GetContactFirstname(string hostName)
        {
            var result = DatabaseManager.Manager.FetchSingleData("CONTACTS", "FIRSTNAME", $"HOSTNAME='{hostName}'");

            return "" + result.Value;
        }
        public static bool IsContactExists(string hostName)
        {
            var result = DatabaseManager.Manager.ValueExists("CONTACTS", "HOSTNAME", hostName);
            return result.Result;
        }
        public static List<Contact> GetContacts()
        {
            var result = DatabaseManager.Manager.FetchData("CONTACTS", "HOSTNAME IS NOT NULL");
            var value = result.Value;
            List<Contact> temp_Conatctlist = new List<Contact>();
            if (result.Value != null && result.Value.Count > 0)
            {
                for (int i = 0; i < result.Value["HOSTNAME"].Count; i++)
                {
                    try
                    {
                        temp_Conatctlist.Add(new Contact(value["MACADDRESS"][i].ToString(), value["HOSTNAME"][i].ToString(), value["IPADDRESS"][i].ToString(), value["FIRSTNAME"][i].ToString(), value["LASTNAME"][i].ToString(), FilesManager.SaveFilesInDirectoryFolder(FilesManager.FilesPath_D["CONTACTSDPPICTURE"], value["FIRSTNAME"][i].ToString() + "-" + value["IPADDRESS"][i].ToString(), value["DPPICTURE"][i].ToString()), (DateTime)value["LASTONLINETIME"][i], (int)value["NEWMESSAGECOUNT"][i], Convert.ToBoolean(value["ISARCHIVED"][i])));
                    }
                    catch
                    {
                    }
                }
            }
            return temp_Conatctlist;
        }
        public static DateTime GetLastOnlineTime(string hostName)
        {
            var result = DatabaseManager.Manager.FetchSingleData("CONTACTS", "LASTONLINETIME", $"HOSTNAME='{hostName}'");
            try
            {
                return (DateTime)result.Value;
            }
            catch
            {
                return DateTime.MinValue;
            }
        }

        public static List<Contact> GetMessagedContact()
        {
            List<Contact> temp_Conatctlist = new List<Contact>();
            var result = DatabaseManager.Manager.FetchData("CONTACTS", $" HOSTNAME IN ( SELECT FROMHOSTNAME FROM MESSAGES WHERE GROUPID=0 UNION SELECT TOHOSTNAME FROM MESSAGES WHERE GROUPID=0);");
            if (result.Value != null && result.Value.Count > 0)
            {
                for (int i = 0; i < result.Value["HOSTNAME"].Count; i++)
                {
                    try
                    {
                        temp_Conatctlist.Add(new Contact(result.Value["MACADDRESS"][i].ToString(), result.Value["HOSTNAME"][i].ToString(), result.Value["IPADDRESS"][i].ToString(), result.Value["FIRSTNAME"][i].ToString(), result.Value["LASTNAME"][i].ToString(), FilesManager.SaveFilesInDirectoryFolder(FilesManager.FilesPath_D["CONTACTSDPPICTURE"], result.Value["FIRSTNAME"][i].ToString() + "-" + result.Value["IPADDRESS"][i].ToString(), result.Value["DPPICTURE"][i].ToString()), (DateTime)result.Value["LASTONLINETIME"][i], (int)result.Value["NEWMESSAGECOUNT"][i], Convert.ToBoolean(result.Value["ISARCHIVED"][i])));
                    }
                    catch (Exception e)
                    {

                    }
                }
            }
            return temp_Conatctlist;
        }

        //DataGetFromListMethods
        public static bool IsContactExistsinContactsList(string hostName)
        {
            for (int i = 0; i < Contacts_list.Count; i++)
            {
                if (hostName == Contacts_list[i].HostName)
                {
                    return true;
                }
            }
            return false;
        }
        public static string getName(string hostName)
        {
            for (int i = 0; i < Contacts_list.Count; i++)
            {

                if (hostName == Contacts_list[i].HostName)
                {
                    return Contacts_list[i].FirstName;
                }
            }
            return "Unknown";
        }
        public static Contact getContact(string hostName)
        {
            for (int i = 0; i < Contacts_list.Count; i++)
            {
                if (Contacts_list[i].HostName == hostName)
                    return Contacts_list[i];
            }
            return null;
        }
        public static Contact getContactByIpAddress(string Ipaddress)
        {
            for (int i = 0; i < Contacts_list.Count; i++)
            {
                if (Contacts_list[i].IpAddress == Ipaddress)
                    return Contacts_list[i];
            }
            return null;
        }
        public static bool IsContactExitsInMessagedContactsList(Contact contact)
        {
            for (int i = 0; i < MessagedContacts_list.Count; i++)
            {
                if (MessagedContacts_list[i].HostName == contact.HostName)
                {

                    return true;
                }
            }
            ContactsManager.MessagedContacts_list.Add(contact);
            return false;
        }
    }
}

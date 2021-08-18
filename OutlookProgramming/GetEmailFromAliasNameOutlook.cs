using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Office.Interop.Outlook;
using System.Runtime.InteropServices;
using System.IO;
using ObjOutlook = Microsoft.Office.Interop.Outlook;



namespace Stmp_Client_2008
{
public partial class Form1 : Form
{
public String MailsSub;

public String Cc;
public String To;
public String Bcc;
public String SenderMailAddr;


private static ArrayList emailCollection = new ArrayList();
public static Boolean SuccMail = false;
public static Boolean MailFlag = false;

ObjOutlook.Application App = new ObjOutlook.ApplicationClass();
ObjOutlook.NameSpace NS;
ObjOutlook.MAPIFolder CheckFold;
ObjOutlook.MAPIFolder MovingFold;
ObjOutlook.MAPIFolder ErrMovingFold;



const int S_OK = 0;

[DllImport("MAPI32.DLL", CharSet = CharSet.Ansi, EntryPoint = "HrGetOneProp@12")]
private static extern void HrGetOneProp(IntPtr pmp, uint ulPropTag, out IntPtr ppProp);

[DllImport("MAPI32.DLL", CharSet = CharSet.Ansi, EntryPoint = "HrSetOneProp@8")]
private static extern void HrSetOneProp(IntPtr pmp, IntPtr pprop);

[DllImport("MAPI32.DLL", CharSet = CharSet.Ansi, EntryPoint = "MAPIFreeBuffer@4")]
private static extern void MAPIFreeBuffer(IntPtr lpBuffer);

[DllImport("MAPI32.DLL", CharSet = CharSet.Ansi)]
private static extern int MAPIInitialize(IntPtr lpMapiInit);

[DllImport("MAPI32.DLL", CharSet = CharSet.Ansi)]
private static extern void MAPIUninitialize();

const string IID_IMAPIProp = "00020303-0000-0000-C000-000000000046";
const uint PR_SMTP_ADDRESS = 972947486;


public struct SPropValue
{
///

/// Property tag for the property. Property tags are 32-bit unsigned integers consisting of the property's unique identifier in the high-order 16 bits and the property's type in the low-order 16 bits.
///

public uint ulPropTag;

///

/// Reserved for MAPI; do not use.
///

public uint dwAlignPad;

///

/// Union of data values, the specific value dictated by the property type.
///

public long Value;
}


public Form1()
{
InitializeComponent();
}

private void Form1_Load(object sender, EventArgs e)
{

}
private ObjOutlook.MAPIFolder GetFolder(ObjOutlook.Folders ReadFold, string name)
{

ObjOutlook.MAPIFolder TempStr = null;



foreach (ObjOutlook.MAPIFolder MovFold in ReadFold)
{
if (MovFold.Name == name)
{
TempStr = MovFold;
}

if (MovFold.Folders.Count > 0)
{
ObjOutlook.MAPIFolder TempStr2 = null;

TempStr2 = GetFolder(MovFold.Folders, name);
if (TempStr2 != null)
{
TempStr = TempStr2;
}

}
}

return TempStr;

}

//From the URL http://weblogs.asp.net/cumpsd/articles/89697.aspx

private static void AddAddress(string emailAddress)
{

emailAddress = emailAddress.Trim();

emailAddress = emailAddress.ToLower();

if (!emailCollection.Contains(emailAddress))
{

emailCollection.Add(emailAddress);

}

} /* AddAddress */

private string GetEmailAddressFromExchange(string emailName)
{
ObjOutlook.MailItem loDummyMsg = (ObjOutlook.MailItem)App.CreateItem(ObjOutlook.OlItemType.olMailItem);
ObjOutlook.Recipient loAddress = loDummyMsg.Recipients.Add(emailName);
loAddress.Resolve();
string SMTPAddress = GetMAPIProperty(loAddress.AddressEntry.MAPIOBJECT, PR_SMTP_ADDRESS);

return SMTPAddress;
}


private string GetMAPIProperty(object oMAPIObject, uint uiPropertyTag)
{
if (oMAPIObject == null)
{
return "";
}

string sProperty = "";
IntPtr pPropValue = IntPtr.Zero;

IntPtr IUnknown = IntPtr.Zero;
IntPtr IMAPIProperty = IntPtr.Zero;

try
{
MAPIInitialize(IntPtr.Zero);

IUnknown = Marshal.GetIUnknownForObject(oMAPIObject);

Guid guidMAPIProp = new Guid(IID_IMAPIProp);

if (Marshal.QueryInterface(IUnknown, ref guidMAPIProp, out IMAPIProperty) != S_OK)
{
return "";
}

try
{
HrGetOneProp(IMAPIProperty, uiPropertyTag, out pPropValue);

if (pPropValue == IntPtr.Zero)
{
return "";
}

SPropValue propValue = (SPropValue)Marshal.PtrToStructure(pPropValue, typeof(SPropValue));

sProperty = Marshal.PtrToStringAnsi(new IntPtr(propValue.Value));
}
catch (System.Exception ex)
{
throw ex;
}
}
finally
{
if (pPropValue != IntPtr.Zero)
{
MAPIFreeBuffer(pPropValue);
}

if (IMAPIProperty != IntPtr.Zero)
{
Marshal.Release(IMAPIProperty);
}

if (IUnknown != IntPtr.Zero)
{
Marshal.Release(IUnknown);
}

MAPIUninitialize();
}

return sProperty;
}



private void button1_Click(object sender, EventArgs e)
{
NS = App.GetNamespace("MAPI");
CheckFold = GetFolder(NS.Folders, "Sample");
//MovingFold = GetFolder(NS.Folders, "HK_MailRead");
//ErrMovingFold = GetFolder(NS.Folders, "HK_ErrMail");

ObjOutlook.Items olmailItems = CheckFold.Items;
int iter=0;

try
{
//ObjOutlook.MAPIFolder ChkFld = NS.GetDefaultFolder(ObjOutlook.OlDefaultFolders.olFolderInbox);

if (CheckFold.Items.Count > 0)
{
// foreach (ObjOutlook.MailItem ListItem in ChkFld.Items)
//{
for (int iteration = 1; iteration <= CheckFold.Items.Count; iteration++)
{
ObjOutlook.MailItem ListItem = (ObjOutlook.MailItem)CheckFold.Items[iteration];


// }


MailsSub = ListItem.Subject;



if (MailsSub.ToLower().StartsWith("RE") || MailsSub.ToLower().StartsWith("Ka"))
{
//Cc = ListItem.CC.ToString();
//To = ListItem.To.ToString();
//Bcc = ListItem.To.ToString();
//SenderMailAddr = ListItem.SenderEmailAddress.ToString();
}

ObjOutlook.Items ioItems = (ObjOutlook.Items)CheckFold.Items;


string emailname;
string emailWithDomainName;


foreach (ObjOutlook.MailItem olMail in olmailItems)
{
foreach (ObjOutlook.Recipient olRecipient in olMail.Recipients)
{
// string address = olRecipient.AddressEntry.GetExchangeUser().Address.ToString();
try
{

emailname = olRecipient.Name;
emailWithDomainName = GetEmailAddressFromExchange(emailname);
emailCollection[iter] = emailWithDomainName;
iter++;
// ObjOutlook.ContactItem oCt = (ObjOutlook.ContactItem)olmailItems;
//string emaill = oCt.Email1Address.ToString();
}
catch { }
try { AddAddress(olRecipient.Address ); }
catch { }

}
}



try { Cc = ListItem.CC.ToString(); }
catch { }

try { To = ListItem.To.ToString(); }
catch { }
try { Bcc = ListItem.To.ToString(); }
catch { }
try { SenderMailAddr = ListItem.SenderEmailAddress.ToString(); }
catch { }


}
}
}
catch { }

for (int i = 0; i < emailCollection.Count; i++)
{
listBox1.Items.Add(emailCollection[i].ToString());
}
}
}
}

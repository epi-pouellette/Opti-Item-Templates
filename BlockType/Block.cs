using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using System.ComponentModel.DataAnnotations;

namespace $rootnamespace$
{
	[ContentType(GUID = "$guid1$", DisplayName = "$safeitemrootname$", Description = "")]
    public class $safeitemrootname$ : BlockData
    {
        //[Display(
        //    GroupName = SystemTabNames.Content,
        //    Order = 320)]
        //public virtual ContentArea MainContentArea { get; set; }
    }
}

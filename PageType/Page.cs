using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using System.ComponentModel.DataAnnotations;

namespace $rootnamespace$
{
    /// <summary>
    /// Used for the pages mainly consisting of manually created content such as text, images, and blocks
    /// </summary>
    [ContentType(GUID="$guid1$", DisplayName = "$safeitemrootname$", Description = "")]
    public class $safeitemrootname$ : PageData
    {
        //[Display(
        //    GroupName = SystemTabNames.Content,
        //    Order = 310)]
        //[CultureSpecific]
        //public virtual XhtmlString MainBody { get; set; }

        //[Display(
        //    GroupName = SystemTabNames.Content,
        //    Order = 320)]
        //public virtual ContentArea MainContentArea { get; set; }
    }
}

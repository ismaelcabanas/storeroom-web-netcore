using System.ComponentModel.DataAnnotations;

namespace storeroom_web_netcore.ViewModels
{
    public class StoreroomEditViewModel
    {
        [Required, MaxLength(25)]
        public string Name { get; set; }
    }
}
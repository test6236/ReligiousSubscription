using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ReligiousSubscription.Model.Person;
using ReligiousSubscription.Model.Object;
using System.Web.Mvc;

namespace ReligiousSubscription.Model.Object.Object_View_Model
{
    public class PaymentVM
    {
        public int ColectorID { get; set; }
        public int PriceID { get; set; }

        public String PaimentDate { get; set; }

        public List<Collector> Colectors { get; set; }
        public List<PaymentType> Price { get; set; }

        public String ReasonForFreeing { get; set; }
        public Boolean isFreeFromPaiment { get; set; }

        public List<SelectListItem> ColectorAsSelectListItem
        {
            get
            {
                List<SelectListItem> itemsToShow = new List<SelectListItem>();

                foreach (Collector Item in Colectors)
                {
                    itemsToShow.Add(new SelectListItem() { Text = Item.Name + " " + Item.Lastname, Value = Item.Id.ToString() });
                }

                return itemsToShow;
            }
        }

        public List<SelectListItem> PriceAsSelectListItem
        {
            get {
                List<SelectListItem> itemsToShow = new List<SelectListItem>();

                foreach (PaymentType Item in Price)
                {
                    itemsToShow.Add(new SelectListItem() { Text = Item.Name + " " + Item.Amount, Value = Item.Id.ToString() });
                }

                return itemsToShow;
            }
        }

    }
}

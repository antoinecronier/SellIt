using SellItCore.Entities.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellItCore.Entities
{
    public class ProductType : EntityBase, DbEntity
    {
        #region StaticVariables
        #endregion

        #region Constants
        #endregion

        #region Variables
        #endregion

        #region Attributs
        private long id;
        private String name;
        private float basePrice;
        private Dictionary<String,Object> properties;
        private List<Category> categories;
        #endregion

        #region Properties
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id
        {
            get { return id; }
            set { id = value; }
        }

        [Required]
        public String Name
        {
            get { return name; }
            set { name = value; }
        }

        [Required]
        public float BasePrice
        {
            get { return basePrice; }
            set { basePrice = value; }
        }

        [NotMapped]
        public Dictionary<String, Object> Properties
        {
            get { return properties; }
            set { properties = value; }
        }

        /// <summary>
        /// Just have to be used by database.
        /// </summary>
        public String Dictionnary
        {
            get
            {
                return Newtonsoft.Json.JsonConvert.SerializeObject(this.properties);
            }
            set
            {
                this.properties = Newtonsoft.Json.JsonConvert.DeserializeObject<Dictionary<String, Object>>(value);
            }
        }

        public List<Category> Categories
        {
            get { return categories; }
            set { categories = value; }
        }
        #endregion

        #region Constructors
        /// <summary>
        /// Default constructor.
        /// </summary>
        public ProductType()
        {
            this.properties = new Dictionary<string, object>();
            this.categories = new List<Category>();
        }
        #endregion

        #region StaticFunctions
        #endregion

        #region Functions
        #endregion

        #region Events
        #endregion
    }
}

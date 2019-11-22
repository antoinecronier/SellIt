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
    public class Product : EntityBase, DbEntity
    {
        #region StaticVariables
        #endregion

        #region Constants
        #endregion

        #region Variables
        #endregion

        #region Attributs
        private long id;
        private DateTime stockEnterAt;
        private DateTime stockSelledAt;
        private Dictionary<String,Object> additionnalProperties;
        private ProductType productType;
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
        [Column(TypeName = "datetime2")]
        public DateTime StockEnterAt
        {
            get { return stockEnterAt; }
            set { stockEnterAt = value; }
        }
        
        [Column(TypeName = "datetime2")]
        public DateTime StockSelledAt
        {
            get { return stockSelledAt; }
            set { stockSelledAt = value; }
        }

        [NotMapped]
        public Dictionary<String, Object> AdditionnalProperties
        {
            get { return additionnalProperties; }
            set { additionnalProperties = value; }
        }
        
        /// <summary>
        /// Just have to be used by database.
        /// </summary>
        public String Dictionnary
        {
            get
            {
                return Newtonsoft.Json.JsonConvert.SerializeObject(this.additionnalProperties);
            }
            set
            {
                this.additionnalProperties = Newtonsoft.Json.JsonConvert.DeserializeObject<Dictionary<String,Object>>(value);
            }
        }

        public ProductType ProductType
        {
            get { return productType; }
            set { productType = value; }
        }
        #endregion

        #region Constructors
        /// <summary>
        /// Default constructor.
        /// </summary>
        public Product()
        {
            this.additionnalProperties = new Dictionary<string, object>();
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

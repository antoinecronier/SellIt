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
    public class Order : EntityBase, DbEntity
    {
        #region StaticVariables
        #endregion

        #region Constants
        #endregion

        #region Variables
        #endregion

        #region Attributs
        private long id;
        private DateTime orderDate;
        private Boolean isValidated;
        private List<Product> products;
        #endregion

        #region Properties
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id
        {
            get { return this.id; }
            set { this.id = value; }
        }

        [Column(TypeName = "datetime2")]
        public DateTime OrderDate
        {
            get { return orderDate; }
            set { orderDate = value; }
        }

        public Boolean IsValidated
        {
            get { return isValidated; }
            set { isValidated = value; }
        }

        public List<Product> Products
        {
            get { return products; }
            set { products = value; }
        }
        #endregion

        #region Constructors
        /// <summary>
        /// Default constructor.
        /// </summary>
        public Order()
        {
            this.products = new List<Product>();
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

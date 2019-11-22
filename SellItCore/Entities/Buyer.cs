using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellItCore.Entities
{
    public class Buyer : Person
    {
        #region StaticVariables
        #endregion

        #region Constants
        #endregion

        #region Variables
        #endregion

        #region Attributs
        private float money;
        private List<Order> orders;
        #endregion

        #region Properties
        public float Money
        {
            get { return money; }
            set { money = value; }
        }

        public List<Order> Orders
        {
            get { return orders; }
            set { orders = value; }
        }
        #endregion

        #region Constructors
        /// <summary>
        /// Default constructor.
        /// </summary>
        public Buyer()
        {
            this.orders = new List<Order>();
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

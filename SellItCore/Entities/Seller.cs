using SellItCore.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellItCore.Entities
{
    public class Seller : Person, Logable
    {
        #region StaticVariables
        #endregion

        #region Constants
        #endregion

        #region Variables
        #endregion

        #region Attributs
        private String login;
        private String password;
        private List<Order> orders;
        #endregion

        #region Properties
        public String Login
        {
            get { return login; }
            set { login = value; }
        }

        public String Password
        {
            get { return password; }
            set { password = value; }
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
        public Seller()
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

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
    public class Person : EntityBase, DbEntity
    {
        #region StaticVariables
        #endregion

        #region Constants
        #endregion

        #region Variables
        #endregion

        #region Attributs
        private long id;
        private String firstname;
        private String lastname;
        private String email;
        private DateTime dateOfBirth;
        #endregion

        #region Properties
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id
        {
            get { return this.id; }
            set { this.id = value; }
        }

        [Required]
        public String Firstname
        {
            get { return firstname; }
            set { firstname = value; }
        }

        [Required]
        public String Lastname
        {
            get { return lastname; }
            set { lastname = value; }
        }

        [Required]
        [EmailAddress]
        public String Email
        {
            get { return email; }
            set { email = value; }
        }

        [Column(TypeName = "datetime2")]
        public DateTime DateOfBirth
        {
            get { return dateOfBirth; }
            set { dateOfBirth = value; }
        }
        #endregion

        #region Constructors
        /// <summary>
        /// Default constructor.
        /// </summary>
        public Person()
        {

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

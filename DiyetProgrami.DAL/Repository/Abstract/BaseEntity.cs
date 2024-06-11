using DiyetProgrami.DAL.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiyetProgrami.DAL.Repository.Abstract
{
    public class BaseEntity : IEntity
    {
        public Guid Id { get ; set; }
        public DateTime CreatedDate { get ; set ; }
        public DateTime? ModifiedDate { get ; set  ; }
        public DateTime? DeletedDate { get  ; set ; }
        public DataStatus DataStatus { get; set; }
    }
}

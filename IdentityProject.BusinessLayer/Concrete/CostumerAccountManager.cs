using IdentityProject.BusinessLayer.Abstract;
using IdentityProject.DAL.Abstract;
using IdentityProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdentityProject.BusinessLayer.Concrete
{
    public class CostumerAccountManager : ICustomerAccountService
    {
        private readonly ICostumerAccountDal _costumerAccountDal;

        public CostumerAccountManager(ICostumerAccountDal costumerAccountDal )
        {
            _costumerAccountDal = costumerAccountDal;
        }
        public void TDelete(CustomerAccount t)
        {
           _costumerAccountDal.Delete(t);
        }

        public List<CustomerAccount> TGetAll()
        {
            return _costumerAccountDal.GetAll();
        }

        public CustomerAccount TGetById(int id)
        {
           return _costumerAccountDal.GetById(id);
        }

        public void TInsert(CustomerAccount t)
        {
            _costumerAccountDal.Insert(t);
        }

        public void TUpdate(CustomerAccount t)
        {
            _costumerAccountDal.Update(t);
        }
    }
}

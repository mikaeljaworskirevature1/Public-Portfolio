using AccountService.DTO;
using AccountService.Data.Entities;

namespace AccountService.Business;

    public interface ILogic
    {
        List<Account> ViewAccount(Int32 userFkId);

        List<Transfer> ViewTransfers(Int32 releasedFk);

        void TransferAmount(TransferDTO transfer) {}
    }
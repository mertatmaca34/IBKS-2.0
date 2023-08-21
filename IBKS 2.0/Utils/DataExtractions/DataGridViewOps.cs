using Business.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ibks.Utils.DataExtractions
{
    /*public class DataGridViewOps
    {
        public void FindAndUpdateUserMail(IMailStatementService mailStatementManager, string searchUserWithMail, int searchStatementWithId, string process)
        {
            int userId = GetUserId(searchUserWithMail);
            int statementId = GetStatementId(searchStatementWithId);

            if (userId > 0 && statementId > 0)
            {
                UserMailStatementsDTO userMailStatementsDTO = new UserMailStatementsDTO
                {
                    UserId = userId,
                    StatementId = statementId
                };

                if (process == "add")
                {
                    userMailStatementService.Add(userMailStatementsDTO);
                }
                else if (process == "delete")
                {
                    var userMailStatementDTO = userMailStatementService.GetAll();
                    var resUserMailStatementDTO = userMailStatementDTO.FirstOrDefault(c => c.UserId == userId && c.StatementId == statementId);

                    userMailStatementService.Delete(resUserMailStatementDTO.Id);
                }
            }
        }
        public int GetUserId(string searchUserWithMail)
        {
            var userDTO = userDTOService.GetAll();
            var resUserDTO = userDTO.FirstOrDefault(c => c.Email == searchUserWithMail);

            return resUserDTO.Id;
        }
        public int GetStatementId(int id)
        {
            var statementDTO = mailStatementService.GetAll();
            var resStatementDTO = statementDTO.FirstOrDefault(c => c.Id == id);

            return resStatementDTO.Id;
        }
        public void GetUserMailStatements(DataGridView dataGridView, string searchUserWithMail)
        {
            var data = userMailStatementService.GetAll();
            int? userId = GetUserId(searchUserWithMail);
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (userId.HasValue)
                {
                    var resUserMailStatementDTO = data.FirstOrDefault(c => c.UserId == userId && c.StatementId == (int)row.Cells[1].Value);
                    if (resUserMailStatementDTO != null)
                    {
                        row.Cells[0].Value = true;
                        row.Cells[0].Value = row.Cells[0].EditedFormattedValue;
                    }
                    else
                    {
                        row.Cells[0].Value = false;
                        row.Cells[0].Value = row.Cells[0].EditedFormattedValue;
                    }
                }
            }
        }
    }*/
}

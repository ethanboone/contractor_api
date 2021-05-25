namespace contractor_api.Repositories
{
    public class ContractorJobRepository
    {
        public
        public string Delete(int id)
        {
            string sql = "
             ";
             int deleted = _db.Execute(sql, new { id });
            if (deleted == 1)
            {
                return "Successfully Deleted";
            }
            else
            {
                throw new System.Exception("Invalid Id");
            }
        }
    }
}